namespace Strategy_Calculationformula
{
    /// <summary>
    /// 策略模式实现计算公式重构
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context= new Context();
            //获取所有方案信息
            List<Schemeinformation> schemeinformationList = new List<Schemeinformation>();
            //总结果集
            List<Result> results= new List<Result>();

            foreach(Schemeinformation schemeinformation in schemeinformationList)
            {
                //使用反射动态创建公式实例
                context.SetFromula((AbstractFormula)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(schemeinformation.Formula));
                //获取当前公式的计算结果集
                List<string>tempResults=context.Caclute(schemeinformation);
                //遍历结果，将所有结果放入到总结果集中
                foreach(string tempResult in tempResults)
                {
                    results.Add(new Result(schemeinformation,tempResult));
                }
            }
            //下面就可以输出总结果集了
            Console.WriteLine(results.Count);
        }
    }
}