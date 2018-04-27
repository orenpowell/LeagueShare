using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Functionality
{
    class UserType
    {
        // Verifying the type of User to show specific items on the form. 
        // Eventually, this will change with the different level of users, 
        // so figure I separate it now so I only need to change it in one location. 
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
