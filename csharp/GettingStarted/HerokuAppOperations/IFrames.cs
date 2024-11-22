using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IFrames
    {
        

        public void OnClickingNestedframes();
        public void CheckTopframe();
        public void CheckBottomframe();        
        public void CheckLeftframe();
        public void CheckRightframe();
        public void CheckMiddleframe();


        public void OnClickingiFrame();
    }
}
