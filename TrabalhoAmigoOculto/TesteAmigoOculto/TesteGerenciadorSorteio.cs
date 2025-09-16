using TrabalhoAmigoOculto.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.Arm;

namespace TesteAmigoOculto
{
    [TestClass]
    public class TesteGerenciadorSorteio
    {
        [TestMethod]
        public void TestSortearSemRepeticao()
        {
            var pessoas = new List<string>["Laura", "Bruna", "Julia", "Carlos", "Gabriel"];
            GerenciadorSorteio gerenciadorSorteio = new GerenciadorSorteio();

        }
    }
}
