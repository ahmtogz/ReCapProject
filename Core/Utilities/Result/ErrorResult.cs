using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)
        {
            //base dedigimiz üstteki result class
        }
        public ErrorResult() : base(false)
        {
            //mesaj vermek istemiyorsa base tek parametre kismi calisir
        }
    }
}
