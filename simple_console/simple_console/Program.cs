using System;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("NDepend", "ND2800:MarkAssembliesWithAssemblyVersion", Justification = "false positive from NDepend, version set in project file")]
namespace simple_console
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
