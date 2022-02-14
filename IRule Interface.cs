using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{

    public interface IRule
    {
        //List<string> Value { get; set; }
        public bool CheckRule(string toCheck);


    }
}


