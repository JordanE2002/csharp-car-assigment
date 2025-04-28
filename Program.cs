using System;  

namespace carAssigment 
{
    class Program 
    {
        //Made a car cass to store the car's details 
        public class Car
        {
        
            public string make;   
            public string model;   
            public string reg;     
            public int year;       
            public int value;     

            //Constructor use car object with specific info
            public Car(string carMake, string carModel, string registration, int yearOfReg, int currentValue)
            {
                make = carMake;        
                model = carModel;      
                reg = registration;   
                year = yearOfReg;       
                value = currentValue;  
            }

            //Get value for car
            public int GetCurrentValue()
            {
                return value;
            }

            // Get car year
            public int GetYear()
            {
                return year;
            }

            // Using override to show all details 
            public override string ToString()
            {
                return $"Make: {make}, Model: {model}, Reg: {reg}, Year: {year}, Value: ${value}";
            }
        }

        // Made a test class for the car class
        public class CarTest
        {
     
            public static void RunTest()
            {
                
                Car testCar = new Car("BMW", "BMWPOW", "AKGT089", 2008, 5000);

                Console.WriteLine(testCar);
            }
        }

        //The main method 
        static void Main(string[] args)
        {
          
            CarTest.RunTest();
        }
    }
}
