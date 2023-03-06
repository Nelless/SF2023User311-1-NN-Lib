using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User311_1_NN_LibWPF.model
{
    public partial class Doctors
    {
        public string FullName
        {
            get
            {
                return $"{FirstName} {Patronymic} {LastName}";
            }

            set
            {
                this.FullName = value;
            }
        }
    }
}
