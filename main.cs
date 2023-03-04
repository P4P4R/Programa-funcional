using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var listaFiltrada = lista.Where(x => x % 2 == 0).ToList();

        var listaMapeada = listaFiltrada.Select(x => x * 2).ToList();

        var resultado = listaMapeada.Aggregate((a, b) => a + b);

        Console.WriteLine($"Resultado: {resultado}");
    }
}
