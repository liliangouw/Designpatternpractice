using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Calculationformula
{
    internal class Formula1 : AbstractFormula
    {
        public override List<string> Caclution(Schemeinformation schemeinformation)
        {
            tempResultList = new List<string>();
            //计算过程... 对tempResultList赋值
            return tempResultList;
        }
    }
}
