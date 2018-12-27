using System;
using System.Collections.Generic;

namespace COP2210.Assignment9
{
    internal class CDList
    {
        internal CDList()
        {
        }

        internal List<CertificateOfDeposit> Values;

        internal void Add(CertificateOfDeposit CD)
        {
            this.Values.Add(CD);
        }


    }
}
