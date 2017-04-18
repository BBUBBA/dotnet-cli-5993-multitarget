using System;
using ClassLibrary1;

namespace ConsoleApp1
{
	using System.IO;
	using System.Threading.Tasks;

	class Program
	{
		static void Main() => F().Wait();

		static async Task F()
		{
			await new AsyncService().SomethingAsync();
		}
	}
}