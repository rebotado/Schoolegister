﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolegister.Model
{
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string BloodType { get; set; }
        string PhoneNumber { get; set; }
        string Curp { get; set; }
        string BirthDate { get; set; }
        string Address { get; set; }
        string Email { get; set; }
    }
}
