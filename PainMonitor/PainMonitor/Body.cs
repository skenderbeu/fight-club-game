using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainMonitor
{
    public class Body
    {
        public Head Head { get; set; }
        public Leg LeftLeg { get; set; }
        public Leg RightLeg { get; set; }
        public Torso Torso { get; set; }
        public Bottom Bottom { get; set; }
        public Back Back { get; set; }

        public Body()
        {
            Head = new Head();
            LeftLeg = new Leg();
            RightLeg = new Leg();
            Torso = new Torso();
            Bottom = new Bottom();
            Back = new Back();
        }
    }
    public class BodyPart
    {
        protected PainLevel painLevel;
        protected int pain;

        public BodyPart()
        {
            SetPainLevel();
        }

        private void SetPainLevel()
        {
            this.painLevel = new PainLevel(0);
        }

        public virtual void AddPain(int pain)
        {
            painLevel.AddPain(pain);
        }

        public int GetPainLevel()
        {
            return painLevel.GetPainLevel();
        }
    }

    public class Back: BodyPart
    {

    }

    public class Head: BodyPart
    {
        public Mouth Mouth { get; set; }
        public Lip Lips { get; set; }
        public Eye LeftEye { get; set; }
        public Eye RightEye { get; set; }
        public Head()
        {
            Mouth = new Mouth();
            Lips = new Lip();
        }
    }

    public class Torso: BodyPart
    {
        public Chest Chest { get; set; }

        public Torso()
        {
            Chest = new Chest();
        }
    }

    public class Chest: BodyPart
    {
        public Breast LeftBreast { get; set; }
        public Breast RightBreast { get; set; }

        public Chest()
        {
            LeftBreast = new Breast();
            RightBreast = new Breast();
        }

        public override void AddPain(int pain)
        {
            LeftBreast.AddPain(pain);
            RightBreast.AddPain(pain);
            base.AddPain(pain);
        }
    }

    public class Bottom: BodyPart
    {
        public BottomCheek LeftCheek { get; set; }
        public BottomCheek RightCheek { get; set; }

        public Bottom()
        {
            LeftCheek = new BottomCheek();
            RightCheek = new BottomCheek();
        }

        public override void AddPain(int pain)
        {
            LeftCheek.AddPain(pain);
            RightCheek.AddPain(pain);
            base.AddPain(pain);
        }
    }

    public class BottomCheek: BodyPart
    {

    }

    public class Leg: BodyPart
    {
        public Foot Foot { get; set; }
        public Thigh Thigh{ get; set; }

        public Leg()
        {
            Foot = new Foot();
            Thigh = new Thigh();
        }
    }

    public class Thigh: BodyPart
    {

    }

    public class Eye: BodyPart
    {

    }

    public class Mouth: BodyPart
    {
        
    }

    public class Lip: BodyPart
    {

    }

    public class Foot: BodyPart
    {

    }

    public class Breast: BodyPart
    {
        public Nipple Nipple { get; set; }

        public Breast()
        {
            Nipple = new Nipple();
        }

        public override void AddPain(int pain)
        {
            Nipple.AddPain(pain);
            base.AddPain(pain);
        }
    }

    public class Nipple : BodyPart
    {
 
    }
}
