using System;
namespace exerciciosLista{
	
	public class atividade03{
    	public static void Main(string[] args){
		
			Console.WriteLine("Informe o Ano do seu Nascimento:");
			int ano = Convert.ToInt32(Console.ReadLine());	
			
			int currentYear= DateTime.Now.Year;
			
			int idade = currentYear - ano;
			
			Console.WriteLine("Vocẽ tem "+ age +"Anos");
		}
	}
}