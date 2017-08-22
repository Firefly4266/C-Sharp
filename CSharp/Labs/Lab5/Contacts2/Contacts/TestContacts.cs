using System;

//Creating contact application

public class TestContacts
{
    public static void Main(String[] args)
    {
        string[] names = new string[10];
        int count = 0;
        names[count++] = "John";
        names[count++] = "Jane";
        names[count++] = "Todd";

        string cmd = " ";
        while (cmd != "quit")
        {
            InputWrapper iw = new InputWrapper();
            Console.WriteLine("Enter command, quit to exit.");
            cmd = iw.getString("> ");
            Console.WriteLine("the command {0} was entered", cmd);

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
                    Console.WriteLine("Backward");
                    PrintIndexAndValues(names);
                    break;
                //    case "find":
                //        int j = 0;
                //        string target = iw.getString("Search: ");
                //        while (target != names[j])
                //        {
                //            break;
                //        }
                //        Console.WriteLine(names[j]);
                //        break;
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