using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("StringInterpolationBridge")]
[assembly: AssemblyDescription("Provides FormattableString/FormattableStringFactory for pre-4.6 .NET Framework.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Andrey Shchekin")]
[assembly: AssemblyProduct("StringInterpolationBridge")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("56758ccc-35c9-4035-9d03-63cf8345da13")]

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
[assembly: AssemblyVersion(AssemblyInfo.VersionString)]
[assembly: AssemblyFileVersion(AssemblyInfo.VersionString)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.VersionString)]

// ReSharper disable once CheckNamespace
internal static class AssemblyInfo {
    public const string VersionString = "0.9.0";
}