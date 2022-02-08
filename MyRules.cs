using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace first_project
{
    public class RulesList
    {
        public List<IRule> Rules;

        public MyRules()
        {
            Rules = new List<Rule>();
        }

       

        public void AddRule(string rule, List<string> value)
        {
            Rule newRule = new Rule(rule, value);
            Rules.Add(newRule);
        }

        /*
        public void AddRule(string rule, List<string> value)
        {
            foreach (string item in value)
            {
                Rule newRule = new Rule(rule, item);
                Rules.Add(newRule);
            }
            
        }*/

/*

        public void CheckRules(string toCheck)
        {
            int i = 0;
            foreach (Rule tmp in this.Rules)
            {
                Console.WriteLine("{0} {1} {2}:   {3}", toCheck, tmp.theRule, tmp.theValue[i] ,tmp.CheckRule(toCheck));
                i++;
            }

        }
    }
}


*/

/*

/*
    Console.WriteLine(this.theRule);
Console.WriteLine(this.theValue);
Console.WriteLine(toCheck);

//
switch (this.theRule)
{
    case "contains":
        if (toCheck.Contains(theValue))
        {
            return true;
        }
        break;
    case "StartsWith":
        if (toCheck.StartsWith(theValue))
        {
            return true;
        }
        break;
    case "EndsWith":
        if (toCheck.EndsWith(theValue))
        {
            return true;
        }
        break;
    case "Length":
        if (toCheck.Length == Int32.Parse(theValue))
        {
            return true;
        }
        break;
    case "LengthSmallerThan":
        if (toCheck.Length < Int32.Parse(theValue))
        {
            return true;
        }
        break;
    case "LengthGreaterThan":
        if (toCheck.Length > Int32.Parse(theValue))
        {
            return true;
        }
        break;
}
return false;
*/
