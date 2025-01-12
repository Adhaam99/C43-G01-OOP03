using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Enums
{
    [Flags]
    enum SecurityPrivileges
    {

        None = 0,
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8

    }
}
