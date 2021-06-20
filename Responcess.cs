using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTestSecond
{
    public class Responcess<T>
    {
        public int ErrorId { get; set; }
        public int ErrorCode { get; set; }
        public List<string> ErrorMessage { get; set; }
        public T Data { get; set; }
    }
        public class SqlResponce<T>
        {
        public int id { get; set; }

        public T fulldata { get; set; }

        public string Errormsg { get; set; }
    }


    
}
