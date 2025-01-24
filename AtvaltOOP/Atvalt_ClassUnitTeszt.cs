using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtvaltasOOP;


namespace AtvaltOOP_UnitTeszt
{
    [TestClass]
    public class Atvalt_ClassUnitTeszt
    {
        Atvalt atvalt = new Atvalt();

        [TestMethod]
        public void isDecimal_True()
        {
            string szoveg = "21";
            bool vartEredm = true,
            kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void isDecimal_False()
        {
            string szoveg = "2.1";
            bool vartEredm = false,
            kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void isBinaris_True()
        {
            string szoveg = "100101";
            bool vartEredm = true,
            kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void isBinaris_False()
        {
            string szoveg = "999";
            bool vartEredm = true,
            kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
