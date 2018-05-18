using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PainMonitor;

namespace PainMonitorTest
{
    [TestClass]
    public class PainLevelTest
    {
        private Character character;

        [TestInitialize]
        public void Setup()
        {
            character = new Character("Kerry");
        }

        [TestCleanup]
        public void CleanUp()
        {
            character = null;
        }

        [TestMethod]
        public void PainLevel_IncreaseByOne_LevelIsOne()
        {
            //Arrange
            var pain = 1;
            character.InflictPain(pain);
            var expected = 1;

            // Act
            var actual = character.GetPainLevel();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PainLevel_IncreaseByFive_LevelIsFive()
        {
            //Arrange
            var pain = 5;
            character.InflictPain(pain);
            var expected = 5;

            // Act
            var actual = character.GetPainLevel();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PainLevel_IncreaseByFiveTwice_LevelIsTen()
        {
            //Arrange
            var pain = 5;
            character.InflictPain(pain);
            character.InflictPain(pain);

            var expected = 10;

            // Act
            var actual = character.GetPainLevel();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PainLevel_IncreaseBy5_OnTorso_LevelIsFive()
        {
            //Arrange
            var pain = 5;
            character.Body.Torso.AddPain(pain);

            var expected = 5;

            // Act
            var actual = character.Body.Torso.GetPainLevel();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PainLevel_IncreaseBy5_OnLeftThigh_LevelIsFive()
        {
            //Arrange
            var pain = 5;
            character.Body.LeftLeg.Thigh.AddPain(pain);

            var expected = 5;

            // Act
            var actual = character.Body.LeftLeg.Thigh.GetPainLevel();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PainLevel_IncreaseByDiff_OnEachBreast_LevelIsFiveAndTwo()
        {
            //Arrange
            var pain = 5;
            character.Body.Torso.Chest.LeftBreast.AddPain(pain);

            pain = 2;

            character.Body.Torso.Chest.RightBreast.AddPain(pain);

            var expectedLeftBreast = 5;
            var expectedRightBreast = 2;

            // Act
            var actualLeftBreast = character.Body.Torso.Chest.LeftBreast.GetPainLevel();
            var actualRightBreast = character.Body.Torso.Chest.RightBreast.GetPainLevel();

            //Assert
            Assert.AreEqual(expectedLeftBreast, actualLeftBreast);
            Assert.AreEqual(expectedRightBreast, actualRightBreast);
        }

        [TestMethod]
        public void PainLevel_IncreaseByFiveAndFive_OnBottom_LevelIsTen()
        {
            //Arrange
            var pain = 5;
            character.Body.Bottom.AddPain(pain);
            character.Body.Bottom.AddPain(pain);

            var expected = 10;


            // Act
            var actualLeftCheek = character.Body.Bottom.LeftCheek.GetPainLevel();
            var actualRightCheek= character.Body.Bottom.RightCheek.GetPainLevel();

            //Assert
            Assert.AreEqual(expected, actualLeftCheek);
            Assert.AreEqual(expected, actualRightCheek);
        }
    }
}
