public class PaymentFactory
{
public Ipayment payobject;
public  PaymentFactory(string paytype)
{
    if (paytype == "samsung")
       {
        payobject = new SamsungPayment();
       }
       else if (paytype == "apple")
       {
        payobject = new ApplePayment();
       }
      else if (paytype == "paypall")
       {
        payobject = new PaypallPayment();
       }
      else if (paytype == "paytm")
       {
        payobject = new PayTMPayment();
       }
      else payobject = new CashPayment();

}



}