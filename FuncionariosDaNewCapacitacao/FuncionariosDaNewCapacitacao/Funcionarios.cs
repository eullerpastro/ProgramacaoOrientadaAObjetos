using System.Globalization;

namespace FuncionariosDaNewCapacitacao
{
    internal class Funcionarios
    {
        public string Nome;
        public int Idade;
        public string Funcao;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AdicionarImposto(double imp)
        {
            Imposto += imp;
        }


        public void RemoverImposto(double imp)
        {
            Imposto -= imp;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido();
        }
    }  
}
