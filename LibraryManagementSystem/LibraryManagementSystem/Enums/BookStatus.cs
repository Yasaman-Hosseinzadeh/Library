using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Enums
{
    public enum BookStatus : byte
    {
        [Description("موجود")]
        Exists = 1,
        [Description("ناموجود")]
        None_Exists = 2
    }
}
