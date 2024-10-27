using System;
namespace OOP_HW_02
{
            class vehicle { public string brand; }
        class motorvehicl : vehicle { public string modelname; }
        class car : motorvehicl
        {
            public string carbrand(string brand)
            {
                brand = "BMW";
                return brand;
            }
            public string carmodel(string model)
            {
                model = "C500";
                return model;
            }

        }
        class truck : motorvehicl
        {
            public string truckbrand(string brand)
            {
                brand = "Ford";
                return brand;
            }
            public string truckmodel(string model)
            {
                model = "F-650";
                return model;
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                car MaCar = new car();
                truck MaCar2 = new truck();
                Console.WriteLine("my car's brand is : " + MaCar.carbrand(""));
                Console.WriteLine(" my car's model is :" + MaCar.carmodel(""));
                Console.WriteLine("my truck's brand is : " + MaCar2.truckbrand(""));
                Console.WriteLine(" my truck's model is: " + MaCar2.truckmodel(""));
            }
        }
    }
