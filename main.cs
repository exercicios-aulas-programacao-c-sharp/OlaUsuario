using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite seu nome:\t");
    String nome = Console.ReadLine();
    Console.WriteLine($"Olá, {nome}");
  }
}