using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;

namespace Core.View
{
    public interface IConsulta
    {


        void Mensaje(string Mensaje, int tipo);

        #region Metodos del alumno
        CConsulta DatosPasienteConsulta { get; }//Datos generales de un objeto consulta

        //Generar-Consulatar-Modificar-Eliminar Consulta
        CConsulta NewConsulta { get; }
        int EliminarConsulta { get; }
        DataSet ListadoConsulta { set; }
        DataSet HistorialCitas { set; }
        DataSet Odontograma { set; }
        //Obtener los especialistas-horas-fechas
        List<CConsulta> LlenarComboEspecialidad { get; set; } //Ver las especialidades
        List<CConsulta> LlenarComboEspecialista { get; set; }//Ver quienes son los especialistas
        List<CConsulta> LlenarComboHora { get; set; }//ser los horarios disponibles
        List<CConsulta> LlenarEnfermedad { get; set; }//Ver las enfermeddades
        #endregion


    }
}
