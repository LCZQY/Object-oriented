
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwait.Abstract
{

    /// <summary>
    /// 接口【约束】： 只能够包含为实现的方法，不能有已经实现的方法
    ///        还可以包含属性--事件--索引器
    /// </summary>
    public interface IPhone
    {

        void Photo();

    }
}
