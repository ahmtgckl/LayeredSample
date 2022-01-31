using LayeredSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Abstract
{
    internal interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Delete(Campaigns campaign);
        void Update(Campaigns campaign);
    }
}
