namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            {
                //detta gör så att specialtecknen kan visas när man kör konsol.
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("Ange storlek på chackbrädan:");

                //läser inn text input och gör det om till ett heltal.
                string text = Console.ReadLine();
                int number = int.Parse(text);

                //detta är en loop som går igjennom varje rad från top till botten.
                for (int rad = 0; rad < number; rad++)
                {
                    //och detta är en loop som går igenom varje rad från vänster till höger.
                    for (int kolumn = 0; kolumn < number; kolumn++)
                    {
                        //om rad och kolumn är jämna så blir det vit ruta annars blir det svart ruta. 
                        if ((rad + kolumn) % 2 == 0)
                        {
                            Console.Write("◻︎");
                        }
                        else
                        {
                            Console.Write("◼︎");
                        }
                    }
                     Console.WriteLine();
                }
            }

        }
    }
}
