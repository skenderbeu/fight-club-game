using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainMonitor
{
    public class Character
    {
        private string _name;
        private PainLevel _painLevel;

        public Character(string name)
        {
            _name = name;
        }

        public void SetPainLevel(PainLevel painLevel)
        {
            _painLevel = painLevel;
        }

        public void InflictPain(int pain)
        {
            _painLevel.AddPain(pain);
        }

        public int GetPainLevel()
        {
            return _painLevel.GetPainLevel();
        }
    }
}
