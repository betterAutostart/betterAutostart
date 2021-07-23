using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betterAutostart
{
    class ExecutableApp
    {
        String path;
        String customName;
        bool executeAsAdmin;

        public ExecutableApp(String path, String customName, bool executeAsAdmin)
        {
            this.path = path;
            this.customName = customName;
            this.executeAsAdmin = executeAsAdmin;
        }
    }
}
