﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoLP2
{
    class connection
    {
        public MySqlConnection conn = new MySqlConnection();
        public void conectar()
        {
            conn.ConnectionString = "Server=localhost; Database=birb; Uid=root; Pwd=Malued01@lol;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
        }
    }
}