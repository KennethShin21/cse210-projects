namespace Jumper
///This class is the class that call the code and makes our code funtion with main. 
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}
