using NMF.CodeGen;
using NMF.Transformations;
using NMF.Transformations.Core;
using NMF.Utilities;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace NMF.Models.Meta
{
    public partial class Meta2ClassesTransformation
    {
        /// <summary>
        /// The transformation rule that generates the collection class for the ReferencedElements reference
        /// </summary>
        public class Class2Referenced : Class2Children
        {

            /// <inheritdoc />
            protected override List<IReference> GetImplementingReferences(IClass scope, ITransformationContext context)
            {
                // See the base class override: a reference is excluded here precisely when some other reference
                // visible to scope refines it, decided from the Refines relationships in the metamodel itself
                // rather than from generatedType.Members, which is not yet populated when this runs.
                var allReferences = scope.Closure(c => c.BaseTypes).SelectMany(c => c.References).ToList();
                var refinedAway = new HashSet<IReference>(allReferences.Select(r => r.Refines).Where(r => r != null));
                return allReferences.Where(r => !refinedAway.Contains(r)).ToList();
            }

            /// <summary>
            /// Creates the uninitialized output type declaration
            /// </summary>
            /// <param name="scope">The scope in which the reference is refined</param>
            /// <param name="context">The transformation context</param>
            /// <returns>The newly created code type declaration</returns>
            public override CodeTypeDeclaration CreateOutput(IClass scope, ITransformationContext context)
            {
                if (!scope.References.Any()) return null;
                return CodeDomHelper.CreateTypeDeclarationWithReference(scope.Name.ToPascalCase() + "ReferencedElementsCollection", false);
            }
        }
    }
}
