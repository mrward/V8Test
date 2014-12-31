// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using V8.Net;

namespace V8Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			var program = new Program();
			program.Run();
			
			Console.Write("Press any key to continue...");
			Console.ReadKey(true);
		}
		
		void Run()
		{
			using (var engine = new V8Engine()) {
				
				// Return value from JavaScript.
				using (Handle result = engine.Execute("var i = 10; i;", "V8.NET", true)) {
					Console.WriteLine(result.AsString);
				}
				
				engine.RegisterType(typeof(SystemConsole), null, true, ScriptMemberSecurity.Locked);
				engine.GlobalObject.SetProperty("console", new SystemConsole());
				using (Handle handle = engine.Execute("console.Print('foo');", "V8.NET", true)) {
					
				}
			}
		}
	}
}