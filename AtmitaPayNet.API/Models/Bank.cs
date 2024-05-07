namespace AtmitaPayNet.API.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        //List of the Bank Accounts
        public List<BankAccount> BankAccounts { get; set; }

    }
}
