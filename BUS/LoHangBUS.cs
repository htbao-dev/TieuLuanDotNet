﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoHangBUS
    {
        private LoHangDAL loHang;

        public LoHangBUS()
        {
            loHang = new LoHangDAL();
        }

        public List<LoHangDTO> getByMaMatHang(int maMatHang)
        {
            return loHang.GetByMaMatHang(maMatHang);
        }
    }
}
