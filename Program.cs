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
            //new test
          
            string? operation;
            string? Value;

            List<string> operations = new List<string>();
            operations.Add("1");
            operations.Add("2");
            operations.Add("3");
            operations.Add("4");
            operations.Add("5");
            operations.Add("6");
            operations.Add("7");
            operations.Add("8");
            operations.Add("9");
            operations.Add("10");
            operations.Add("11");
            operations.Add("12");

            Console.WriteLine("Type a string to check:");
            string? mystring = Console.ReadLine();

            while (true)
            {
                operation = program.getOperation(operations);
                if (operation == null)
                {
                    Console.WriteLine("\nAdd nother Rule? y/n");
                    if (Console.ReadLine() == "n")
                    {
                        break;
                    }
                    continue;
                }
                Console.WriteLine("\nType value:");
                Value = Console.ReadLine();
                RulesFunctions.AddRule(operation, Value);
                Console.WriteLine("\nAdd nother Rule? y/n");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
            }

            if (RulesFunctions.rules.Count == 0)
            {
                Console.WriteLine("\nNo rules to check!! \nExiting...");
                return;
            }

            
            RulesFunctions.CheckAllRules(mystring, RulesFunctions.rules);

    
        
        }

        static string getOperation(List<string> operations)
        {
            string? operation = null;
            Console.WriteLine("\n\nChoose Operation:" +
                    "\n1 - Contains" +
                    "\n2 - StartsWith" +
                    "\n3 - EndsWith" +
                    "\n4 - Length" +
                    "\n5 - LengthGreaterThan" +
                    "\n6 - LengthSmallerThan" +
                    "\n7 - any_Contains" +
                    "\n8 - any_StartsWith" +
                    "\n9 - any_EndsWith" +
                    "\n10 - any_Length" +
                    "\n11 - any_LengthGreaterThan" +
                    "\n12 - any_LengthSmallerThan" +
                    "\n\nMy Choice:");
            operation = Console.ReadLine();
            if (!operations.Contains(operation))
            {
                Console.WriteLine("\nInvalid Operation!!\n");
                return null;
            }
            else
            {
                return operation;
            }
        }
        

    }
            




}
            
            

