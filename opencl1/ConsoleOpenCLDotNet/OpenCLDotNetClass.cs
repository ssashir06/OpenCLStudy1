using System;
using OpenCL.Net;

namespace ConsoleOpenCLDotNet
{
	public class OpenCLDotNetClass
	{
		public OpenCLDotNetClass ()
		{
		}

		public void Init()
		{
			ErrorCode err;
			var ids = Cl.GetPlatformIDs(out err);
			foreach (var id in ids) {
				Console.WriteLine ("Platform id: {0}", id.ToString());
			}
		}
	}
}

