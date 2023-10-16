public  class  AzureResoruceManagement : CloudResoruceManagement
    {
       

        public override  void  scaleupresoruces()
        {
             Console.WriteLine ( " I am Scaling up Azure Resource");
        }
    public override void scaledownresource()
        {
             
             Console.WriteLine ( " I am Scaling down  Azure Resource");
       
        }
    }

   