using System;
///This is the Director who controls the sequence of the play. 
namespace Unit03.Game
{
    public class Director
    {
        private bool isPlaying = true;
        private WordBank _wordBank = new WordBank();
        private Jumper _jumper = new Jumper();

        public Director()
        {
        }
        public void StartGame()
        {  
            int life = 5;

            string word = _wordBank.Words();
            string[] parachute = _jumper.DisplayParachute();
            string[] gameOver = _jumper.GameOver();
            string[] hint = _jumper.Hint();

            while (isPlaying)
            {                
                Display(hint,parachute);
                string letter = GetInputs();
                hint = DoUpdates(letter,hint,word);
                life = DoUpdatesLife(letter,word,life);
                parachute = DoUpdatesParachute(letter,word,life,parachute);
                
                if (life <= 0){
                    isPlaying = false;
                }

                int counter = 0;
                foreach (string i in hint){
                    int control = i.IndexOf("_");
                    if (control<0){
                        counter +=1;
                    } 
                };
                if (counter == 5){
                    isPlaying = false;                    
                }
            }
            foreach (string i in gameOver){
                Console.Write($"\n{i}");}
            Console.Write("\nThanks for playing!! ");

        }
///A funtion to display the the hint and the parachute.
        public void Display(string[] hint, string[] parachute)
        {
            foreach (string i in hint){
                Console.Write(i);
            }                    
            Console.Write("\n");
            foreach (string i in parachute){
                Console.Write($"\n{i}"); 
            }
        }
///A function to get a letter input from the user. 

        public string GetInputs()
        {
            Console.Write("\n");
            Console.Write("\nGuess the letter [a-z]: ");
            string input = Console.ReadLine();
            return input;        
        }
///A function if the player guessed the correct letter. 
        private string[] DoUpdates(string letter, string[] hint, string word)
        {
            int control = word.IndexOf(letter);

            if (control >= 0){
            hint[control] = letter;
           }
///Here we will update the life to see if the player can continue with the game. 
           return hint;
        }
        private int DoUpdatesLife(string letter,string word, int life)
        {
            int control = word.IndexOf(letter);

            if (control < 0){
                life-=1;
            }
           return life;
        }
///Here we will update the parachute if the player did not get the right answer. 

        private string[] DoUpdatesParachute(string letter,string word, int life, string[] parachute)
        {
            int control = word.IndexOf(letter);

            if (control < 0){
                int index = (5 - life) - 1;
                parachute[index] = "";
            }
           return parachute;
        }
    }
}