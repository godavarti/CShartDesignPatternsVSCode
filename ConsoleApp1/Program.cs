// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {


////Singleton Tester --Start
//Singleton design patterns demonstration 
Console.WriteLine ("Singleton Pattern Output Starts Here");
Loggersingleton log= Loggersingleton.GetLoggersingleton(); 
log.printmessage(" I am logging for you GVS");
//How to prove, that singleton will create only one object , GetHashCode() method for log1 and log2 reference returns the same value

Loggersingleton log1= Loggersingleton.GetLoggersingleton(); 
log.printmessage(" I am logging for you GVS_"+ log1.GetHashCode().ToString());
Loggersingleton log2= Loggersingleton.GetLoggersingleton(); 
log.printmessage(" I am logging for you GVS_"+ log1.GetHashCode().ToString());

LoggerInstance logI = LoggerInstance.Instance;
 logI.printmessage(" I am fromm LoggerIsntance");

 ////Singleton Tester --end 
 
 ////Factory  Tester --Start

Console.WriteLine ("Factory Pattern Output Starts Here");
Ipayment payobject = null; //We dont know what payment method customer uses , so we created Ipayment Interface refernce to capature the object of Payment based on customer Input
PaymentFactory PF = new PaymentFactory("apple");   //Customer has apple payment mehtod 
payobject =PF.payobject;   //ApplePayment object is created by factory based on customer input 
double inoviceamount =0;  //Payment method takes invoic e amount as input
bool result = double.TryParse("72",out inoviceamount);  // Inovice amount is converted from input to double 
if (result)
payobject.Payment(inoviceamount);   //Ipayment Intrface has ApplePayment object hence, it invokes Payment method in ApplePayment object 
else
Console.WriteLine(" Invalid output");
}
}
