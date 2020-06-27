using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Senac.Tests
{
    [TestClass]
    public class SenacTests{
        
        //---------------------------------------------Ex1--------------------------------------------//
        [TestMethod]
        public void CalcularArea_ValorCorreto(){
            string resultado;
            CalcularArea calculo = new CalcularArea();
            resultado = calculo.Calcular(2, 2);

            Assert.AreEqual("Resultado: 4", resultado);
        }
        //---------------------------------------------Ex2--------------------------------------------//
        [TestMethod]
        public void CalcularVolume_ValorCorreto(){
            string resultado;
            CalcularVolume calculo = new CalcularVolume();
            resultado = calculo.Calcular(2, 2, 2);

            Assert.AreEqual("Resultado: 8", resultado);
        }
        //---------------------------------------------Ex3--------------------------------------------//
        [TestMethod]
        public void CompararString_ValorCorreto(){
            bool resultado;
            CompararString comparar = new CompararString();
            resultado = comparar.Comparar("testes","testes");

            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void CompararString_ValorErrado(){
            bool resultado;
            CompararString comparar = new CompararString();
            resultado = comparar.Comparar("teste","testes");

            Assert.AreEqual(false, resultado);
        }
        //---------------------------------------------Ex4--------------------------------------------//
        /*[TestMethod]
        public void CompararString_ValorCorreto(){
            bool resultado;
            CompararString comparar = new CompararString();
            resultado = comparar.Comparar("testes","testes");

            Assert.AreEqual(true, resultado);
        }*/

        //---------------------------------------------Ex5--------------------------------------------//
        [TestMethod]
        public void MaiorQueDobro_ValorMaior(){
            bool resultado;
            MaiorQueDobro comparar = new MaiorQueDobro();
            resultado = comparar.Validar(2, 5);

            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void MaiorQueDobro_ValorMenor(){
            bool resultado;
            MaiorQueDobro comparar = new MaiorQueDobro();
            resultado = comparar.Validar(5, 2);

            Assert.AreEqual(false, resultado);
        }
        //---------------------------------------------Ex6--------------------------------------------//
        [TestMethod]
        public void MediaTresNumeros_MediaCerta(){
            string resultado;
            MediaTresNumeros calcular = new MediaTresNumeros();
            resultado = calcular.Calcular(5,6,7);

            Assert.AreEqual("Resultado: 6", resultado);
        }
        //---------------------------------------------Ex7--------------------------------------------//
        [TestMethod]
        public void ParOuImpar_ValorPar(){
            string resultado;
            ParOuImpar calcular = new ParOuImpar();
            resultado = calcular.Validar(6);

            Assert.AreEqual("Resultado: 6 é par", resultado);
        }
        [TestMethod]
        public void ParOuImpar_ValorImpar(){
            string resultado;
            ParOuImpar calcular = new ParOuImpar();
            resultado = calcular.Validar(7);

            Assert.AreEqual("Resultado: 7 é impar", resultado);
        }
        [TestMethod]
        public void ParOuImpar_ValorNegativo(){
            string resultado;
            ParOuImpar calcular = new ParOuImpar();
            resultado = calcular.Validar(-6);

            Assert.AreEqual("Resultado: -6 é negativo", resultado);
        }












        /*
        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void VerificaNome_RetornoFalse(string value){
            Usuario usuario = new Usuario();
            var resultado = usuario.VerificarNome(value);

            Assert.IsFalse(resultado);
        }
        */
    }
}
