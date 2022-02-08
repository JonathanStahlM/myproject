// understanding the op
//checking it on the string
//returning true or false


using System;


namespace first_project
{
    class program
    {



        static void Main()
        {
            List<IRule>? rules = new List<IRule>();

            string? mystring = "abcd";
            string? operation = "Length";
            string? Value = "4";

            IRule? newrule = AddRule(operation, Value);

            rules.Add((IRule)newrule);

            operation = "Contains";
            Value = "m";

            newrule = AddRule(operation, Value);

            rules.Add((IRule)newrule);

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

            newrule = AddRule(operation, Value2);
            if (newrule != null)
            {
                rules.Add((IRule)newrule);
            }
            else
            {
                Console.WriteLine("Error!!");
            }



            operation = "any_Contains";
            List<String> Value1 = new List<string>();
            Value1.Add("g");
            Value1.Add("a");

            newrule = AddRule(operation, Value1);

            

            if (newrule != null)
            {
                rules.Add((IRule)newrule);
            }
            else
            {
                Console.WriteLine("Error!!");
            }

            CheckAllRules(mystring, rules);
    
        
        }


        static void CheckAllRules(string mystring, List<IRule> rules)
        {
            foreach (IRule rule in rules)
            {
                Console.WriteLine(rule.CheckRule(mystring));
            }
        }


        static int? CheckValidInt(string Value)
        {
            bool res;
            int TheInt;
            res = int.TryParse(Value, out TheInt);

            if (res)
            {
                Console.WriteLine("Valid Value");
                return TheInt;
            }
            else
            {
                Console.WriteLine("Invalid Value");
                return null;
            }
        }


        static List<int> CheckValidIntList(List<string> Value)
        {
            bool res;
            int TheInt;
            List<int> TheIntList = new List<int>();

            foreach (var item in Value)
            {
                res = int.TryParse(item, out TheInt);
                if (res)
                {
                    Console.WriteLine("Valid Value");
                    TheIntList.Add(TheInt);
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                    return null;
                }
            }
            return TheIntList; 
        }




        static IRule? AddRule(string operation, string Value)
        {
            
            switch (operation)
            {
                case "Contains":
                    ContainsRule ContainsRule = new ContainsRule()
                    {
                        Value = Value
                    };

                    return ContainsRule;

                case "StartsWith":
                    StartsWithRule StartsWithRule = new StartsWithRule()
                    {
                        Value = Value
                    };
                    return StartsWithRule;

                case "EndsWith":
                    EndsWithRule EndsWithRule = new EndsWithRule()
                    {
                        Value = Value
                    };
                    return EndsWithRule;

                case "Length":
                    int? res = CheckValidInt(Value);
                    if (res != null)
                    {
                        LengthRule LengthRule = new LengthRule()
                        {
                            Value = (int)res
                        };
                        rules.Add((IRule)LengthRule);
                        else
                        {
                            Console.WriteLine("Error!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid value2");
                        return null;
                    }
                    
                case "LengthGreaterThan":
                    res = CheckValidInt(Value);
                    if (res != null)
                    {
                        LengthGreaterThanRule LengthRule = new LengthGreaterThanRule()
                        {
                            Value = (int)res
                        };
                        return LengthRule;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value2");
                        return null;
                    }
                    
                case "LengthSmallerThan":
                    res = CheckValidInt(Value);
                    if (res != null)
                    {
                        LengthSmallerThanRule LengthRule = new LengthSmallerThanRule()
                        {
                            Value = (int)res
                        };
                        return LengthRule;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value2");
                        return null;
                    }


            }
            return null;
        }




        static IRule? AddRule(string operation, List<string> Value)
        {

            switch (operation)
            {
                case "any_Contains":
                    any_ContainsRule any_ContainsRule = new any_ContainsRule()
                    {
                        Value = Value
                    };
                    return any_ContainsRule;

                case "any_StartsWith":
                    any_StartsWithRule any_StartsWithRule = new any_StartsWithRule()
                    {
                        Value = Value
                    };
                    return any_StartsWithRule;

                case "any_EndsWith":
                    any_EndsWithRule any_EndsWithRule = new any_EndsWithRule()
                    {
                        Value = Value
                    };
                    return any_EndsWithRule;

                case "any_Length":
                    List<int>? res = CheckValidIntList(Value);
                    if (res != null)
                    {
                        any_LengthRule any_LengthRule = new any_LengthRule()
                        {
                            Value = (List<int>)res
                        };
                        return any_LengthRule;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value2");
                        return null;
                    }

                case "any_LengthGreaterThan":
                    res = CheckValidIntList(Value);
                    if (res != null)
                    {
                        any_LengthGreaterThanRule any_LengthGreaterThanRule = new any_LengthGreaterThanRule()
                        {
                            Value = (List<int>)res
                        };
                        return any_LengthGreaterThanRule;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value2");
                        return null;
                    }

                case "LengthSmallerThan":
                    res = CheckValidIntList(Value);
                    if (res != null)
                    {
                        any_LengthSmallerThanRule any_LengthSmallerThanRule = new any_LengthSmallerThanRule()
                        {
                            Value = (List<int>)res
                        };
                        return any_LengthSmallerThanRule;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value2");
                        return null;
                    }


            }
            return null;
        }

    }
            




}
            
            

