// ArrayName.cs - Step 0

using System;

public class Name
{
	private string text;
	public Name(string text)
	{
		this.text = text;
	}
	public string Text
	{
		get
		{
			return text;
		}
	}
}
public class ArrayName
{
	public static int Main(string[] args)
	{
		Name[] array = new Name[10];
		array[0] = new Name("Michael");
		array[1] = new Name("Charlie");
		array[2] = new Name("Peter");
		array[3] = new Name("Dana");
		array[4] = new Name("Bob");
		Array.Sort(array);
		return 0;
	}
}
