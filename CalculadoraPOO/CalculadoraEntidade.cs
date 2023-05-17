namespace CalculadoraPOO
{
    public class CalculadoraEntidade
    {
        public List<string> Historico { get; set; } = new List<string>();

        public float Somar(float valor1, float valor2)
        {
            float total = valor1 + valor2;
            Historico.Add($"{valor1} + {valor2} = {total}");
            return total;
        }

        public float Subtracao(float valor1, float valor2)
        {
            float total =  valor1 - valor2;
            Historico.Add($"{valor1} - {valor2} = {total}");
            return total;
        }

        public float Divisao(float valor1, float valor2)
        {
            float total = valor1 / valor2;
            Historico.Add($"{valor1} / {valor2} = {total}");
            return total;
        }

        public float Multiplicacao(float valor1, float valor2)
        {
            float total = valor1 * valor2;
            Historico.Add($"{valor1} * {valor2} = {total}");
            return total; 
        }

       public void VerHistorico()
       {
            foreach (var item in Historico)
            {
                Console.WriteLine(item);
            }
       } 
    }
}
