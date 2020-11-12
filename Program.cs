using System;
using System.Runtime.InteropServices;

namespace PlatformTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"AppContext.BaseDirectory {AppContext.BaseDirectory}");
            Console.WriteLine($"RuntimeInformation.RuntimeIdentifier {RuntimeInformation.RuntimeIdentifier}");
            Console.WriteLine($"RuntimeInformation.OSDescription {RuntimeInformation.OSDescription}");
            Console.WriteLine($"RuntimeInformation.ProcessArchitecture {RuntimeInformation.ProcessArchitecture}");
            Console.WriteLine($"RuntimeInformation.OSArchitecture {RuntimeInformation.OSArchitecture}");
            // Console.WriteLine($"Environment.OSDescription {Environment.OSDescription}");
            Console.WriteLine( $"{Microsoft.DotNet.PlatformAbstractions.RuntimeEnvironment.OperatingSystemPlatform.ToString().ToLower()}-{Microsoft.DotNet.PlatformAbstractions.RuntimeEnvironment.RuntimeArchitecture}");
        }
    }
}
