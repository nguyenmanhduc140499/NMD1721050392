﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace NMD1721050392.Models
{
    public class StringProcess
    {
        public string AutoGeneredKey(string id)
        {
            string strkey = "";
            string numPart = "", strPart = "", strPhanso = "";

            numPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;

            int Phanso = (Convert.ToInt32(numPart) + 1);

            for (int i = 0; i < numPart.Length - Phanso.ToString().Length; i++)
            {
                strPhanso += "0";
            }
            strPhanso += Phanso;
            strkey = strPart + strPhanso;

            return strkey;

        }
    }
}