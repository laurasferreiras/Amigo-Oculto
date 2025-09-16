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
        public void TestSortear()
        {
            var pessoas = new List<string> { "Laura", "Bruna", "Julia", "Carlos", "Gabriel" };
            GerenciadorSorteio gerenciadorSorteio = new GerenciadorSorteio();

            gerenciadorSorteio.RealizandoSorteio(pessoas);

            Assert.IsTrue(gerenciadorSorteio.SorteioRealizado, "Não foi realizado");

            var sorteados = new Dictionary<string, string>();

            foreach (var pessoa in pessoas)
            {
                string amigo = gerenciadorSorteio.ObterAmigoSorteado(pessoa);
                Assert.AreNotEqual(pessoa, amigo, $"Pessoa {pessoa} sorteou ela mesma.");
                sorteados[pessoa] = amigo;
            }
            foreach (var dupla in sorteados)
            {
                string pessoa = dupla.Key;
                string amigo = dupla.Value;
                if (sorteados.ContainsKey(amigo))
                {
                    Assert.AreNotEqual(pessoa, sorteados[amigo], $"Par correlacionado encontrado entre {pessoa} e {amigo}.");
                }
            }

        }
    }
}
