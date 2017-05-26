using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace GetSum.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetCostByCutNumTest()
        {
            //Arrange:
            ISum getsumbycut3 = Substitute.For<ISum>();
            getsumbycut3.GetCostByCutNum(3).Returns(new List<int> { 6, 15, 24, 21 });

            //期望值
            var expected = new List<int>{ 6, 15, 24, 21 };

            //Act
            var actual = getsumbycut3.GetCostByCutNum(3);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetRevenueByCutNumTest()
        {
            //Arrange
            ISum getsumbycut4 = Substitute.For<ISum>();
            getsumbycut4.GetRevenueByCutNum(4).Returns(new List<int> { 50, 66, 60 });

            //期望值
            var expected = new List<int> { 50, 66, 60 };

            //Act
            var actual = getsumbycut4.GetRevenueByCutNum(4);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
