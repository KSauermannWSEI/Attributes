using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class ObsoleteClass
    {
        [Obsolete("Użyj metody NewMethod")]
        public string OldMethod()
        {
            try
            {
                //próba połączenia z serwerem X
                throw new Exception("Serwer nie istnieje");
            }
            catch (Exception ex)
            {
                //logowanie
            }
            return nameof(OldMethod);
        }
        public string NewMethod()
        {
            //próba połączenia z serwerem Y
            return nameof(NewMethod);
        }
    }
}
