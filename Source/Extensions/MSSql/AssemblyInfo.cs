/*

 Copyright (c) 2005-2006 Tomas Matousek and Martin Maly.  

 The use and distribution terms for this software are contained in the file named License.txt, 
 which can be found in the root of the Phalanger distribution. By using this software 
 in any fashion, you are agreeing to be bound by the terms of this license.
 
 You must not remove this notice from this software.

*/

using System.Reflection;
using System.Runtime.CompilerServices;
using PHP.Core;

[assembly: AssemblyTitle("Phalanger MsSql")]
[assembly: AssemblyDescription("Phalanger Managed Extension - MsSql")]

[assembly: PhpLibrary(typeof(PHP.Library.Data.MsSqlLibraryDescriptor), "MsSql", new string[]{"mssql"})]
