using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Calculationformula
{
    internal class Formula2 : AbstractFormula
    {
        public override List<string> Caclution(Schemeinformation schemeinformation)
        {
            tempResultList = new List<string>();
            //计算过程...其中需要使用到Schemeinformation中的信息
            //对tempResultList赋值
            return tempResultList;
        }
    }
}
