using Hospital_Korchevny.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hospital_Korchevny.ClassHelper
{
    public class EFTClass
    {
        public static Entities context { get; set; } = new Entities();
    }
}
