using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMCatalog.Common.Model
{
  public interface IManufacturer : IDescription
  {
    int Id { get; set; }
  }
}
