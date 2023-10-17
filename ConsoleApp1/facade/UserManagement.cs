//user management involvevs in serveral activitie 
//Scenario : to onbaord a new user to your busienss you need to add user persnal detailn in your HR System, to process the payments you need to add user to Fianance System and to assing user to a consultint team you have to provision access to user on Team resoruce 
//when user decided to cut the relation with your busienss, you have to remove user from HR, Finance and Team resources 
//for a developper building logic on user adding and user removing , we can abstrac the detals of other systems to make the dev life easy 
//for a developer building HR system functionality, no need to know more on Finance, Team or USer manageent 
//To add addiotnal steps in onboarding , lets teake new step is legal, the developper in leagal team develp leagal mangagement, usermanagement module developer just use the methods in archestration

public class usermanagement
{
    private OffboarduserfromHRrecords ofhr;
    private OffboarduserfromTeamResoruces oftr;
    private OffboardusersfromFinance offr;
    private OnboardusertoFinance onf;
    private OnboardusertoHRrecords onhr;
    private OnboardusertoTeamResources ontr;

    public usermanagement(string bno, int ssno,string tname )
    {
       
        onf= new OnboardusertoFinance(bno);
        onhr = new OnboardusertoHRrecords(ssno);
        ontr = new OnboardusertoTeamResources(tname);
    }

    public void offboarduser(string uno)
    {
         ofhr= new OffboarduserfromHRrecords(uno);
        oftr =new OffboarduserfromTeamResoruces(uno);
        offr = new OffboardusersfromFinance(uno);

       oftr.dropuserTeam();
       ofhr.dropuserHR();
       offr.dropuserfinance();

    }

    public void onbaorduser()
    {
        onhr.ussnosaved();
        onf.ubanksaved();
        ontr.uteamsaved();
    }

}