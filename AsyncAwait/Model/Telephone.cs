using System;
using System.Threading.Tasks;
using AsyncAwait.Abstract;

namespace AsyncAwait
{

    /// <summary> 细节:可以确定具体的方法
    /// 
    /// </summary>
    public class Telephone : AbstractPhone, IPhone
    {        
        public void Photo()
        {
            Console.WriteLine(">> 我要实现接口类中的方法..");
        }

        public override void System()
        {
            Console.WriteLine(">> 我要实现抽象类中的方法..");
        }

    }
}
