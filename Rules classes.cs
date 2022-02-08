using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class ContainsRule : IRule
    {
        public string Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            Console.Write("{0} Contains {1}:    ", toCheck, Value);
            if (toCheck.Contains(Value))
            {
                return true;
            }
            return false;
        }
    }

    internal class any_ContainsRule : IRule
    {
        public List<string>? Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            string tmp = string.Join(",", Value);
            Console.Write(tmp);
            Console.Write("{0} any_Contains one of ({1}):    ", toCheck, tmp);
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
            Console.WriteLine("StartsWith");
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
            Console.WriteLine("any_StartsWithRule");
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
    internal class EndsWithRule : IRule
    {
        public string Value { get; set; }
        public bool CheckRule(string toCheck)
        {
            Console.WriteLine("EndsWith");
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
            Console.WriteLine("any_EndsWithRule");
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

    internal class LengthRule : IRule
    {
        public int Value { get; set; }

        public bool CheckRule(string toCheck)
        {
            Console.WriteLine("Length");
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
            Console.WriteLine("any_LengthRule");
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
            Console.WriteLine("LengthGreaterThan");
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
            Console.WriteLine("any_LengthGreaterThanRule");
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
            Console.WriteLine("LengthSmallerThanRule");
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
            Console.WriteLine("any_LengthSmallerThanRule");
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
