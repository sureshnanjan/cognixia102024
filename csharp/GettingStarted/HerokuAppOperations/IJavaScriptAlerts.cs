using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{

    public interface IJavaScriptAlerts
    {
        public void ClickforJsAlert();
        public void ClickforJsAlertClose();

        public void ClickforJsConfirm();
        public void ClickforJsConfirmClose();

        public void ClickforJsPrompt();
        public void ClickforJsPromptClose(String message);
    }
    
}
