// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static string Encrypt(string plainText, int key)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        plainText = plainText.ToLower();
        char[] P_TEXT = plainText.ToCharArray();
        char[] Cipher_TEXT = new char[P_TEXT.Length];
        for (int i = 0; i < P_TEXT.Length; i++)
        {
            char Plain_char = P_TEXT[i];
            int index = Array.IndexOf(alphabet, Plain_char);
            int cipher_char_position = (index + key) % 26;
            char cipher_char = alphabet[cipher_char_position];
            Cipher_TEXT[i] = cipher_char;
        }
        return new string(Cipher_TEXT);
    }
    public static string Decrypt(string cipherText, int key)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        cipherText = cipherText.ToLower();
        char[] C_TEXT = cipherText.ToCharArray();
        char[] Plain_TEXT = new char[C_TEXT.Length];
        for (int i = 0; i < C_TEXT.Length; i++)
        {
            char Cipher_char = C_TEXT[i];
            int index = Array.IndexOf(alphabet, Cipher_char);
            int Plain_char_position = (index - key) % 26;
            if (Plain_char_position < 0)
                Plain_char_position = 26 + Plain_char_position;
            char Plain_char = alphabet[Plain_char_position];
            Plain_TEXT[i] = Plain_char;
        }
        return new string(Plain_TEXT);
    }
    public static int Analyse(string plainText, string cipherText)
    {
        int p = (int)plainText[0];
        int c = (int)cipherText[0];
        if (c - p < 0)
            return 26 + (c - p);
        return c - p;

    }
    public static void Main(string[] args)
    {
        bool flag = true;
        do
        {
            Console.WriteLine("Type '1' For Encryption ");
            Console.WriteLine("Type '2' For Decryption ");
            Console.WriteLine("Type '3' Fro Analysis");
            Console.Write("enter your Choice: ");
            string Choice;
            Choice = Console.ReadLine();
            if (Choice == "1")
            {
                Console.Write("Enter message you want to encrypt : ");
                string Message = Console.ReadLine();
                Console.Write("Enter The Key : ");
                int key = Console.Read();
                Console.WriteLine("Your Cipher Text is : {0}", Encrypt(Message, key));
            }
            else if (Choice == "2")
            {
                Console.WriteLine("Enter message you want to Decrypt : ");
                string Message = Console.ReadLine();
                Console.WriteLine("Enter The Key : ");
                int key = Console.Read();
                Console.WriteLine("Your Plain Text is : {0}", Decrypt(Message, key));
            }
            else if (Choice == "3")
            {
                Console.WriteLine("Enter PlainText  : ");
                string Plain = Console.ReadLine();
                Console.WriteLine("Enter CipherText : ");
                string Cipher = Console.ReadLine();
                Console.WriteLine("KEY is : {0}", Analyse(Plain, Cipher));
            }
            else
            {
                Console.WriteLine("Inccorrect Choice :) ");

            }
            Console.Write("Do you wnat to run program again Y/N : ");
            string x;
            x = Console.ReadLine();
            x = Console.ReadLine();
            if (x == "N" || x == "n")
                flag = false ;
        } while (flag == true);
       
    }
}
