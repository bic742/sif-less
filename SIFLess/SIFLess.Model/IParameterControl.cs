﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model
{
    public interface IParameterControl
    {
        string FieldMap { get; }
        string Value { get; }

    }
}
