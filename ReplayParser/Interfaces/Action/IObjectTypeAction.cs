﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplayParser.Entities;

namespace ReplayParser.Interfaces.Action
{
    public interface IObjectTypeAction
    {
        ObjectType ObjectType { get; }
    }
}
