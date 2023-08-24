// Lista de Exercícios em C# no 1.0

// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.

using System;

namespace exerciciosLista{

public class atividade01{

    static void Main(string[] args){

        Console.WriteLine("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O número digitado foi: " + numero);
        }
    }
}