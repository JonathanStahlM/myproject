using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class Class2
    {
    }
}




/*






/*


            /*
            List<string> args = new List<string>();
            args.Add("5");
            args.Add("6");
            List<string> temp = new List<string>();
            temp.Add("c");
            temp.Add("z");
            Console.WriteLine(args);
            public List<IRule> rules = new List<IRule>();
        addRule();
        MyRules RuleList = new MyRules();
        RuleList.AddRule("LengthGreaterThan", args);
            RuleList.AddRule("contains", temp);
            //RuleList.AddRule("contains", "a");
            //Console.WriteLine(RuleList.Rules[0].theValue);
            //Console.WriteLine(RuleList.Rules[1].theValue);
            //MyRule tmp = new MyRule("LengthGreaterThan", "5");
            //Console.WriteLine(tmp.theRule);
            //Console.WriteLine(tmp.theValue);
            RuleList.CheckRules("zzzz");
            */
        
/*

        public enum RuleType
{
    Contains,
    Length,
    //StartsWith,
    //EndsWith,
    Invalid
}

public enum valueType
{
    str,
    strList,
    integer,
    intList
}




/*
public RuleType CheckType(string operation, List<string> Value)
{

    switch (operation)
    {
        case "contains":

            return RuleType.Contains;

        case "Length":
            CheckValidValue(Value);
            return RuleType.EndsWith;
    }
    Console.WriteLine("Invalid Operation");
    return RuleType.Invalid;
}
*/







/*


public bool addRule(string rule, )
        {
            switch (rule)
            {
                case Operation.Contains:
                    if (Typeof()
                    {
                        ContainsRule newRule = new ContainsRule();
                        rules.add(newRule);
                    }
                    break;



                case "StartsWith" and:
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
    }

}



//class firstproject
//{

//}


*/


















/*
string[] arguments = Environment.GetCommandLineArgs();
string op = arguments[1];
string myString = arguments[2];
string value = arguments[3];



//if (value.Count == 0)
//{
//    Console.WriteLine("error: invalid number of arguments");
//    return (false);
//}

*/
/*
Console.WriteLine("hii");
for (int i = 0; i <  args.Length; i++)
{
    Console.WriteLine(" arg {1} : {2}", i , args[i]);
}
*/
/*
switch (op)
{
    case "Contains":
        if (myString.Contains(value))
        {
            return 1;
        }
        break;
    case "StartsWith":
        if(myString.StartsWith(value))
        {
            return 1;
        }
        break;
    case "EndsWith":
        if (myString.EndsWith(value))
        {
            return 1;
        }
        break;
    default:
        return 0;
}
*/

/*
if (op == "any_Contains")
{
foreach (string val in value)
{
    if (myString.Contains(val))
    {
        return true;
    }

}

}

if (op == "any_StartsWith")
{
foreach (string val in value)
{
    if (myString.StartsWith(val))
    {
        return true;
    }

}
}

if (op == "any_EndsWith")
{
foreach (string val in value)
{
    if (myString.EndsWith(val))
    {
        return true;
    }

}
}


int firstInt = Convert.ToInt32(value[0]);

if (op == "length")
{
return (myString.Length == firstInt);
}

if (op == "lengthSmallerThan")
{
return (myString.Length < firstInt);
}

if (op == "lengthGreaterThan")
{
return (myString.Length > firstInt);
}



if (op == "any_length")
{
foreach (string val in value)
{
    if (myString.Length == Convert.ToInt32(val))
    {
        return true;
    }

}
}

if (op == "any_lengthSmallerThan")
{
foreach (string val in value)
{
    if (myString.Length < Convert.ToInt32(val))
    {
        return true;
    }

}
}

if (op == "any_lengthGreaterThan")
{
foreach (string val in value)
{
    if (myString.Length > Convert.ToInt32(val))
    {
        return true;
    }

}
}

*/

