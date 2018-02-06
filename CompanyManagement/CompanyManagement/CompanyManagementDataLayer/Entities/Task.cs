using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEntities
{
   public class Task
    {

        public int technologyMasterId { get; set; }
        public String name { get; set; }
        public int statusId { get; set; }

        public DateTime updateDate { get; set; }


    }
}
