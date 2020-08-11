using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace tab.client
{
    public interface IBetClient
    {
        Task Excute(Decimal amount);
    }
}