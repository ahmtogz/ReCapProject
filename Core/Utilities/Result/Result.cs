using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        // burda iki farkli kullanim var birinde sadece basarili basarisiz döndürecek
        //üstteki hem basarili basarisiz hem de mesaj döndürecek
        public Result(bool success )
        {
            Success = success;
        }

        //Iresult ampulden cözdük ve gelen bunlar
        public bool Success { get; }

        public string Message { get; }
    }
}
