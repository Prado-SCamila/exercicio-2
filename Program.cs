using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha A para Alcool e G para Gasolina");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de combustível");
            float quantidade = float.Parse(Console.ReadLine());

           float precoAlcool = 4.9f;
           float precoGasolina= 5.3f;
           float precoAlcool1 = 0.05f;
           float precoAlcool2 = 0.03f;
           float precoGasolina1 = 0.06f;
           float precoGasolina2 = 0.04f;
           float retornoDesconto;

           switch(combustivel.ToLower()){
               case "a": 
               ExibirValorPago(AplicarDesconto(quantidade,precoAlcool,precoAlcool1,precoAlcool2));
               break;

               case "g": 
               ExibirValorPago(AplicarDesconto(quantidade, precoGasolina, precoGasolina1,precoGasolina2));
                break;

                default:
                Console.WriteLine("Opção Inválida");
                break;
           }
           float AplicarDesconto(float litros, float preco, float perc1, float perc2){
               if(litros>20){
                   float valorTotal = litros * preco;
                   float desconto = (litros *preco)* perc1;
                   retornoDesconto =valorTotal - desconto;
                   return retornoDesconto;
               }else{
                   float valorTotal = litros * preco;
                   float desconto = (litros *preco)* perc2;
                   retornoDesconto =valorTotal - desconto;
                   return retornoDesconto;
               }
             
               }
                void ExibirValorPago(float valor){
                Console.WriteLine($"O valor total a ser pago é: {valor}");
           }

        }
    }
}
