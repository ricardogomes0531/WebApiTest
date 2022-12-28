using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Shared.Utils
{
    public class DataResult
    {
        public void AddResult(object result)
        {
            Data = result;
            IsValid = true;
        }

        public void AddMessageError(string messageError)
        {
            IsValid = false;
            Errors = new List<string>();
            Errors.Add(messageError);
                        }

        public object Data { get; set; }
        public bool IsValid { get; set; }
        public IList<string> Errors { get; set; }
    }
}
