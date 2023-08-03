using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class FeeManager
    {
        public static Fee GetFeeById(int id, TravelExpertsContext db)
        {
            Fee fee = db.Fees.Find(id);
            return fee;
        }
    }
}
