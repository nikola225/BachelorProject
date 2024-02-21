using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.GUIController
{
    internal class ControllerIzbor
    {
        public void Connect()
        {
            Communication.Instance.Connect();
        }
    }
}
