using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Request
    {
        public object Argument { get; set; }
        public object Argument2 { get; set; }
        public Operation Operation { get; set; }
    }
}
