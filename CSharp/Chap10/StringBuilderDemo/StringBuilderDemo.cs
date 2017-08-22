// StringBuilderDemo.cs

using System;
using System.Text;

public class StringBuilderDemo
{
	public static void Main(string[] args)
	{
		StringBuilder build = new StringBuilder();
		Console.WriteLine("capacity = {0}", build.Capacity);
		build.Append("This is the first sentence.\n");
		Console.WriteLine("capacity = {0}", build.Capacity);
		build.Append("This is the second sentence.\n");
		Console.WriteLine("capacity = {0}", build.Capacity);
		build.Append("This is the last sentence.\n");
		Console.WriteLine("capacity = {0}", build.Capacity);
		string str = build.ToString();
		Console.Write(str);
	}
}
