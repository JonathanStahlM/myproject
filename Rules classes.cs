using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    static class Global
    {
        public static int NumberOfRules = 12;
        public static int NumberOfStringRules = 6;
        public static int NumberOfIntRules = 6;
    }

    public abstract class Rule
    {
        //public List<T> Value { get; set; }
        public RuleType ruleType { get; set; }
        public abstract bool CheckRule(string myString);
        public static List<Rule> rules = new();

        /*
        public StringRule CreateRule(RuleType ruleType, List<string> value)
        {
                StringRule rule = new StringRule()
                {
                    ruleType = ruleType,
                    Value = value,
                };
            return rule;
        }
        public StringRule CreateRule(RuleType ruleType, List<string> value)
        {
            IntRule rule = new IntRule()
            {
                ruleType = ruleType,
                Value = value,
            };
            return rule;
        }*/

    }

    public enum RuleType
    {
        Contains,
        StartsWith,
        EndsWith,
        any_Contains,
        any_StartsWith,
        any_EndsWith,
        Length,
        LengthGreaterThan,
        LengthSmallerThan,
        any_Length,
        any_LengthGreaterThan,
        any_LengthSmallerThan
    }

    class IntRule : Rule
    {
        public List<int> Value { get; set; }

        public override bool CheckRule(string myString)
        {
            int myStringLength = myString.Length;
            switch ((int)ruleType)
            {
                case 9 or 3:
                    return any_Length(myStringLength);
                case 10 or 4:
                    return any_LengthGreaterThan(myStringLength);
                case 11 or 5:
                    return any_LengthSmallerThan(myStringLength);
            }
            return false;
            
        }


        public bool any_Length(int myStringLength)
        {
            foreach (var item in Value)
            {
                if (myStringLength == item)
                {
                    return true;
                }
            }
            return false;
        }

        public bool any_LengthGreaterThan(int myStringLength)
        {
            foreach (var item in Value)
            {
                if (myStringLength > item)
                {
                    return true;
                }
            }
            return false;
        }
        public bool any_LengthSmallerThan(int myStringLength)
        {
            foreach (var item in Value)
            {
                if (myStringLength < item)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class StringRule : Rule
    {
        public List<string> Value { get; set; }

        public override bool CheckRule(string myString)
        {
            switch ((int)ruleType)
            {
                case 0 or 6:
                    return any_Contains(myString);
                case 1 or 7:
                    return any_StartsWith(myString);
                case 2 or 8:
                    return any_EndsWith(myString);
            }
            return true;
        }

        public bool any_Contains(string myString)
        {
            foreach (string item in Value)
            {
                if (myString.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool any_StartsWith(string myString)
        {
            foreach (string item in Value)
            {
                if (myString.StartsWith(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool any_EndsWith(string myString)
        {
            foreach (string item in Value)
            {
                if (myString.EndsWith(item))
                {
                    return true;
                }
            }
            return false;
        }

    }



    internal class ContainsRule : IRule
    {
        public string Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            Console.Write("'{0}' Contains '{1}':    ", toCheck, Value);
            if (toCheck.Contains(Value))
            {
                return true;
            }
            return false;
        }


    }







    internal class any_ContainsRule : IRule
    {
        public List<string> Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            string tmp = string.Join(",", Value);
            Console.Write("'{0}' any_Contains one of ({1}):    ", toCheck, tmp);
            foreach (var item in Value)
            {
                if (toCheck.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
    
    internal class StartsWithRule : IRule
    {
        public string Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            Console.Write("'{0}' StartsWith '{1}':    ", toCheck, Value);
            if (toCheck.StartsWith(Value))
            {
                return true;
            }
            return false;
        }
    }

    internal class any_StartsWithRule : IRule
    {
        public List<string>? Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            string tmp = string.Join(", ", Value);
            Console.Write("'{0}' any_StartsWith one of ({1}):    ", toCheck, tmp);
            foreach (var item in Value)
            {
                if (toCheck.StartsWith(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
    internal class EndsWithRule : IRule
    {
        public string Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            Console.Write("'{0}' EndsWith '{1}':    ", toCheck, Value);
            if (toCheck.EndsWith(Value))
            {
                return true;
            }
            return false;
        }
    }


    internal class any_EndsWithRule : IRule
    {
        public List<string>? Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            string tmp = string.Join(", ", Value);
            Console.Write("'{0}' any_EndsWith one of ({1}):    ", toCheck, tmp);
            foreach (var item in Value)
            {
                if (toCheck.EndsWith(item))
                {
                    return true;
                }
            }
            return false;
        }
    }

    internal class LengthRule : IRule
    {
        public int Value { get; set; }

        public bool CheckRule(string toCheck)
        {
            Console.Write("'{0}' Length equal to {1}:    ", toCheck, Value);
            if (toCheck.Length ==  Value)
            {
                return true;
            }
            return false;
        }

    }

    internal class any_LengthRule : IRule
    {
        public List<int>? Value { get; set; }

        public bool CheckRule(string toCheck)
        {
            string tmp = string.Join(", ", Value);
            Console.Write("'{0}' any_Length of ({1}):    ", toCheck, tmp);
            foreach (var item in Value)
            {
                if (toCheck.Length == item)
                {
                    return true;
                }
            }
            return false;
        }

    }

    internal class LengthGreaterThanRule : IRule
    {
        public int Value { get; set; }

        public bool CheckRule(string toCheck)
        {
            Console.Write("'{0}' LengthGreaterThan {1}:    ", toCheck, Value);
            if (toCheck.Length > Value)
            {
                return true;
            }
            return false;
        }

    }

    internal class any_LengthGreaterThanRule : IRule
    {
        public List<int>? Value { get; set; }

        public bool CheckRule(string toCheck)
        {
            string tmp = string.Join(", ", Value);
            Console.Write("'{0}' any_GreaterThan one of ({1}):    ", toCheck, tmp);
            foreach (var item in Value)
            {
                if (toCheck.Length > item)
                {
                    return true;
                }
            }
            return false;
        }

    }

    internal class LengthSmallerThanRule : IRule
    {
        public int Value { get; set; }

        public bool CheckRule(string toCheck)
        {
            Console.Write("'{0}' LengthSmallerrThan {1}:    ", toCheck, Value);
            if (toCheck.Length < Value)
            {
                return true;
            }
            return false;
        }

    }
    internal class any_LengthSmallerThanRule : IRule
    {
        public List<int>? Value { get; set; }

        public bool CheckRule(string toCheck)
        {
            string tmp = string.Join(", ", Value);
            Console.Write("'{0}' any_SmallerThan one of ({1}):    ", toCheck, tmp);
            foreach (var item in Value)
            {
                if (toCheck.Length < item)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
