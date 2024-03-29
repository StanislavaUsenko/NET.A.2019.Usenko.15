﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Interfaces
{
    public interface IConverter<inT, outT>
    {
        List<outT> ConvertList(List<inT> objects);

        outT ConvertObject(inT obj);
    }
}
