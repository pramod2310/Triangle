using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SENG8040Assignment2;
using NUnit.Framework;
namespace TriangleTest
{
    public class Class1
    {
        [Test]
        public void Analyze_input_sideA_6_sideB_5_sideC_4_expectedOutput_Scalene()
        {
            //Arrange
            int sideA = 6;
            int sideB = 5;
            int sideC = 4;
            String answer = "This is a Scalene Triangle.";

            //Act

            String actualOutput = TriangleSolver.Analyze(6, 5, 4);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }

        [Test]
        public void Analyze_input_sideA_2_sideB_3_sideC_4_expectedOutput_Scalene()
        {
            //Arrange
            int sideA = 2;
            int sideB = 3;
            int sideC = 4;
            String answer = "This is a Scalene Triangle.";

            //Act

            String actualOutput = TriangleSolver.Analyze(2, 3, 4);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }
        [Test]
        public void Analyze_input_sideA_8_sideB_8_sideC_7_expectedOutput_Isocels()
        {
            //Arrange
            int sideA = 8;
            int sideB = 8;
            int sideC = 7;
            String answer = "This is a Isocels Triangle.";

            //Act

            String actualOutput = TriangleSolver.Analyze(8, 8, 7);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }

        [Test]
        public void Analyze_input_sideA_11_sideB_11_sideC_5_expectedOutput_Isocels()
        {
            //Arrange
            int sideA = 11;
            int sideB = 11;
            int sideC = 5;
            String answer = "This is a Isocels Triangle.";

            //Act

            String actualOutput = TriangleSolver.Analyze(11, 11, 5);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }
        [Test]
        public void Analyze_input_sideA_9_sideB_9_sideC_9_expectedOutput_Equilateral()
        {
            //Arrange
            int sideA = 9;
            int sideB = 9;
            int sideC = 9;
            String answer = "This is a Equilateral Triangle.";

            //Act

            String actualOutput = TriangleSolver.Analyze(9, 9, 9);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }
        [Test]
        public void Analyze_input_sideA_15_sideB_15_sideC_15_expectedOutput_Equilateral()
        {
            //Arrange
            int sideA = 15;
            int sideB = 15;
            int sideC = 15;
            String answer = "This is a Equilateral Triangle.";

            //Act

            String actualOutput = TriangleSolver.Analyze(15, 15, 15);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }
        [Test]
        public void Analyze_input_sideA_52_sideB_12_sideC_2_expectedOutput_Notpossible()
        {
            //Arrange
            int sideA = 52;
            int sideB = 12;
            int sideC = 2;
            String answer = "Triangle is Not Posibble.";

            //Act

            String actualOutput = TriangleSolver.Analyze(52, 12, 2);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }
        [Test]
        public void Analyze_input_sideA_98_sideB_24_sideC_17_expectedOutput_Notpossible()
        {
            //Arrange
            int sideA = 94;
            int sideB = 24;
            int sideC = 17;
            String answer = "Triangle is Not Posibble.";

            //Act

            String actualOutput = TriangleSolver.Analyze(94, 24, 17);

            //Assert
            Assert.AreEqual(answer, actualOutput);

        }


    }
}

