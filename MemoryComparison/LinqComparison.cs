﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MemoryComparison
{
    public class LinqComparison: IComparison
    {
        public bool Compare(byte[] A, byte[] B)
        {
            return A.SequenceEqual(B);
        }

    }
}
