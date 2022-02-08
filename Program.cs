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
          
            string? operation;
            string? Value;

            bool flag = false;
            while (flag == false)
            {
                Console.WriteLine("Type Operation:");
                operation = Console.ReadLine();
                Console.WriteLine("Type value:");
                Value = Console.ReadLine();
                if (Value.Contains(" "))
                {
                    List<string> ValueList = Value.Split(" ").ToList();
                    RulesFunctions.AddRule(operation, ValueList);
                }
                else
                {
                    RulesFunctions.AddRule(operation, Value);
                }
                //List<string> ValueList = Value.Split("").ToList();
                //RulesFunctions.AddRule(operation, ValueList);
                Console.WriteLine("Add nother Rule? y/n");
                if (Console.ReadLine() == "n")
                {
                    flag = true;
                }
            }


            Console.WriteLine("Type a string to check:");
            string? mystring = Console.ReadLine();
            RulesFunctions.CheckAllRules(mystring, RulesFunctions.rules);

            /*


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

            */
            
    
        
        }


        

    }
            




}
            
            

