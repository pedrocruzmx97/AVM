using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using System.Data;



namespace Core.View
{
    public interface IReporte
    {
        void Mensaje(string mensaje, int tipo);
        #region metodos reporte
        List<CReporte> listaDatosReporte { set; } //Ver las especialidades
        DataSet datosReportes { set; }

        List<CReporte> LlenarComboEspecialista { get; set; }
        #endregion
    }
}
