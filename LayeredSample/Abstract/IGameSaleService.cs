using LayeredSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Abstract
{
    internal interface IGameSaleService
    {
        void Sale(Customer customer, Game game, Campaigns campaign);
    }
}
