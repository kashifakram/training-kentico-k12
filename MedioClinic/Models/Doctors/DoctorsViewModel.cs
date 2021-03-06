﻿using System.Collections.Generic;
using Business.Dto.Doctors;

namespace MedioClinic.Models.Doctors
{
    public class DoctorsViewModel : IViewModel
    {
        public DoctorSectionDto DoctorSection { get; set; }
        public IEnumerable<DoctorDto> Doctors { get; set; }
    }
}