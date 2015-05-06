using System;

namespace ConsoleOpenCLDotNet
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var openclnet = new OpenCLDotNetClass ();
			openclnet.Init ();

			Console.ReadLine ();
		}
	}
}
