// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace V8Test
{
	public class SystemConsole
	{
		public SystemConsole() { }

		public void Print(string iString)
		{
			Console.WriteLine(iString);
		}
	}
}
