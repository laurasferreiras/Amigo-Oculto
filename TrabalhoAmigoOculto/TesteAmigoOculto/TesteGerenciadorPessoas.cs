using TrabalhoAmigoOculto.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAmigoOculto
{
    [TestClass]
    public class TesteGerenciadorPessoas
    {
        [TestMethod]
        public void TestGerenciadorPessoa()
        {
            GerenciadorPessoas gerenciadorPessoas = new GerenciadorPessoas();
            string nome = "Laura";

            gerenciadorPessoas.AdicionarPessoa(nome);

            bool existe = gerenciadorPessoas.ObterPessoas().Contains(nome);
            Assert.IsTrue(existe, "Foi adicionado");
        }
    }
}
