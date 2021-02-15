using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public interface IDataResult<T>:IResult
    {
        //IResult zaten mesaj ve success kismini icerdigi icin IDataresult:IResult implementasyonu yaptik

        T Data { get; }
    }

}
