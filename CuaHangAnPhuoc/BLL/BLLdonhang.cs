﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLdonhang
    {
        DALdonhang dal;
        public BLLdonhang(string connectString)
        {
            dal = new DALdonhang(connectString);
        }
    }
}
