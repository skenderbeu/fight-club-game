using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PainMonitor;

namespace PainMonitorTest
{
    [TestClass]
    public class PainLevelTest
    {

        [TestMethod]
        public void PainLevel_IncreaseBy1_LevelIs1()
        {
            //Arrange
            var character = new Character("Kerry");
            var painLevel = new PainLevel(0);
            character.SetPainLevel(painLevel);
            character.InflictPain(1);
            var expected = 1;

            // Act
            var actual = character.GetPainLevel();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
