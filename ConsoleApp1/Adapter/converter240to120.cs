/* Adatper pattern is used to use the legacy code in modren projects or obstract legacy code from moderen code 
  In this example, an employee working in USA went to India, devices developped in USA supports only 12O W, Power supply in India is 240 W
  The employee need an adapter in India to use devices developped in USA, the adapter converts 240 W to 120 W with out converting the powersupply system in India to 120W
  This class is used by adaoters
  */ 

public class Converter240to120 : Ipower120
{
    private Power240 _Power240; 
     public  Converter240to120(Power240 P)   // it takes 240 w power from India socket 
     {
        _Power240 = P;
       
     }
     public void about()
     {
        Console.WriteLine (" I am from Converter240to120");
     }
     public void consumpower120(int w)  // this implemntation converst the 240 w to 120 w to save the USA devices from power flutuations
     {
        _Power240.consumpower240(240);
        Console.WriteLine ( " I am from Converter240to120,  I  consumed 240 W,  converted to 120 w to use Device manufactured in USA with 120w capacity in India");
     }


}