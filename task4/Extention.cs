using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public static class Extention
    {
         public static bool CheckNotRobotCode(this string NotRobotCode)
        {
            if (NotRobotCode.Length==4)
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
