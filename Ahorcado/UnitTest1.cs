using NUnit.Framework;
using ClasesAhorcado;

namespace Ahorcado
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestNoRepite()
        {
            Juego j = new Juego("");
            j.LeerLetra('p');
            bool resultado = j.LeerLetra('p');
            Assert.AreEqual(false, resultado);
        }

        [Test]
        public void TestNoPertenece()
        {
            Juego j = new Juego("psicologo");
            Resultados b=j.verificar('�');

            Assert.AreEqual(Resultados.Error, b);
        }
        [Test]
        public void TestPertenece()
        {
            Juego j = new Juego("psicologo");
            Resultados b = j.verificar('p');

            Assert.AreEqual(Resultados.Acierto, b);
        }

        [Test]
        public void TestVidas()
        {
            Juego j = new Juego("psicologo");
            j.verificar('�');
            Assert.AreEqual(6, j.vidas);
        }
        [Test]
        public void TestJuegoPerdido()
        {
            Juego j = new Juego("psicologo");
            j.verificar('a');
            j.verificar('e');
            j.verificar('u');
            j.verificar('�');
            j.verificar('b');
            j.verificar('r');
            j.verificar('t');
            Assert.AreEqual(Resultados.Perdiste, j.ResultadoFinal);
        }
        [Test]
        public void TestJuegoPerdido2()
        {
            Juego j = new Juego("psicologo");
            j.verificar('a');
            j.verificar('e');
            j.verificar('u');
            j.verificar('�');
            j.verificar('b');
            j.verificar('r');
            j.verificar('w');
            j.verificar('t');
            Assert.AreEqual(Resultados.Perdiste, j.ResultadoFinal);
        }

        [Test]
        public void TestdeEstado()
        {
            Juego j = new Juego("skere");
            j.verificar('a');
            j.verificar('s');
            j.verificar('e');
            Assert.AreEqual("s_e_e".ToCharArray(), j.estado);
        }

        [Test]
        public void TestGana()
        {
            Juego j = new Juego("skere");
            j.verificar('a');
            j.verificar('s');
            j.verificar('e');
            j.verificar('r');
            j.verificar('k');
            Assert.AreEqual(Resultados.Ganaste, j.ResultadoFinal);
        }

        [Test]
        public void TestNuevoUsuario()
        {
            Usuario u = new Usuario();
            Assert.AreEqual(1,1);
        }
        [Test]
        public void TestcantUsuarios()
        {
            Mesa m = new Mesa();
            m.nuevoUsuario(new Usuario());
            m.nuevoUsuario(new Usuario());
            Assert.AreEqual(2, m.CantUsuarios);
        }

    }
}