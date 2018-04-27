using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Functionality
{
    class ValidateLogin
    {
        String[] username = new String[] { "Billy", "Chris", "Josh", "Oren", "Eddy" };
        String[] password = new String[] { "B!11y", "Chr!$", "J0sh!", "0r3n", "3ddy!" };
        int[] permission = new int[] { 1, 2, 2, 3, 4 };
        public int Validation(string UN, string PW)
        {
            int nopermission = 0;
            int currentpermission = 0;
            int NumOfUser = username.Count();
            int setter = 0;
            for (setter = 0; setter < NumOfUser; setter++)
            {
                if (UN == username[setter])
                {
                    if (PW == password[setter])
                    {
                        currentpermission = setter;
                        setter = NumOfUser;
                    }
                    else
                    {
                        currentpermission = nopermission;
                        setter = NumOfUser;
                    }   
                }
            }


            if (currentpermission != 0)
            {
                return currentpermission;
            }
            else
            {
                return nopermission;
            }
        }

    }
}
