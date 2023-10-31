using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class Street
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public List<GeneralAdmin> GeneralAdmins { get; set; }

        // City reference

    }
}
