
public class LoggerInstance
{
    public static LoggerInstance instance;  // creating a static instance of the same class to return to caller 
    
    /* in Singletoo desingpattern we dont want to allow caller to create multiple objects of the same class, 
    so we are decorating constructor as private, the private method can be called only with in the class
    Usage : Use this pattern when we want to have only one object of the class : Drivers, Registry setting modules,logging*/
    private LoggerInstance()  
    {

    }

    /* we are valdiate there exist only only one static instance of the class object, creating a new object if memory is not allcoated by an calller, if any caller allcoated memory to this object,
     we will return the same object to the current caller so that we can gurentee single object of the class
      In this exmaple we are using get method */
    public static LoggerInstance Instance
    {
        get
        {
            if (instance == null)
            {
                 instance =new LoggerInstance();
            }
            return instance;

        }
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