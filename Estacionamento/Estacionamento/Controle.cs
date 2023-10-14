namespace Estacionamento
{
    public class Controle
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        public List<string> veiculos = new List<string>();

        public Controle(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo que deseja estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo que será removido: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = (precoInicial + precoHora) * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                
            }

            else
            {
                Console.WriteLine("Desculpe, o veículo informado não foi encontrado.");
            }
            Console.ReadKey();
        }

        public void ListarVeiculo()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //foreach (var veiculo in veiculos)

                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"Cliente Nº {i} - {veiculos[i]}");
                    
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            Console.ReadKey();

        }
    }
}
