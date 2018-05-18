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

        public Body Body { get; set; }

        public Character(string name)
        {
            _name = name;
            Body = new Body();

            SetPainLevel();
        }

        private void SetPainLevel()
        {
            _painLevel = new PainLevel(0);
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
