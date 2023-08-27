using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp43
{
    class cEmployee
    {
        public string firstname;
        public string lastname;
        public string identity;


        public string Concatinate()
        {
            return firstname + ' ' + lastname;
        }
    }
}
