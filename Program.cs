using System;

// Code for password verifier

namespace password
{
    class PasswordVerifier
    {
        static void LengthCheck(string password)
        {
            if (password.Length == 0)
            {
                Console.WriteLine("the password is null");
                System.Environment.Exit(1);
            }
            else if (password.Length <= 8)
            {
                Console.WriteLine("the size of password should be greater than 8 characters");
                System.Environment.Exit(1);
            }
        }

        static void UpperCase(string password)
        {
            int uppercasecounter = 0;
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    uppercasecounter++;
                }
            }

            if (uppercasecounter == 0)
            {
                Console.WriteLine("no uppercase found");
                System.Environment.Exit(1);

            }
        }
        static void LowerCase(string password)
        {
            int lowercasecounter = 0;
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    lowercasecounter++;
                }
            }

            if (lowercasecounter == 0)
            {
                Console.WriteLine("no lowercase found");
                System.Environment.Exit(1);

            }

        }
        static void ContainsNumber(string password)
        {
            int numbercounter = 0;
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    numbercounter++;
                }
            }

            if (numbercounter == 0)
            {
                Console.WriteLine("there are no digits in the password");
                System.Environment.Exit(1);
            }
        }

        static void Main(string[] args)
        {
            string password = "HFLWHE547a";
            LengthCheck(password);
            UpperCase(password);
            LowerCase(password);
            ContainsNumber(password);
            Console.WriteLine("Congratulations password is successfully created");
        }


    }
}
