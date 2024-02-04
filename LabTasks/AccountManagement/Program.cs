namespace AccountManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(1);
            a1.setAccName("Wasik's Account");
            a1.Deposit(5000);
            a1.ShowDetail();

            Account a2 = new Account(2, "Other Account", 1000);
            a2.ShowDetail();
            a2.Transfer(500, a1);
            
            a2.ShowDetail();
            a1.ShowDetail();
        }
    }
}