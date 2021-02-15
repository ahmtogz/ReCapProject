using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message)
        {
            //base dedigimiz üstteki result class
        }
        public SuccessResult():base(true)
        {
            //mesaj vermek istemiyorsa base tek parametre kismi calisir
        }
    }
}
