using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class EletricFActory
    {
        public IElectric GetMobileByName(string mobileName)
        {
            IElectric mobile = NullEletric.Instance;
            switch (mobileName)
            {
                case "apple":
                    mobile = new IPhone();
                    break;

                case "samsung":
                    mobile = new Samsung();
                    break;
            }
            return mobile;
        }
    }
}
