using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash hash = new Hash();
            HmacHash hmac = new HmacHash();
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Which algorithm whould you like to use:");
            Console.WriteLine("(1) SHA1");
            Console.WriteLine("(2) SHA256");
            Console.WriteLine("(3) MD5");
            Console.WriteLine("(4) HMAC verification");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert message to be hashed:");
            string hashMessage = Console.ReadLine();

            //switch case for choosing which hashing algorithm to use
            switch (input)
            {
                case 1:
                    Console.WriteLine("Your hash message: " + hashMessage);
                    stopwatch.Start();
                    Console.WriteLine("\nYour hashed SHA1 message with ASCII: " + Convert.ToBase64String(hash.ComputeHashSha1(Encoding.ASCII.GetBytes(hashMessage))));
                    stopwatch.Stop();
                    Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds.ToString());
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Your hash message: " + hashMessage);
                    stopwatch.Start();
                    Console.WriteLine("\nYour hashed SHA256 message with ASCII: " + Convert.ToBase64String(hash.ComputeHashSha256(Encoding.ASCII.GetBytes(hashMessage))));
                    stopwatch.Stop();
                    Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds.ToString());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Your hash message: " + hashMessage);
                    stopwatch.Start();
                    Console.WriteLine("\nYour hashed MD5 message with ASCII: " + Convert.ToBase64String(hash.ComputeHashMd5(Encoding.ASCII.GetBytes(hashMessage))));
                    stopwatch.Stop();
                    Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds.ToString());
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Which hash would you like to generate:");
                    Console.WriteLine("(1) SHA1");
                    Console.WriteLine("(2) SHA256");
                    Console.WriteLine("(3) MD5");
                    int hmacInput = int.Parse(Console.ReadLine());
                    byte[] key = hmac.GenerateHMACKey();
                    //If HMAC is chosen, this switch case is used to choose which algorithm to use with HMAC
                    switch (hmacInput)
                    {
                        case 1:
                            Console.WriteLine("Your hash message: " + hashMessage);
                            stopwatch.Start();
                            Console.WriteLine("Your hashed HMAC SHA1 message: " + Convert.ToBase64String(hmac.ComputeHashHmacSha1(Encoding.ASCII.GetBytes(hashMessage), key)));
                            stopwatch.Stop();
                            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds.ToString());
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Your hash message: " + hashMessage);
                            stopwatch.Start();
                            Console.WriteLine("Your hashed HMAC SHA256 message: " + Convert.ToBase64String(hmac.ComputeHashHmacSha256(Encoding.ASCII.GetBytes(hashMessage), key)));
                            stopwatch.Stop();
                            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds.ToString());
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Your hash message: " + hashMessage);
                            stopwatch.Start();
                            Console.WriteLine("Your hashed HMAC MD5 message: " + Convert.ToBase64String(hmac.ComputeHashHmacMd5(Encoding.ASCII.GetBytes(hashMessage), key)));
                            stopwatch.Stop();
                            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds.ToString());
                            Console.ReadKey();

                            break;
                        default:
                            Console.WriteLine("incorret input");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Wrong key input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
