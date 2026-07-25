using NMF.CodeGen;
using NMF.Transformations.Core;
using NMF.Utilities;
using System.CodeDom;
using System.Collections.Generic;
using NMF.Transformations;

#pragma warning disable S3265 // Non-flags enums should not be used in bitwise operations

namespace NMF.Models.Meta
{
    public partial class Meta2ClassesTransformation
    {
        /// <summary>
        /// Denotes the transformation rule from a feature to a proxy type
        /// </summary>
        public class Feature2Proxy : TransformationRule<ITypedElement, CodeTypeDeclaration>
        {
            /// <inheritdoc />
            public override void Transform(ITypedElement feature, CodeTypeDeclaration generatedType, ITransformationContext context)
            {
                var declaringType = context.Trace.ResolveIn(Rule<Type2Type>(), feature.Parent as IType).GetReferenceForType();

                // Qualified with the declaring type's name: a reference that refines/redefines a base feature
                // keeps the same feature name, so an unqualified name would collide with the base feature's own proxy.
                // Class2Type.AddToExpressionForFeature constructs this same name independently and must stay in sync.
                generatedType.Name = (feature.Parent as IType).Name.ToPascalCase() + feature.Name.ToPascalCase() + "Proxy";
                // Protected, not private: a derived class's own generated children-collection class (see
                // Class2Children) constructs proxies for containment references it inherits, including ones
                // declared on a base class, so the proxy must be visible outside its declaring class.
                generatedType.Attributes = MemberAttributes.Family | MemberAttributes.Final;
                generatedType.TypeAttributes = System.Reflection.TypeAttributes.NestedFamily | System.Reflection.TypeAttributes.Sealed;
                generatedType.WriteDocumentation(string.Format("Represents a proxy to represent an incremental access to the {0} property", feature.Name));

                var type = CreateReference(feature.Type, feature is IReference, context);
                var t = Transformation as Meta2ClassesTransformation;
                if ((t == null || t.IsValueType(feature.Type)) && feature.LowerBound == 0 && feature.UpperBound == 1)
                {
                    type = new CodeTypeReference(typeof(System.Nullable<>).Name, type);
                }

                generatedType.BaseTypes.Add(new CodeTypeReference("ModelPropertyChange", declaringType, type));

                var modelElementRef = new CodePropertyReferenceExpression(new CodeThisReferenceExpression(), "ModelElement");

                var property = context.Trace.ResolveIn(Rule<Feature2Property>(), feature);

                var propertyRef = new CodePropertyReferenceExpression(modelElementRef, property.Name);
                var propertyChanged = new CodeEventReferenceExpression(modelElementRef, property.Name + "Changed");

                var value = new CodeMemberProperty()
                {
                    Name = "Value",
                    Attributes = MemberAttributes.Public | MemberAttributes.Override,
                    Type = type
                };
                value.WriteDocumentation("Gets or sets the value of this expression");
                value.GetStatements.Add(new CodeMethodReturnStatement(propertyRef));
                value.SetStatements.Add(new CodeAssignStatement(propertyRef, new CodePropertySetValueReferenceExpression()));
                generatedType.Members.Add(value);
                
                var constructor = new CodeConstructor()
                {
                    Attributes = MemberAttributes.Public
                };
                constructor.WriteDocumentation("Creates a new observable property access proxy", null, new Dictionary<string, string>()
                {
                    { "modelElement", "The model instance element for which to create the property access proxy" }
                });
                constructor.Parameters.Add(new CodeParameterDeclarationExpression(declaringType, "modelElement"));
                constructor.BaseConstructorArgs.Add(new CodeArgumentReferenceExpression("modelElement"));
                constructor.BaseConstructorArgs.Add(new CodePrimitiveExpression(property.Name));
                generatedType.Members.Add(constructor);
            }
        }
    }
}

#pragma warning restore S3265 // Non-flags enums should not be used in bitwise operations