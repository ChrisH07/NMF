using System.Diagnostics;
using System.IO;
using System.Text;

namespace NMF.Transformations.Core.Debug
{
	public static class DebugExtensions
	{
		[Conditional("DEBUG")]
		public static void Visualize(this Transformation transformation)
		{
			var file = Path.GetTempFileName();
			File.Delete(file);
			file = Path.ChangeExtension(file, ".dgml");
			File.WriteAllText(file, DgmlExporter.Export(transformation));
			var process = new Process();
			process.StartInfo.FileName = file;
			process.StartInfo.UseShellExecute = true;
			process.Start();
		}

		public static void ExportToDgml(this Transformation transformation, string path)
		{
			File.WriteAllText(path, DgmlExporter.Export(transformation));
		}
	}

	public class DgmlExporter
	{
		public static string Export(Transformation transformation)
		{
			transformation.Initialize();

			var builder = new StringBuilder();
			builder.AppendLine("<?xml version=\"1.0\" encoding=\"utf - 8\"?>");
			builder.AppendLine("<DirectedGraph xmlns=\"http://schemas.microsoft.com/vs/2009/dgml\" Layout=\"Sugiyama\" GraphDirection=\"TopToBottom\">");
			builder.AppendLine("  <Nodes>");
			foreach (GeneralTransformationRule rule in transformation.Rules)
			{
				//string label = $"{rule}\r\n{rule.InputType[0].Name}->{rule.OutputType.Name}";
				string line = $"    <Node Id=\"{rule}\"";

				if (rule.ChildTransformations != null)
				{
					line += " FontStyle=\"Italic\"";
				}

				builder.AppendLine(line + "/>");
			}
			builder.AppendLine("  </Nodes>");
			builder.AppendLine("  <Links>");
			foreach (GeneralTransformationRule rule in transformation.Rules)
			{
				foreach (Dependency dependency in rule.Dependencies)
				{
					string dep = dependency.DependencyTransformation.ToString();
					string method = "";
					if (dependency.Filter != null)
					{
						method = dependency.Filter.Method.Name.Split(new char[] { '<', '>' })[1];
					}
					else if (dependency is SingleDependency singleDependency)
					{
						method = singleDependency.Selector.Method.Name.Split(new char[] { '<', '>' })[1];
					}

					builder.AppendLine($"    <Link Source=\"{rule}\" Target=\"{dep}\" Label=\"{method}\"/>");
				}
			}
			builder.AppendLine("  </Links>");
			builder.AppendLine("</DirectedGraph>");
			return builder.ToString();
		}
	}
}
