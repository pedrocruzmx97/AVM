﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Core.Model;

namespace Core.View
{
    public interface IEspecialista
    {
        void Mensaje(string Mensaje, int tipo);
        CEspecialista UsuarioLogeadoEspecialista { set; get; }
        DataSet Empleados { set; }
    }
}
