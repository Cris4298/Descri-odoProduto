using System;

class Program {
  public static void Main (string[] args) {
   //Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que: - Se quantidade <= 5 o desconto será de 2% - Se quantidade > 5 e quantidade <=10 o desconto será de 3% - Se quantidade > 10 o desconto será de 5%


String entrada, produto;
int quantidade;
Double preco, total, desc_menor_5,  desc_menor_10,    desc_maior_10, desconto;

     desc_menor_5 = 0.02;
     desc_menor_10 = 0.03;
     desc_maior_10 = 0.05;
    desconto = 0.0;

    Console.Write(" produto :");
  produto = Console.ReadLine();


     Console.Write(" Quantidadde :");
  entrada = Console.ReadLine();
  quantidade = int.Parse(entrada); 

      Console.Write(" valor do produto :");
  entrada = Console.ReadLine();
  preco = Double.Parse(entrada);

    total = quantidade * preco;

//calculando o desconto
    if (quantidade <= 5)
    {
      desconto = total * desc_menor_5;
    }
// calculando o desconto  

      if (quantidade > 10)
    {
      desconto = total * desc_menor_10;
    }
 // calculando o desconto  
    
      if (quantidade > 10)
    {
      desconto = total * desc_maior_10;
    }

    Console.WriteLine(" PRODUTO :" + preco);
    
    Console.WriteLine(" preço unidade :" + preco);
    Console.WriteLine(" Total :" + preco);
    
    Console.WriteLine(" Total :" + total);
    
    Console.WriteLine(" desconto :" + desconto);
    
    Console.WriteLine(" valor a pagar :" + total + desconto);

  }
}