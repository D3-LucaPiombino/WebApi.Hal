using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("Jake Ginnivan")]
[assembly: AssemblyCopyright("Copyright © Jake Ginnvan 2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]



// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(SemVer.Base)]
[assembly: AssemblyInformationalVersion(SemVer.Semantic)]

#pragma warning disable CS7035 // The specified version string does not conform to the recommended format - major.minor.build.revision
[assembly: AssemblyFileVersion(SemVer.Semantic)]

static class SemVer
{
    public const string Base = "2.5.2";
    public const string Semantic = Base + "-beta00002";
}


