﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLmausac
    {
        DALmausac dal;
        public BLLmausac(string connectString)
        {
            dal = new DALmausac(connectString);
        }
    }
}
