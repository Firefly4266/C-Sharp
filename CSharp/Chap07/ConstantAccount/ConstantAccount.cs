// ConstantAccount.cs

using System;

public class ConstantAccount
{
	public static void Main(string[] args)
	{
		Console.WriteLine("FEE = {0}", Account.FEE);
		// Account.FEE = 7.00m;		// illegal
		Account acc = new Account(10);
		Console.WriteLine("{0} free checks", acc.FreeChecks);
		// acc.FreeChecks = 20;		// illegal
	}
}