This project explain design patterns implementations in C# 
This project is created in VSCode 
Structure :- Programs.cs is used to demonstrate differnt design patterns
             One or multiple classess will be created to demonstrate a desing pattern
Singleton :- LoggerSingleton.cs this class demonstrates the singleton desing pattern implementations
             LoggerInstance.cs this calss demonstrates the singleton desing pattern implementations with get method ,C# recommended way.
Factory  :- Isolate object creation in a solution to a specific class    
            To demonstrate Factory pattern, we take a scenario of invoice payment processing based on customer selected payment method          
            IPayment.cs , it has an interface all payment methods like ApplePay, SamsungPay,Paypall, PayTM, CachPay implements this interface 
            ChasPayment.cs, SamsungPayment.cs,ApplePayment.cs,ChasPayment.cs,Paypallpayment.cs,PayTMPayment.cs are implementations of Ipayment interface 
            PaymentFatory.cs creates an implementation object based on customer payment method selection 
Template Method : CloudResoruceManagement.cs is an abstract class used to implement tempale methods:  scaleup and scaledown and defined the common code for both cloud providers that is create resoruce method.
                 AWSResoruceManagement.cs is implementation class for AWS Cloud resoruces 
                 AzureResoruceManagement.cs is implementation class for Azure Cloud resoruces