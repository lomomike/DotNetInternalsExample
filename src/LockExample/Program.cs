using System;
using System.Diagnostics;

namespace LockExample
{
	public class Program
	{
		private static readonly Locker LockObject = new Locker();

		public static void Main(string[] args)
		{
			Console.WriteLine("Example of lock (Monitor)");
			Console.WriteLine($"ProcessId = {Process.GetCurrentProcess().Id}, {ProcessorArchticture()}\n");

			var hash = LockObject.GetHashCode();
			Console.WriteLine($"LockObject hash code {hash:X}");

			Console.WriteLine("Press any key to acquire lock");
			Console.ReadLine();

			lock (LockObject)
			{
				Console.WriteLine("Press any key to release lock");
				Console.ReadLine();
			}
			
			
			Console.WriteLine("Press any key to exit");
			Console.ReadLine();
		}

		private static string ProcessorArchticture()
		{
			return IntPtr.Size == 8 ? "x64" : "x86";
		}
	}

	class Locker { }
}
