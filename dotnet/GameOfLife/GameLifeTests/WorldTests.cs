using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameLifeTests
{
    [TestClass]
    public class WorldTests
    {
        [TestMethod]
        public void SizeOfWorldIsFiftyByFifty()
        {
            World worldHere = new World();
            Assert.AreEqual(50, worldHere.Height);
            Assert.AreEqual(50, worldHere.Width);
        }

        [TestMethod]
        public void CellIsAliveUponCreation()
        {
            Cell brandnewcell = new Cell();
            Assert.AreEqual(true, brandnewcell.Living);
        }
    }
}
