namespace Villa_API.logging
{
    public class Logging: ILogging
    {
        public void Log(string message, string type)
        {
           if (type == "error")
           {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.Write("ERROR: ");
               Console.ResetColor(); // Сброс цвета обратно к стандартному
               Console.Write(message);
           }
           else
           {
               Console.Write(message);
           }
        }

    }
}
