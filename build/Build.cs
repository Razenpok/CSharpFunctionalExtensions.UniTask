using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Nuke.Common;
using Nuke.Common.IO;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.TextTasks;
using static Nuke.Common.Tools.Git.GitTasks;

class Build : NukeBuild
{
    public static int Main () => Execute<Build>(x => x.GeneratePackage);

    Target GeneratePackage => _ => _
        .Executes(() =>
        {
            var repoPath = TemporaryDirectory / "source";
            var shouldClone = (IsLocalBuild && !repoPath.DirectoryExists()) || IsServerBuild;
            if (shouldClone)
            {
                EnsureCleanDirectory(repoPath);
                Git("clone https://github.com/vkhorikov/CSharpFunctionalExtensions .", repoPath);
            }

            CopyExtensions(
                repoPath /"CSharpFunctionalExtensions/Result/Methods/Extensions",
                RootDirectory / "src/CSharpFunctionalExtensions.UniTask/Runtime/Result/Extensions"
            );

            CopyExtensions(
                repoPath / "CSharpFunctionalExtensions/Maybe/Extensions",
                RootDirectory / "src/CSharpFunctionalExtensions.UniTask/Runtime/Maybe/Extensions"
            );
        });

    void CopyExtensions(AbsolutePath from, AbsolutePath to)
    {
        var blacklist = new[]
        {
            "OnFailure.ValueTask.cs",
            "OnFailure.ValueTask.Left.cs",
            "OnFailure.ValueTask.Right.cs",
            "BindWithTransactionScope.ValueTask.cs",
            "BindWithTransactionScope.ValueTask.Left.cs",
            "BindWithTransactionScope.ValueTask.Right.cs",
            "MapWithTransactionScope.ValueTask.cs",
            "MapWithTransactionScope.ValueTask.Left.cs",
            "MapWithTransactionScope.ValueTask.Right.cs"
        };
        EnsureCleanDirectory(to);
        foreach (var file in from.GlobFiles("*"))
        {
            var name = file.Name;
            if (!name.Contains("ValueTask") || blacklist.Contains(name))
            {
                continue;
            }

            var lines = ReadAllLines(file).ToList();
            var targetFile = to / name.Replace("ValueTask", "UniTask");
            var enableNullable = name.Contains("EnsureNotNull");
            WriteAllLines(targetFile, FilterFileLines(lines, enableNullable));
            WriteAllText(targetFile + ".meta", GenerateScriptMeta(targetFile));
        }
    }

    static IEnumerable<string> FilterFileLines(IEnumerable<string> lines, bool enableNullable)
    {
        if (enableNullable)
        {
            yield return "#nullable enable";
        }
        foreach (var line in lines)
        {
            if (line.Contains('#'))
            {
                continue;
            }

            if (line.Contains("System.Threading.Tasks"))
            {
                yield return line.Replace("System.Threading.Tasks", "Cysharp.Threading.Tasks");
            }
            else if (line.Contains("CSharpFunctionalExtensions.ValueTasks"))
            {
                yield return line.Replace("CSharpFunctionalExtensions.ValueTasks", "CSharpFunctionalExtensions");
            }
            else
            {
                yield return line
                    .Replace("tasks.Select(x=> x.AsTask())", "tasks")
                    .Replace("ValueTask", "Task")
                    .Replace("Task", "UniTask")
                    .Replace("Result.Try", "ResultUniTask.Try")
                    .Replace(".DefaultAwait()", "");
            }
        }
    }

    static string GenerateScriptMeta(string path)
    {
        var indexOfRoot = path.IndexOf("CSharpFunctionalExtensions.UniTask", StringComparison.Ordinal);
        var relativePath = path.Substring(indexOfRoot);
        var guid = StringToGuid(relativePath);
        return $@"fileFormatVersion: 2
guid: {guid:N}
MonoImporter:
  externalObjects: {{}}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {{instanceID: 0}}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
";
    }
    
    static Guid StringToGuid(string text)
    {
        var guid = new byte[16];
        var inputBytes = Encoding.UTF8.GetBytes(text);
        var hash = SHA1.HashData(inputBytes);
        Array.Copy(hash, 0, guid, 0, guid.Length);

        // Follow UUID for SHA1 based GUID 
        const int version = 5; // SHA1 (3 for MD5)
        guid[6] = (byte)((guid[6] & 0x0F) | (version << 4));
        guid[8] = (byte)((guid[8] & 0x3F) | 0x80);
        return new Guid(guid);
    }
}
