using HashidsNet;
using System;

namespace CodHash
{
    public class ObterHash
    {
        public ObterHash()
        {
            this.hashID = Guid.NewGuid().ToString();
        }
        public string hashID{get; set;}
        public string hashCode{get; set;}
        public int nonHashCode{get; set;}
        public ObterHash CriarComando(int number)
        {
            int outPositive =  Math.Abs(number); // Trunca o negativo e retorna número em módulo
            var hashids = new Hashids("salt");
            var hash = hashids.Encode(outPositive);
            var hashDecode = hashids.DecodeSingle(hash);

            var comando = new ObterHash();
            hashCode = hash;
            nonHashCode = number; 

            return comando;
        }

        public static void Main(string [] args)
        {
            var teste = new ObterHash();
            teste.CriarComando(-10000);
            Console.WriteLine(teste.hashID); //485d271a-d061-4961-9f40-e28826a6256c
            Console.WriteLine(teste.hashCode); //O1Kj
            Console.WriteLine(teste.nonHashCode); // -10000
        }

    }
}
