﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SPmedicals_webapi.Domains
{
    public partial class Consultum
    {
        public byte IdConsulta { get; set; }
        public byte? IdMedico { get; set; }
        public byte? IdClientes { get; set; }
        public string DataConsulta { get; set; }
        public string DescConsulta { get; set; }

        public virtual Cliente IdClientesNavigation { get; set; }
        public virtual Medico IdMedicoNavigation { get; set; }
    }
}
