using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    public class Gender: Enumeration
    {
        public static readonly Gender Male = new Gender(1, "Male");
        public static readonly Gender Female = new Gender(2, "Female");

        public Gender(int id, string name): base(id,name)
        {

        }

    }
}
