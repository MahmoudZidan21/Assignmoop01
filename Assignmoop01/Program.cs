namespace Assignmoop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct

            // Struct : Value Type : Stack

            // Employee 
            // id , name , salary 


            // Point 

            //  Point Po1;
            // Declare For Object from ' Type ' "Point"
            // Po1 'Object '
            // Allocte Un Intialize 8 Bytes At Stack


            //Console.WriteLine(Po1.X);
            //Console.WriteLine(Po1.Y);

            //Po1.X = 12;
            //Po1.Y = 12;

            //Console.WriteLine(Po1.X);
            //Console.WriteLine(Po1.Y);

            //  Po1 = new Point(1, 2);
            // 

            //Console.WriteLine(Po1.X);
            //Console.WriteLine(Po1.Y);

            //Po1.PrintPoint();
            // Console.WriteLine(Po1.ToString);

            // Console.WriteLine(Po1.ToString());

            #endregion

            #region OOP
            // OOP : object Oriented Programming
            // Programing Paradiang
            // OOP : The Paradiang Use for Build any Business

            // Class : Blueprint of the object
            // Object : Specific Instance from Class 

            // 4 Pillars
            // 1. Encapsulation
            // 2. inheritance 
            // 3. Ploymorphism 
            // 4. Abstraction 
            #endregion

            #region Encapsulation
            // Encapsulation
            // Class OR Struct 
            // Seperate THe Data (Attributes) Definition From Its Use

            // Employee E01 = new Employee();


            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine( E01.salary);

            //E01.SetId(1);
            //E01.SetName("A");
            //E01.SetSalary(12000);


            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName()); 
            //Console.WriteLine(E01.GetSalary())
            //    ;

            #endregion

             Employee E01 = new Employee();

            E01.Id = 12;
            E01.Name = "ahmed";
            E01.Salary = 12000;



            Console.WriteLine(E01.Id);

        }
    }
 }
