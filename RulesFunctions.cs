using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    public static class RulesFunctions
    {
        public static List<IRule> rules = new();


        public static void CheckAllRules(string mystring, List<IRule> rules)
        {
            if (rules.Count == 0)
            {
                Console.WriteLine("\nNo rules to check!! \nExiting...");
                return;
            }
            Console.WriteLine("\nChecking Rules...");
            foreach (IRule rule in rules)
            {
                Console.WriteLine(rule.CheckRule(mystring));
            }
        }


        public static int? CheckValidInt(string Value)
        {
            bool res;
            res = int.TryParse(Value, out int TheInt);

            if (res)
            {

                return TheInt;
            }
            else
            {
                Console.WriteLine("Invalid Rule!!");
                return null;
            }
        }


        public static List<int> CheckValidIntList(List<string> Value)
        {
            bool res;
            int TheInt;
            List<int> TheIntList = new();

            foreach (var item in Value)
            {
                res = int.TryParse(item, out TheInt);
                if (res)
                {

                    TheIntList.Add(TheInt);
                }
                else
                {
                    Console.WriteLine("Invalid Rule!!");
                    return null;
                }
            }
            return TheIntList;
        }




        public static void AddRule(program.RuleType ruleType, string Value)
        {

            switch ((int)ruleType)
            {
                case 0:
                    Console.WriteLine("con");
                    ContainsRule ContainsRule = new()
                    {
                        Value = Value
                    };
                    rules.Add(ContainsRule);
                    break;
                case 1:
                    Console.WriteLine("atart");
                    StartsWithRule StartsWithRule = new()
                    {
                        Value = Value
                    };
                    rules.Add(StartsWithRule);
                    break;
                case 2:
                    EndsWithRule EndsWithRule = new()
                    {
                        Value = Value
                    };
                    rules.Add(EndsWithRule);
                    break;
                case 3:
                    int? res = CheckValidInt(Value);
                    if (res != null)
                    {
                        LengthRule LengthRule = new()
                        {
                            Value = (int)res
                        };
                        rules.Add(LengthRule);
                    }
                    break;

                case 4:
                    res = CheckValidInt(Value);
                    if (res != null)
                    {
                        LengthGreaterThanRule LengthGreaterThanRule = new()
                        {
                            Value = (int)res
                        };
                        rules.Add(LengthGreaterThanRule);
                    }
                    break;

                case 5:
                    res = CheckValidInt(Value);
                    if (res != null)
                    {
                        LengthSmallerThanRule LengthSmallerThanRule = new()
                        {
                            Value = (int)res
                        };
                        rules.Add(LengthSmallerThanRule);
                    }
                    break;
                case 6:
                    any_ContainsRule any_ContainsRule = new()
                    {
                        Value = Value.Split(" ").ToList()
            };
                    rules.Add(any_ContainsRule);
                    break;
                case 7:
                    any_StartsWithRule any_StartsWithRule = new()
                    {
                        Value = Value.Split(" ").ToList()
                    };
                    rules.Add(any_StartsWithRule);
                    break;

                case 8:
                    any_EndsWithRule any_EndsWithRule = new()
                    {
                        Value = Value.Split(" ").ToList()
                    };
                    rules.Add(any_EndsWithRule);
                    break;

                case 9:
                    List<int>? IntList = CheckValidIntList(Value.Split(" ").ToList());
                    if (IntList != null)
                    {
                        any_LengthRule any_LengthRule = new()
                        {
                            Value = (List<int>)IntList
                        };
                        rules.Add(any_LengthRule);
                    }
                    break;

                case 10:
                    IntList = CheckValidIntList(Value.Split(" ").ToList());
                    if (IntList != null)
                    {
                        any_LengthGreaterThanRule any_LengthGreaterThanRule = new()
                        {
                            Value = (List<int>)IntList
                        };
                        rules.Add(any_LengthGreaterThanRule);
                    }
                    break;

                case 11:
                    IntList = CheckValidIntList(Value.Split(" ").ToList());
                    if (IntList != null)
                    {
                        any_LengthSmallerThanRule any_LengthSmallerThanRule = new()
                        {
                            Value = (List<int>)IntList
                        };
                        rules.Add(any_LengthSmallerThanRule);
                    }
                    break;
            }
        }

    
       
    }
}
