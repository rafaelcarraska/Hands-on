﻿using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Handson.Models;
using System.Data;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace Handson.Dao
{
    internal class SuspeitosDao
    {
        Conexao _conn = new Conexao();

        string sql = string.Empty;

        internal DataTable Listar_Suspeitos()
        {
            sql = $"select * from Suspeitos order by Descricao";
            return _conn.dataTable(sql);
        }
    }
}
