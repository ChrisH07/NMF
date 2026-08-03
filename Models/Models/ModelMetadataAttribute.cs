using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NMF.Models
{
    /// <summary>
    /// Declares that the assembly includes code for a given metamodel
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class ModelMetadataAttribute : Attribute
    {
        /// <summary>
        /// The model uri
        /// </summary>
        public Uri ModelUri { get; private set; }

        /// <summary>
        /// the name of the resource
        /// </summary>
        public string ResourceName { get; private set; }

        /// <summary>
        /// Defines that the assembly contains a model at the given embedded resource name
        /// </summary>
        /// <param name="modelUri">The URI of the model</param>
        /// <param name="resourceName">The resource name or name suffix</param>
        public ModelMetadataAttribute(string modelUri, string resourceName)
        {
            Uri parsedModelUri;
            if (Uri.TryCreate(modelUri, UriKind.Absolute, out parsedModelUri))
            {
                ModelUri = parsedModelUri;
            }
            else
            {
                ModelUri = new Uri(modelUri, UriKind.Relative);
            }
            ResourceName = resourceName;
        }

        /// <summary>
        /// Loads the manifest stream containing the metamodel from the given assembly and resource names. If the resource name is not found, an exception is thrown.
        /// </summary>
        /// <param name="assembly">The assembly to which this attribute is attached</param>
        /// <param name="resourceNames">the resource names available for the given assembly</param>
        /// <returns>A stream containing the metamodel described by this instance</returns>
        public virtual Stream LoadMetamodel(Assembly assembly, string[] resourceNames)
        {
            var actualResourceName = FindResourceName(assembly, resourceNames);
            return assembly.GetManifestResourceStream(actualResourceName);
        }

        private string FindResourceName(Assembly assembly, string[] names)
        {
            var resourceName = ResourceName;
            if (!names.Contains(ResourceName))
            {
                var resources = names.Where(n => n.EndsWith(resourceName)).ToList();
                if (resources.Count == 1)
                {
                    resourceName = resources[0];
                }
                else if (resources.Count == 0)
                {
                    throw new InvalidOperationException($"Embedded resource {resourceName} was not found in assembly {assembly.FullName}.");
                }
                else
                {
                    throw new InvalidOperationException($"Multiple embedded resources with the suffix {resourceName} were found in {assembly.FullName}.");
                }
            }

            return resourceName;
        }
    }
}
