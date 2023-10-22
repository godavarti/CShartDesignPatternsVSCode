//Factory Pattern 
//This pattren can be used in several solutions, few of the best solution is giving more alternative options to customer 
//Example : let say, a departmental store started online payment solution, initially integrated with paypall, over time customers, started using GooglePay, PayTM, Samsung Pay, ApplePay.
// Departmental store have kiosk, this kiosk reads the type of pay and send data to payment processor , now payment processor call the corresponding payment system based on the input 
//In this file, we are creating Ipayment interface , all implemenations of payment methods implemnets this interface 

public interface Ipayment 
{
    public int Payment(double amount);
    
}
