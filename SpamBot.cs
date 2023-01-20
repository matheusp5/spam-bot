using System;
using System.Text;
using System.Drawing;
using WindowsInput;
using WindowsInput.Native;

namespace EuTeAmoBot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                InputSimulator sim = new InputSimulator();
                Console.WriteLine("Qual mensagem você deseja enviar?");
                string mensage = Console.ReadLine();
                Console.WriteLine("Quantas vezes deseja enviar?");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Tudo pronto? [Y/N]");
                string respond = Console.ReadLine();
                if (respond.Equals("Y"))
                {
                    sim.Keyboard.Sleep(5000);
                    int l;
                    for (l = 1; l <= quantity; l++)
                    {
                        sim.Keyboard.Sleep(100);
                        string frase = $"{mensage}";
                        Console.WriteLine($"{l}º - Enviado com sucesso!");
                        sim.Keyboard.TextEntry(frase);
                        sim.Keyboard.KeyPress(new VirtualKeyCode[] { VirtualKeyCode.RETURN });
                    }
                }
                else if (respond.Equals("N"))
                {
                    Console.WriteLine("Ok...");
                }
                else if (respond != "Y" || respond != "N")
                {
                    Console.WriteLine("Por favor, responda com Y ou N");
                }

            }
        }
    }
}
