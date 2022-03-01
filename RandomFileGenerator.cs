using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;

namespace first_project
{
    internal static class RandomFileGenerator
    {
        public static Random Rand = new Random();
        
        public static string GenarateRules()
        {
            int NumOfRules = 5;

            while (NumOfRules > 0)
            {
                Rule rule = GenerateRule();
                Rule.rules.Add(rule);
                NumOfRules--;
                
            }

            return RulesToJson();

        }

        public static IntRule GenerateIntRule(RuleType ruleType)
        {
            IntRule rule;
            List<int> value = GenerateIntValue();
            rule = new IntRule()
            {
                ruleType = ruleType,
                Value = value,
            };
            return rule;
        }

        public static StringRule GenerateStringRule(RuleType ruleType)
        {
            StringRule rule;
            List<string> value = GenerateStringValue();
            rule = new StringRule()
            {
                ruleType = ruleType,
                Value = value,
            };
            return rule;
        }




        public static Rule GenerateRule()
        {
            RuleType ruleType = GenerateRuleType();
            Rule rule;
            if ((int)ruleType < 6)
            {
                rule = GenerateStringRule(ruleType);
               
            }
            else
            {
                rule = GenerateIntRule(ruleType); 
                
            }
            return rule;
        }

        public static string RulesToJson()
        {
            string tmp = JsonConvert.SerializeObject(Rule.rules);
            Console.WriteLine(tmp);
            return tmp;
        }

        /*
        public RuleType GenerateIntRuleType()
        {
            int ruleType = Rand.Next(Global.NumberOfIntRules, Global.NumberOfRules + 1);
            return (RuleType)ruleType;
        }

        public RuleType GenerateStringRuleType()
        {
            int ruleType = Rand.Next(Global.NumberOfStringRules + 1);
            return (RuleType)ruleType;
        }*/


        public static RuleType GenerateRuleType()
        {
            int ruleType = Rand.Next(6);
            return (RuleType)ruleType;
        }

        public static List<String> GenerateStringValue()
        {
            int NumOfValues = Rand.Next(1,10);
            List<string> value = new List<string>();
            while (NumOfValues > 0)
            {
                value.Add(GenerateString());
                NumOfValues--; 
            }
            return value;

        }
        public static List<int> GenerateIntValue()
        {
            int NumOfValues = Rand.Next(5);
            List<int> value = new List<int>();
            while (NumOfValues > 0)
            {
                value.Add(Rand.Next(100));
                NumOfValues--;
            }
            return value;
        }

        public static string GenerateString()
        {
            int NumOfChars = Rand.Next(10);
            char RandChar;
            
            string str = "";
            while(NumOfChars > 0)
            {
                RandChar = (char)Rand.Next(41, 175);
                str += RandChar;
                NumOfChars--;
            }
            return str; 
        }

    }

    

}
