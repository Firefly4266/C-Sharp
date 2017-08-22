// MortgagePayment.cs
//
// Interactive program to compute a mortgage payment

using System;

public class MortgagePayment
{
	public static int Main(string[] args)
	{
		InputWrapper iw = new InputWrapper();
		decimal amount = iw.getDecimal("Amount of loan: ");  // amount of loan
		double rate = iw.getDouble("Interest rate");     // interest rate
		int months = iw.getInt("Number of periods");      // number of periods
                                                          // Prompt for amount of loan, interest rate, and months
                                                          // Calculate monthly payment using payment() method
                                                          // Display this payment
        decimal monthlyPayment = payment(amount, rate, months);
        Console.WriteLine("Your monthly payment is {0}", monthlyPayment);
		return 0;
	}
	/***************************************************************/
	/* payment -- calculate the payment on a loan                  */
	/* formula:                                                    */
	/*                                      -months                */
	/*        r = amount /((1 - (1+interest)        ) / interest)  */
	/***************************************************************/
	static decimal payment(decimal amount, double interest, int months)
	{
        decimal r = amount;
        double divisor = 1 + interest;
        divisor = Math.Pow(divisor, -months);
        divisor = 1 - divisor;
        divisor = divisor / interest;
        r = r / (decimal)divisor;
        return r;
	}
}