﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceNow.Domain.Services
{
    public interface IRestSingleResponse<T>
    {
        T Result { get; set; }
    }
}
