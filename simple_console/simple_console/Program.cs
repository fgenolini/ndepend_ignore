using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("NDepend", "ND2800:MarkAssembliesWithAssemblyVersion", Justification = "false positive from NDepend, version set in project file")]
[assembly: SuppressMessage("NDepend", "ND1305:AvoidNamespacesWithFewTypes", Target = "SimpleConsole", Justification = "OK for minimal bug repro")]
[assembly: SuppressMessage("NDepend", "ND2801:AssembliesShouldHaveTheSameVersion", Justification = "not here")]
namespace SimpleConsole
{
    [SuppressMessage("NDepend", "ND2103:NamespaceNameShouldCorrespondToFileLocation", Justification = "not here")]
    sealed class Program
    {
        static void Main()
        {
            LibA.Class1.SayHello();
        }
    }
}
