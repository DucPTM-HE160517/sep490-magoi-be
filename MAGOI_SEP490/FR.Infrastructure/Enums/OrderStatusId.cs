using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.Infrastructure.Enums
{
    public enum OrderStatusId : int
    {
        Pending = 1,
        Cooking = 2,
        Serving = 3,
        Finished = 4
    }
}
