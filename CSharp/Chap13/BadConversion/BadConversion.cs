// BadConversion.cs

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc = new Account(); 
 		CheckingAccount chk = new CheckingAccount();
		acc.Show();
		chk.Show();
		chk = (CheckingAccount) acc;		// explicit cast
		decimal charge = chk.fee;			// this is bad
	}
}