﻿using System;

namespace FunnyBus.Infrastructure.Store
{
    internal interface IHandlerStore
    {
        Type Get(Type type);
        Type GetByMessageType(Type messageType);

        bool Remove(Type key);

        bool Add(Type handler);
    }
}