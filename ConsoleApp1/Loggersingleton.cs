
public class Loggersingleton
{
    public static Loggersingleton logger;  // creating a static instance of the same class to return to caller 
    
    /* in Singletoo desingpattern we dont want to allow caller to create multiple objects of the same class, 
    so we are decorating constructor as private, the private method can be called only with in the class*/
    private Loggersingleton()  
    {

    }

    /* we are valdiate the the only static instance of the class object, creating a new object if memory is not allcoated by an calller, if any caller allcoated memory to this object,
     we will return the same object to the current caller so that we can gurentee single object of the class*/
    public static Loggersingleton GetLoggersingleton() 
    
    {
        if(logger==null)
        {
            logger = new Loggersingleton();
           
        }
        return logger;
    }

    public  void printmessage(string s)
    {
        if(s!= null)
         {
            Console.WriteLine(" I am from logger");
            Console.WriteLine(s);
         }
         else{
            Console.WriteLine(" I dont have any messages");
         }
    }
}