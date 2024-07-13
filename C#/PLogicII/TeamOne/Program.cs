namespace TeamOne;

class Program
{
    static void Main(string[] args)
    {
        double note_one_user;
        double note_two_user;
        double def_two_notes;
        double necessary_note;
        bool flag = true;

        while (flag == true)
        {

            Console.Write("Ingrese la nota del 1er corte (Ej: 4.2): ");
            Double.TryParse(Console.ReadLine(), out note_one_user);

            if (note_one_user >= 0.0 && note_one_user <= 5.0)
            {
                Console.Write("Ingrese la nota del 2do corte (Ej: 4.2): ");
                Double.TryParse(Console.ReadLine(), out note_two_user);

                if (note_two_user >= 0.0 && note_two_user <= 5.0)
                {
                    
                    def_two_notes = Math.Round((note_one_user * 0.35) + (note_two_user * 0.35), 1);
                    Console.WriteLine($"\nEn definitiva llevas {def_two_notes} en los dos cortes.");

                    if (def_two_notes < 3.0)
                    {
                        necessary_note = Math.Round(((3.0 - def_two_notes) / 0.30),1);
                        Console.WriteLine($"Para pasar el curso necesita un {necessary_note} en el 3er corte.");
                        Console.Write("\nPresione Enter para salir...");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                        while (keyInfo.Key != ConsoleKey.Enter)
                        {
                            Console.Write("\nPresione Enter para salir...");
                            keyInfo = Console.ReadKey(true);
                        }
                        Console.Clear();
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Felicitaciones!\nAprobaste el curso con los dos primeros cortes.");
                        Console.Write("\nPresione Enter para salir...");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                        while (keyInfo.Key != ConsoleKey.Enter)
                        {
                            Console.Write("\nPresione Enter para salir...");
                            keyInfo = Console.ReadKey(true);
                        }
                        Console.Clear();
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("\n¡La nota ingresada no es válida!");
                            Console.Write("Presione Enter para reiniciar...");
                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                            while(keyInfo.Key != ConsoleKey.Enter)
                            {
                                Console.Write("\nPresione Enter para reiniciar...");
                                keyInfo = Console.ReadKey(true);
                            }
                            Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("\n¡La nota ingresada no es válida!");
                Console.Write("Presione Enter para reiniciar...");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                while(keyInfo.Key != ConsoleKey.Enter)
                {
                    Console.Write("\nPresione Enter para reiniciar...");
                    keyInfo = Console.ReadKey(true);
                }
                Console.Clear();
            }
        }
    }
}
