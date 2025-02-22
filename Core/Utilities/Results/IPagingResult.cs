﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IPagingResult<T> : IResult
    {
        List<T> Data { get; }
        int TotalItemCount { get; }
    }
}
