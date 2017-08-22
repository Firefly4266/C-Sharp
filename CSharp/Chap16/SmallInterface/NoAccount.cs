// NoAccount.cs

public class NoAccount
{
   private decimal balance;
	public NoAccount(decimal balance) 
	{
		this.balance = balance;
	}
	public void Deposit(decimal amount)
	{
		balance += amount;
	}
	public void Withdraw(decimal amount)
	{
		balance -= amount;
	}
	public decimal Balance
	{
		get
		{
			return balance;
		}
	}
}