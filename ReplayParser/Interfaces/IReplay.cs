﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplayParser.Entities;

namespace ReplayParser.Interfaces
{
    public interface IReplay
    {
        IEnumerable<IAction> Actions { get; }
        String GameCreator { get; }
        EngineType EngineType { get; }
        int FrameCount { get; }
        GameType GameType { get; }
        String GameName { get; }
        IEnumerable<IPlayer> Players { get; }
        DateTime Timestamp { get; }
        IPlayer Winner { get; }
        // IReplayMap ReplayMap { get; } NOT IMPLEMENTED YET
        
    }
}
