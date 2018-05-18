using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainMonitor
{
    public class PainLevel
    {
        private int _pain;

        public PainLevel(int pain)
        {
            this._pain = pain;
        }

        public void AddPain(int pain)
        {
            _pain += pain;
        }

        public int GetPainLevel()
        {
            return _pain;
        }
    }
}
