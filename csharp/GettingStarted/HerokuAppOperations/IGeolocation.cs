using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IGeolocation
    {
        public void OnclickWhereami();

        public void GetLocationDetails();
    }
}
