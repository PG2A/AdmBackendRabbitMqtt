﻿using MicroRabbit.Banking.Application.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Interfaces.Inventario
{
    public interface IChoferServices
    {
        void Transfer(ChoferModel chofer);
    }
}
