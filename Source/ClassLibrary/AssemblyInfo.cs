/*

 Copyright (c) 2004-2006 Tomas Matousek, Ladislav Prosek, Pavel Novak, Jan Benda.  

 The use and distribution terms for this software are contained in the file named License.txt, 
 which can be found in the root of the Phalanger distribution. By using this software 
 in any fashion, you are agreeing to be bound by the terms of this license.
 
 You must not remove this notice from this software.

*/

using System.Reflection;
using System.Runtime.CompilerServices;
using PHP.Core;
using System.Security;

#if !SILVERLIGHT
[assembly: AssemblyTitle("Phalanger Base Class Library")]
[assembly: AssemblyDescription("Phalanger Base Class Library")]
//[assembly: AllowPartiallyTrustedCallers]

//#if DEBUG
[assembly: PhpLibrary(
    typeof(PHP.Library.LibraryDescriptor),
    "Base Library",
    new string[]{"standard","Core","session","ctype","tokenizer","date","pcre","ereg","json","hash","SPL","filter"})]
//#else
//[assembly: PhpLibrary(typeof(PHP.Library.LibraryDescriptor), "Base Library", false, true)]
//#endif

#else
[assembly: AssemblyTitle("Phalanger Base Class Library (Silverlight)")]
[assembly: AssemblyDescription("Phalanger Base Class Library (Silverlight)")]
[assembly: AssemblyVersion("4.0.0.0")]
[assembly: PhpLibrary(typeof(PHP.Library.LibraryDescriptor), "Base Library")]
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyDelaySign(false)]

[assembly: InternalsVisibleTo("PhpNet.ClassLibrary.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100cdeef915479b86e2633bbd8796635d6114d25cfab4d836c7c57b07af1464b79cd0d9a8c52abe8df4806b83be7372d48a5aa90f32a25f484c5a7c667ab53a542e5261fc9978e0fdf4da339da691733bdf140bd66525dc2714e9cc85eb32e35c80170a188317990622cc3bbf019fb4c57db3414bdc1fc4072d18db33c1b0cc31dd")]