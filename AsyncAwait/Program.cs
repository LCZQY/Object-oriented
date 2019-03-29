using AsyncAwait.Abstract;
using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {

        static void Main(string[] args)
        {
            //1.
            {
                //接口的实例化
                {
                    IPhone telephone = new Telephone();                    
                    telephone.Photo(); //只是能够调用到接口里面的方法？？但是Telephone中明明存在 System()方法
                                       ///原因在于：net是个强编译的语言，是编译器限制的，编译器会根据变量类型决定
                    //绕过编译器的限制  dynamic
                    dynamic phone = telephone;
                    phone.System();


                    Console.WriteLine("我要用Var ========================");
                    var phone2 = telephone;
                    phone.System();

                }

                //抽象的实例化
                {
                    AbstractPhone telephone = new Telephone();

                    telephone.System();
                    telephone.Fun1();
                }

            }

            //2.
            {                
                // 面向抽象， 把抽象类作为参数，调用此方法的时候可传递继承该抽象类的子类
            }

            //3 接口和抽象类如何选择？
            {
                // 抽象类： 代码重用 + 约束 ， 功能强大，单继承 -----> 沉重
                // 接口： 只能做约束， 功能单一 ， 多实现      -----> 灵活 

            }

            Console.ReadKey();

        }

     
    }
}
