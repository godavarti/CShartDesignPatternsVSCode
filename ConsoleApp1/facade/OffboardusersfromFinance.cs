public class OffboardusersfromFinance
{
    string userno;
    public OffboardusersfromFinance(string uno)
    {
           userno=uno;

    }
    
   public void dropuserfinance()
   {
    Console.WriteLine("user " + userno.ToString() + "  Bank  deails are removed ");
   }

}