// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
Console.WriteLine("Hello, World!");
//Singleton design patterns demonstration 
Loggersingleton log= Loggersingleton.GetLoggersingleton(); 
log.printmessage(" I am logging for you GVS");
LoggerInstance logI = LoggerInstance.Instance;
 logI.printmessage(" I am fromm LoggerIsntance ");
 }
}
