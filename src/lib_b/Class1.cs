using System;
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("NDepend", "", Target = "LibA", Justification = "OK for minimal bug repro")]
namespace LibA
{
    [SuppressMessage("NDepend", "ND2103:NamespaceNameShouldCorrespondToFileLocation", Justification = "not here")]
    public static class Class1
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
