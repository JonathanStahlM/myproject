using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*

namespace first_project
{
    public class Rules
    {
        public class ContainsRule : IRule
        {
            public string Value { get; set;  }

            public bool CheckRule(string toCheck)
            {
                if (toCheck.Contains(Value))
                {
                    return true;
                }
                return false;
            }

        }


        public class StartsWithRule : IRule
        {
            public string Value;

            public StartsWithRule(string value)
            {
                Value = value;
            }

            

        }
    }









    public abstract class RuleBase<T> : IRule
    {
        public string theRule;

        public abstract T theValue { get; }



       

        /*

        public Rule(string rule, List<string> value)
        {
            this.theRule = rule;
            this.theValue = value;
        }
        

        public bool CheckRule(string toCheck)
        {
            //Console.WriteLine(this.theRule);
            //Console.WriteLine(this.theValue);
            //Console.WriteLine(toCheck);

            foreach (string item in this.theValue)
            {
                Console.WriteLine("{0} {1} {2}:   {3}", toCheck, tmp.theRule, tmp.theValue[i], tmp.CheckRule(toCheck));
                switch (this.theRule)
                {
                    case "contains":
                        if (toCheck.Contains(item))
                        {
                            return true;
                        }
                        break;
                    case "StartsWith":
                        if (toCheck.StartsWith(item))
                        {
                            return true;
                        }
                        break;
                    case "EndsWith":
                        if (toCheck.EndsWith(item))
                        {
                            return true;
                        }
                        break;
                    case "Length":
                        if (toCheck.Length == Int32.Parse(item))
                        {
                            return true;
                        }
                        break;
                    case "LengthSmallerThan":
                        if (toCheck.Length < Int32.Parse(item))
                        {
                            return true;
                        }
                        break;
                    case "LengthGreaterThan":
                        if (toCheck.Length > Int32.Parse(item))
                        {
                            return true;
                        }
                        break;
                }
            }
            
            return false;
        }
    }

    public class ContainsRule : RuleBase<string>
    {
        public override string theValue { get }
    }
    }


}

*/