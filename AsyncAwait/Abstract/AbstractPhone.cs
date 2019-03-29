using System;
using System.Threading.Tasks;

namespace AsyncAwait
{

    /// <summary> 抽象： 里面的方法不能够完全确定
    ///  抽象类[代码重用 + 约束]，由于本身方法没有方法体，只是能够实例化重写了该方法的子类
    /// </summary>
    public abstract class AbstractPhone : Test1
    {
        public string Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 如果重写该方法有
        /// virtual -- overrid --不最好的重写方式，
        /// abstract -- override --抽象 ，推荐
        /// </summary>
        public abstract void System();

        public override void Fun1()
        {
            Console.WriteLine(">> 我要重写 Virtual的方法.");
        }
    }

    public class Test1
    {
        public virtual void Fun1()
        {
            Console.WriteLine("Virtual 方法必须有实现");
        }
    }

}
