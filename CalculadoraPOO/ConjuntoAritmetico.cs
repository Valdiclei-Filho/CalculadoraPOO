namespace CalculadoraPOO
{
    public class ConjuntoAritmetico
    {
        public float Somar(float valor1, float valor2)
        {
            float totalSoma = valor1 + valor2;
            return totalSoma;
        }

        public float Subtracao(float valor1, float valor2)
        {
            float totalSubtracao =  valor1 - valor2;
            return totalSubtracao;
        }

        public float Divisao(float valor1, float valor2)
        {
            float totalDivisao = valor1 / valor2;
            return totalDivisao;
        }

        public float Multiplicacao(float valor1, float valor2)
        {
            float totalMultiplicacao = valor1 * valor2;
            return totalMultiplicacao; 
        }

       public void Historico(List<string> historico)
       {
            foreach (var item in historico)
            {
                Console.WriteLine(item);
            }
       } 
    }
}
