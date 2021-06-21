using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPlan
{
    public class CPunit
    {
       public string Num_Etap{ get; set; }
       public string Name_Etap { get; set; }
       public DateTime? Nachalo_Data { get; set; }
       public DateTime? Konec_Data { get; set; }
       public int Days{ get; set; }
       public double Summ { get; set; }
       public string V { get; set; }


        public void SetCPUnitList()
        {
            List<CPunit> ListUnit = new List<CPunit>();

        }
    }
}
