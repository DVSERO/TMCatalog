using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMCatalog.Common.Model
{
  public interface IModel : IDescription
  {
    int Id { get; set; }
  }
}
