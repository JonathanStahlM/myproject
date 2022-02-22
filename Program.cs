
using System;


namespace first_project
{
    public class program
    {

        static void Main()
        {
            string? mystring = GetStringFromUser();
            GetRulesFromUser();
            RulesFunctions.CheckAllRules(mystring, RulesFunctions.rules);
        }

        public static string GetStringFromUser()
        {
            Console.WriteLine("Type a string to check:");
            return Console.ReadLine();
        }
        

        public static RuleType? GetRuleType()
        {
            PrintAllRuleTypeOptions();
            return ChooseRuleType();
        }


        public static void PrintAllRuleTypeOptions()
        {
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
                    "\n12 - any_LengthSmallerThan");
        }

        public enum RuleType
        {
            Contains,
            StartsWith,
            EndsWith,
            Length,
            LengthGreaterThan,
            LengthSmallerThan,
            any_Contains,
            any_StartsWith,
            any_EndsWith,
            any_Length,
            any_LengthGreaterThan,
            any_LengthSmallerThan
        }

        public static RuleType? ChooseRuleType()
        {
            Console.WriteLine("\n\nMy Choice:");
            string? ruleType = Console.ReadLine();
            switch (ruleType)
            {
                case "1":
                    return RuleType.Contains;
                case "2":
                    return RuleType.StartsWith;
                case "3":
                    return RuleType.EndsWith;
                case "4":
                    return RuleType.Length;
                case "5":
                    return RuleType.LengthGreaterThan;
                case "6":
                    return RuleType.LengthSmallerThan;
                case "7":
                    return RuleType.any_Contains;
                case "8":
                    return RuleType.any_StartsWith;
                case "9":
                    return RuleType.any_EndsWith;
                case "10":
                    return RuleType.any_Length;
                case "11":
                    return RuleType.any_LengthGreaterThan;
                case "12":
                    return RuleType.any_LengthSmallerThan;
            }
            Console.WriteLine("\nInvalid Rule Type!!\n");
            return null;
        }

        public static void GetRulesFromUser()
        {
            RuleType? ruleType;
            string Value;
            while (true)
            {
                ruleType = GetRuleType();
                if (ruleType == null)
                {
                    Console.WriteLine("\nAdd nother Rule? y/n");
                    if (Console.ReadLine() == "n")
                    {
                        break;
                    }
                    continue;
                }
                ;
                Value = GetValueFromUser();
                RulesFunctions.AddRule((RuleType)ruleType, Value);

                Console.WriteLine("\nAdd nother Rule? y/n");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
            }
        }

        public static string GetValueFromUser()
        {
            Console.WriteLine("\nType value:");
            return Console.ReadLine();
        }



    }
            




}
            
            

