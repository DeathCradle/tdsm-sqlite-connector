﻿using System;
using OTA.Data;

namespace TDSM.Data.SQLite
{
    public abstract class CacheTable
    {
        public CacheTable()
        {
            //Schedule loads
        }

        public abstract void Load(IDataConnector conn);

        public abstract void Save(IDataConnector conn);
    }
}

