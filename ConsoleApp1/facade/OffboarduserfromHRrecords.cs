public class OffboarduserfromHRrecords
{
    string userno;
    public OffboarduserfromHRrecords(string uno)
    {
           userno=uno;

    }
    
   public void dropuserHR()
   {
    Console.WriteLine("user " + userno.ToString() + "  HR  deails are removed ");
   }

}