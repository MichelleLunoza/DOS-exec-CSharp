/*
 * Created by SharpDevelop.
 * User: MichelleLunoza
 * Date: 12/12/2016
 * Time: 8:12 PM
 * 
 */
using System;
using System.Diagnostics;
namespace VRemover
{
	class Program
	{
		public static void Main(string[] args)
		{
			Process cmd = new Process();
			cmd.StartInfo.FileName = "cmd.exe";
			cmd.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.CreateNoWindow = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();
			
			//This is the Part to exwecute DOS commands . . . . :)
			cmd.StandardInput.WriteLine("start notepad");
			cmd.StandardInput.WriteLine("start calc");
			cmd.StandardInput.WriteLine("start chrome");
			
			
			//cmd.StandardInput.Flush();
			//cmd.StandardInput.Close();
			//cmd.WaitForExit();
			//Console.WriteLine(cmd.StandardOutput.ReadToEnd());
			//Console.Write("Press any key to continue . . . ");
			//Console.ReadKey(true);
		}
	}
}