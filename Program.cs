using System;

//Napisz program, który za pomocą instrukcji do ... while wyświetla liczby całkowite z przedziału od 1 do 20 podniesione do kwadratu.
//Wynik obliczeń wyświetl w konsoli.

class PetlaDoWhile {
    static void Main(string[] args)
    {
        int number = 1;
        do
        {
            int square = number * number;
            Console.WriteLine($"Liczba {number} podniesiona do kwadratu to: {square}.");
            number++;
        } while (number <= 20);
    }
}