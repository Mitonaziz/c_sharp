using System;

namespace file1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("number x is " +x);
            x = 5;
            Console.WriteLine("Number x is " + x);
            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;
            Console.WriteLine("Doble_num is "+double_num+" float_num is "+float_num+" decimal_num is "+decimal_num);
            string first_name = "Azizur";
            string last_name = "Rahman";
            Console.WriteLine("My first Name is " + first_name + " Last name is " +last_name);


            //casting and type conversion
            int num = 20;
            string account_num = "";
            account_num = num.ToString();//convert number to string

            Console.WriteLine(account_num);

            float num2 = 3.5f;

            num = Convert.ToInt32(num2);//convert flot to int 
            Console.WriteLine(num);


            //String concatenation
            int age = 21;
            string name = "Azizur";
            Console.WriteLine("Hellow my name is= " + name + "I am " + age + "years old");


            //string formatting uses index
            Console.WriteLine("Hellow my name is {0},I am {1} years old", name, age);

            //upper case,lower case,substring
            string myname;
            Console.WriteLine("Enter your name = ");
            myname = Console.ReadLine();
            string myNameuppercase = string.Format("uppercase :{0} ", myname.ToUpper());

            string myNameLowercase = string.Format("LowerCase : {0}", myname.ToLower());

            string myNameTrimmed = string.Format("The trimmed valu : {0}", myname.Trim());

            string myNamesubstring = string.Format("the substring :{0}", myname.Substring(0, 5));
            Console.WriteLine(myNameuppercase);
            Console.WriteLine(myNameLowercase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNamesubstring);

            //string
            Console.WriteLine("Enter your string =");
            string inpute = Console.ReadLine();

            Console.WriteLine("Ener your char");
            char searchInput = Console.ReadLine()[0];
            int SearchIndex = inpute.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, SearchIndex);


            //concating
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("enter your last name=");
            string lastname = Console.ReadLine();
            string fullName = string.Concat(firstname, " ", lastname);
            Console.WriteLine("Your full name is ={0}", fullName);

            //convert string number to int number sum

            string Istring = "15";
            string secondstring = "45";
            int Num1 = Int32.Parse(Istring);
            int Num2 = Int32.Parse(secondstring);
            int result = Num1 + Num2;
            Console.WriteLine(result);

            Console.ReadKey();


        }
    }
}
