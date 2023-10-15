// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
Console.WriteLine("Hello, World!");
//Singleton design patterns demonstration 
Loggersingleton log= Loggersingleton.GetLoggersingleton(); 
log.printmessage(" I am logging for you GVS");
//How to prove, that singleton will create only one object , GetHashCode() method for log1 and log2 reference returns the same value

Loggersingleton log1= Loggersingleton.GetLoggersingleton(); 
log.printmessage(" I am logging for you GVS_"+ log1.GetHashCode().ToString());
Loggersingleton log2= Loggersingleton.GetLoggersingleton(); 
log.printmessage(" I am logging for you GVS_"+ log1.GetHashCode().ToString());

LoggerInstance logI = LoggerInstance.Instance;
 logI.printmessage(" I am fromm LoggerIsntance");
 }
}
