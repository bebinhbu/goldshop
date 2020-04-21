using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldShop.DTOs
{
    public class ErrorModel
    {
        public List<string> Errors = new List<string>();
        public bool IsEmpty
        {
            get
            {
                return !this.Errors.Any();
            }
        }

        public void Add(string error)
        {
            Errors.Add(error);
        }
    }
}
