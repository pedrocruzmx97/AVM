using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;
namespace Core.View
{
    public interface ICombo
    {
        List<CCombo> LlenarCombo { get; set; }
    }
}
