using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Calculationformula
{
    internal abstract class AbstractFormula
    {
        //公式计算后的结果集
        public List<string>? tempResultList;
        public abstract List<string> Caclution(Schemeinformation schemeinformation);
    }
}
