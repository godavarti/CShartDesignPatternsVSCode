public class OffboarduserfromTeamResoruces
{
    string userno;
    public OffboarduserfromTeamResoruces(string uno)
    {
           userno=uno;

    }
    
   public void dropuserTeam()
   {
    Console.WriteLine("user " + userno.ToString() + "  team  deails are removed ");
   }

}