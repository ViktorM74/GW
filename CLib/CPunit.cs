using System;
using feature_сlass;

namespace CLib
{
    public class CPunit
    {
        public string num_etap
        {
            get 
            {
                 return _num_Etap;
            }
            set 
            {
                set_numEtap(value);
            }
        }

        private string set_numEtap(object value)
        {
            _num_Etap = value.ToString();
            _num_sort = feature.NormalizeNumSort(_num_Etap);
            return _num_Etap;
        }

        public string name_etap
        {
            get 
            {
                return _name_Etap;
            }
            set 
            {
                set_nameEtap(value);
            }
        }

        private string set_nameEtap(object value)
        {
            _name_Etap = value.ToString();
            return _name_Etap;
        }

        public DateTime? nachalo_data
        {
            get 
            {
                return _nachalo_Data;
            }
            set 
            {
                set_nachalo(value);
            }
        }

        private DateTime? set_nachalo(object value)
        {
            if (value != DBNull.Value)
                _nachalo_Data = Convert.ToDateTime(value);
            else
                _nachalo_Data = null;

            return _nachalo_Data;
        }

        public DateTime? konec_data
        {
            get 
            {
                return _konec_Data;
            }
            set 
            {
                set_konec(value);
            }
        }

        private DateTime? set_konec(object value)
        {
            if (value != DBNull.Value)
                _konec_Data = Convert.ToDateTime(value);
            else
                _konec_Data = null;
            return _konec_Data;
        }

        public int? days
        {
            get 
            {
                return _days;
            }
            set {
                set_day(value);
            }
        }

        private int? set_day(object value)
        {
            if (value != DBNull.Value)
                _days = Convert.ToInt32(value);
            else
                _days = null;

            return _days;
        }

        public decimal? summ
        {
            get 
            {
                return _summ;
            } 
            set 
            {
                set_sum(value);
            }
        }

        private decimal? set_sum(object value)
        {
            if (value != DBNull.Value)
                _summ = Convert.ToDecimal(value);
            else
                _summ = null;
            return _summ;
        }

        public string valute
        {
            get 
            {
                return _valute;
            }
            set {
                set_vlt(value);
            }
        }

        private string set_vlt(object value)
        {
            _valute = value.ToString();
            return _valute;
        }

        public string num_sort
        {
            get 
            {
                return _num_sort;
            }
        }

        private string _num_Etap;
        private string _name_Etap;
        private DateTime? _nachalo_Data;
        private DateTime? _konec_Data;
        private int? _days;
        private decimal? _summ;
        private string _valute;
        private string _num_sort;

        public CPunit(object numEtap, object nameEtap, object nachaloData, 
                      object konecData, object day, object sum, object vlt)
        {
            this.num_etap = set_numEtap(numEtap);
            this.name_etap = set_nameEtap(nameEtap);
            this.nachalo_data = set_nachalo(nachaloData);
            this.konec_data = set_konec(konecData);
            this.days = set_day(day);
            this.summ = set_sum(sum);
            this.valute = set_vlt(vlt);
        }

        public CPunit()
        {
           
        }
    }


}
