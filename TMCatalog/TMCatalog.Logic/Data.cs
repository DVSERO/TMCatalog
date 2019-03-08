// ------------------------------------------------------------------------------------------------------------------
// <copyright file="CatalogController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------


namespace TMCatalog.Logic
{
    public static class Data
    {
        static Data()
        {
            Catalog = new CatalogController();
        }

        public static CatalogController Catalog { get; set; }
    }
}
