using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.Presenter;
using Core.View;
using System.Data;

namespace Core.View
{
    public interface IChat
    {
        CChat objChat { get; set; }
        DataSet DatosChat { get; set; }
    }
}
