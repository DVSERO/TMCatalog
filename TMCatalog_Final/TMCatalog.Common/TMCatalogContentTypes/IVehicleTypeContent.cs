﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMCatalog.Common.Model;

namespace TMCatalog.Common.TMCatalogContentTypes
{
  public interface IVehicleTypeContent : ITMCatalogContent
  {
    IVehicleType VehicleType { get; }
  }
}
