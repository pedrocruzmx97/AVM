using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;

namespace Core.View
{
    public interface IAlumno
    {
        void Mensaje(string Mensaje, int tipo);
        //Inicio de sesion
        CAlumno UsuarioLogeado { set; get; }
        CAlumno UsuarioActulizar { set; get; }


       
    }
}
