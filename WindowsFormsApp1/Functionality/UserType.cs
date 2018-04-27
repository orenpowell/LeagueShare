using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Functionality
{
    class UserType
    {

        public Boolean MenuItemVisible(string c)
        {
            if (c == "logout")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
