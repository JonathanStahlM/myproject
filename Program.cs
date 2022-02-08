// understanding the op
//checking it on the string
//returning true or false


using System;


namespace first_project
{
    public class program
    {

        

        static void Main()
        {
            

            string? mystring = "abcd";



            string? operation = "Length";
            string? Value = "4";
            RulesFunctions.AddRule(operation, Value);

       

            operation = "Contains";
            Value = "m";
            RulesFunctions.AddRule(operation, Value);

         

            /*
            bool flag = false;
            while (flag == false)
            {
                string? mystring = Console.ReadLine();
                string? operation = Console.ReadLine();
                string? Value = Console.ReadLine();
            }

            */

           

            operation = "any_LengthGreaterThan";
            List<string> Value2 = new List<string>();
            Value2.Add("e");
            Value2.Add("5");
            RulesFunctions.AddRule(operation, Value2);
           

            operation = "any_Contains";
            List<String> Value1 = new List<string>();
            Value1.Add("g");
            Value1.Add("a");
            RulesFunctions.AddRule(operation, Value1);


            RulesFunctions.CheckAllRules(mystring, RulesFunctions.rules);
    
        
        }


        

    }
            




}
            
            

