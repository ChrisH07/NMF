using NMF.Transformations.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace NMF.Synchronizations.Debug
{
	public static class DebugExtensions
	{
		[Conditional("DEBUG")]
		public static void Visualize(this Synchronization synchronization)
		{
			var file = Path.GetTempFileName();
			File.Delete(file);
			file = Path.ChangeExtension(file, ".dgml");
			File.WriteAllText(file, DgmlExporter.Export(synchronization));
			var process = new Process();
			process.StartInfo.FileName = file;
			process.StartInfo.UseShellExecute = true;
			process.Start();
		}

		public static void ExportToDgml(this Synchronization synchronization, string path)
		{
			File.WriteAllText(path, DgmlExporter.Export(synchronization));
		}
	}

	public class DgmlExporter
	{
		public static string Export(Synchronization synchronization)
		{
			synchronization.Initialize();
			Dictionary<GeneralTransformationRule, SynchronizationRuleBase> rules = new Dictionary<GeneralTransformationRule, SynchronizationRuleBase>();

			var builder = new StringBuilder();
			builder.AppendLine("<?xml version=\"1.0\" encoding=\"utf - 8\"?>");
			builder.AppendLine("<DirectedGraph xmlns=\"http://schemas.microsoft.com/vs/2009/dgml\" Layout=\"Sugiyama\" GraphDirection=\"TopToBottom\">");
			builder.AppendLine("  <Nodes>");
			foreach (var rule in synchronization.Rules)
			{
				SynchronizationRuleBase sr = (SynchronizationRuleBase)rule.GetType().GetProperty("SynchronizationRule").GetValue(rule);
				if (rules.ContainsValue(sr))
				{
					continue;
				}
				rules.Add(rule, sr);

				//string label = $"{rule}\r\n{rule.InputType[0].Name}->{rule.OutputType.Name}";
				string line = $"    <Node Id=\"{sr.GetType().Name}\"";

				if (rule.ChildTransformations != null)
				{
					line += " FontStyle=\"Italic\"";
				}

				builder.AppendLine(line + "/>");
			}
			builder.AppendLine("  </Nodes>");
			builder.AppendLine("  <Links>");
			foreach (GeneralTransformationRule rule in synchronization.Rules)
			{
				string direction = rule.ToString().Split(new char[] { ' ' })[0];
				string leftRule = rule.ToString().Split(new char[] { ' ' })[2];

				foreach (var dependency in rule.Dependencies)
				{
					SynchronizationRuleBase source = rules[rule];
					string rightRule = "";
					string many = "";

					Type type = dependency.GetType();

					if (type.GetGenericTypeDefinition() == typeof(OneWaySynchronizationMultipleDependency<,,,>)
						|| type.GetGenericTypeDefinition() == typeof(SynchronizationMultipleDependency<,,,>))
					{
					    object o = type.GetField("childRule", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(dependency);
						object p = o.GetType().GetProperty("SynchronizationRule").GetValue(o);
						rightRule = p.GetType().Name;
						many = " Many";
					}
					else if (type.GetGenericTypeDefinition() == typeof(SynchronizationSingleDependency<,,,>))
					{
						object o = type.GetField("childRule", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(dependency);
						object p = o.GetType().GetProperty("SynchronizationRule").GetValue(o);
						rightRule = p.GetType().Name;
					}

					if (direction.Equals("LTR"))
					{
						builder.AppendLine($"    <Link Source=\"{leftRule}\" Target=\"{rightRule}\" Label=\"{direction + many}\"/>");
					}
					else
					{
						builder.AppendLine($"    <Link Source=\"{rightRule}\" Target=\"{leftRule}\" Label=\"{direction + many}\"/>");
					}
				}
			}
			builder.AppendLine("  </Links>");
			builder.AppendLine("</DirectedGraph>");
			return builder.ToString();
		}
	}
}
