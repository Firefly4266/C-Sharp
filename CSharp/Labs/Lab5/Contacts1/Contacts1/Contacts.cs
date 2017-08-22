using System;

//Creating a contact list

public class Contacts
{
    public static void Main()
    {
        string[] names = new string[10];
        int count = 0;
        //string target;
        names [count++] = "Mike";
        names[count++] = "Pete";
        names[count++] = "Sally";

        Console.WriteLine(names.Length);
        //instantiate InputWrapper object
        InputWrapper iw = new InputWrapper();
        //use getString method to prompt for command
        String cmd = iw.getString("> ");
        Console.WriteLine(cmd);
        while (cmd != "quit")
        {
            switch (cmd)
            {
                case "add":
                    string name = iw.getString("names: ");
                    names[count++] = name;
                    Console.WriteLine(name);
                    break;
                case "forward":
                    for (int i = 0; i < names.Length; i++)
                    Console.WriteLine(names[i]);
                    break;
                case "backward":
                    Array.Reverse(names);
                        //Console.WriteLine("Backward");
                        PrintIndexAndValues(names);
                    break;
                case "find":
                    int j = 0;
                    string target = iw.getString("Search: ");
                    while (target != names[j])
                        {
                        break;
                        }
                    Console.WriteLine(names[j]);
                    break;
                case "remove":
                    Console.WriteLine("Remove");
                    break;
                default:
                    Console.WriteLine("Available commands include: forward, backward, add, find, remove");
                    break;
            }
            cmd = iw.getString("> ");
        }
    }

    public static void PrintIndexAndValues(Array names)
    {
        for (int i = names.GetLowerBound(0); i <= names.GetUpperBound(0); i++)
            Console.WriteLine("    [{0}]:    {1}", i, names.GetValue(i));
    }

}