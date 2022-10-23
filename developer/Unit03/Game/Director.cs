using System;
///This is the program that unify all the classes in our game.  
namespace Unit03.Game
{
    public class Director
    {


        public Director()
        {
        }
        public void StartGame()
        {
            bool isPlaying = true;
            int life = 5;
            WordBank _wordBank = new WordBank();
            string word = _wordBank.Words();
            Jumper _jumper = new Jumper();
            string[] parachute = _jumper.DisplayParachute();
            string[] gameOver = _jumper.GameOver();
            string[] hint = _jumper.Hint();

            while (isPlaying)
            {                
                Display(hint,parachute);
                string letter = GetInputs();
                hint = DoUpdates(letter,hint,word);
                life = DoUpdatesLife(letter,word,life);
                parachute = DoUpdatesMen(letter,word,life,parachute);
                
                if (life <= 0){
                    isPlaying = false;
                }

                int contador = 0;
                foreach (string i in hint){
                    int control = i.IndexOf("_");
                    if (control<0){
                        contador +=1;
                    } 
                };
                if (contador == 4){
                    isPlaying = false;                    
                }
            }
            foreach (string i in gameOver){
                Console.Write($"\n{i}");}
            Console.Write("\n^^^^^^^^^^^^");
            Console.Write("\nThanks for playing!! ");

        }
///This is funtion will help us to show the board of our game. 
        public void Display(string[] space, string[] men)
        {
            foreach (string i in space){
                Console.Write(i);
            }                    
            Console.Write("\n");
            foreach (string i in men){
                Console.Write($"\n{i}"); 
            }
            Console.Write("\n^^^^^^^^^^^^");
        }
///This is funtion will help us to take the letter that the player typped.

        public string GetInputs()
        {
            Console.Write("\n");
            Console.Write("\nGuess the letter [a-z]: ");
            string input = Console.ReadLine();
            return input;        
        }
///Here we will update the word, we will se if the player guess correctly and we will change some values.  
        private string[] DoUpdates(string letter, string[] space, string word)
        {
            int control = word.IndexOf(letter);

            if (control >= 0){
            space[control] = letter;
           }
///Here we will update the life to see if the player can continue with the game. 
           return space;
        }
        private int DoUpdatesLife(string letter,string word, int life)
        {
            int control = word.IndexOf(letter);

            if (control < 0){
                life-=1;
            }
           return life;
        }
///Here we will change the men if the player did not get the right answer. 

        private string[] DoUpdatesMen(string letter,string word, int life, string[] men)
        {
            int control = word.IndexOf(letter);

            if (control < 0){
                int index = (5 - life) - 1;
                men[index] = "";
            }
           return men;
        }
    }
}