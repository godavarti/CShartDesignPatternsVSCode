/*Template Method is a behavioral design pattern that allows you to defines a skeleton of an algorithm in a base class and let subclasses override the steps without changing the overall algorithm's structure.
                  It's fairly easy to create concrete implementations of an algorithm because you're removing common parts of the problem domain by the use of an abstract class. Clean code because you avoid duplicate code.
                  The main feature of this pattern is an algorithm which changes slightly between different kinds of classes. These parts commonly are repeated in the different algorithms when implemented in a concrete class.
                  Finally, you may use this pattern when most of your classes have related behaviors.
    */

//This is an abstract class to define the template methods : common to differnt cloud providers



public abstract class  CloudResoruceManagement
    {
        public void createResource()
        {
           Console.WriteLine (" I am common for both AWS And Azure , so I am inherited from CloudResoruceManagement");
        }

        public abstract void  scaleupresoruces(); //Implementation fro Azure and AWS are diferrent
        public abstract void  scaledownresource();  //Implementation fro Azure and AWS are diferrent

    }