using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace personal_agenda_management.Models
{


    public class People
    {
        [DataType(DataType.Date)]
        [Display(Name ="Name")]
        public int id { get; set; }

        public string name { get; set; }

        public string phoneNumber { get; set; }


    }
}