using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class SearchQuery
    {
        public string title { get; set; }

        public bool verify(List<FormError> errors)
        {
            int errs = errors.Count;

            return errs == errors.Count;
        }
    }
}
