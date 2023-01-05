using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Calculationformula
{
    /// <summary>
    /// 使用公式，并管理结果集
    /// </summary>
    internal class Context
    {
        AbstractFormula formula;
        public void SetFromula(AbstractFormula formula)
        {
            this.formula = formula;
        }
        public List<string> Caclute(Schemeinformation schemeinformation)
        {
            return formula.Caclution(schemeinformation);
        }
    }
}
