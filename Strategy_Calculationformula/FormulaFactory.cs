using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Calculationformula
{
    /// <summary>
    /// 创建公式的简单工厂
    /// </summary>
    internal class FormulaFactory
    {
        public static AbstractFormula GetFormula(string Formula)
        {
            if(Formula == "F1")
            {
                return new Formula1();
            }
            else if(Formula == "F2")
            {
                return new Formula2();
            }
            //以下若干.....

            else
            {
                //找不到这个公式，抛出异常
                throw new ArgumentNullException("value", $"公式{Formula}不存在"); ;
            }
            
        }
    }
}
