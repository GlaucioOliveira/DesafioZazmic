using DesafioZazmic.Util.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DesafioZazmic.Test.algorithm
{
    [TestClass]
    public class NStairAlgorithmTest
    {

        [TestMethod]
        public void TestarQuatroDegraus()
        {
            int degraus = 4;

            var possibilidadesExperada = new List<string>
            {
                "1111",
                "112",
                "121",
                "211",
                "22"
            };

            var possibilidadesAlgoritmo = NStairAlgorithm.listarPossibilidadesSubida(degraus);

            Assert.IsTrue(
                possibilidadesExperada.All(x => possibilidadesAlgoritmo.Contains(x))
                );
        }
    }
}
