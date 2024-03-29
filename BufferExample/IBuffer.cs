﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BufferExample
{
    interface IBuffer<T>
    {
        bool IsEmpty { get; }

        void Write(T value);

        T Read();
    }
}
