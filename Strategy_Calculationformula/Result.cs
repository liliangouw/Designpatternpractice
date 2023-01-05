using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Calculationformula
{
    internal class Result
    {
        public Result(Schemeinformation schemeinformation, string Result)
        {
            Schemeinformation = schemeinformation;
            FinalResult=Result;
        }
        public string FinalResult { get; set; }

        public Schemeinformation Schemeinformation { get; set; }
    }
}
