using System;
using System.Collections.Generic;
using CSE210_Greed.Game.Casting;
///using cse210_greed.Game.Directing;
using CSE210_Greed.Game.Services;
/// possible phrases of diologue 
/// 'hit by a rock' = Ouch, Oh no!, I need to miss that!, That hurt!
/// 'gets a gem' = Yay!, I'm rich!, Whoo hoo!, 

namespace CSE210_Greed.Game.Casting
{
       public class Mineral : Actor 
       {  
              /// Mineral will inherit all of the code and methods created in actor to be used here
              private string message = " ";
              private int fallSpeed = 0;   /// setting all of our private variables to be returned later
              private int pointValue = 0;
              Random random = new Random();    /// this new method in artifact calculates the speed of on coming rocks and gems




              public void SetFallSpeed(int cap)
              {  
                     fallSpeed = random.Next(0, cap); /// and gives it a random value from 1 to what ever cap is mentioned in cast
       
              }

              public int GetFallSpeed()
              { ///makes fallspeed usable
                     return fallSpeed;   
              }

              public Mineral() /// Constructor
              {
              }

              public void SetPointValue(string type)
              {  /// if player collides with gem then they get rewarded 10 points
              if (type == "gem" )
              {pointValue = 10;}
              else if (type == "rock")    /// if player collides with rock then they get deducked 10 points
              {pointValue = -10;}
 }

              public int GetPointValue()
              { /// makes pointvalue usable
              return pointValue;
              }
              public void SetMessage(string type)
              {
              if (type == "rock" )
              {
                     List<string> rockMessage = new List<string>();   ///We will have a message display if they hit a rock and these wil be chosen at random to be displayed

                     rockMessage.Add("Ouch!");
                     rockMessage.Add("Oh no!");
                     rockMessage.Add("I need to miss that!");
                     rockMessage.Add("That hurt!");
                     rockMessage.Add("Oowwww!");
                     rockMessage.Add("That hurt me a lot!");
                     rockMessage.Add("I'm gonna lose this!");
                     rockMessage.Add("Do better please!");
                     int newMessage = random.Next(rockMessage.Count);
                     message = rockMessage[newMessage]; /// sets message to get random phrase from hitting a rock
              }
              else if (type == "gem")
              {
                     List<string> gemMessage = new List<string>();   ///We will have a message display if they hit a gem and these wil be chosen at random to be displayed

                     gemMessage.Add("Yay!");
                     gemMessage.Add("I'm rich!");
                     gemMessage.Add("Whoo hoo!");
                     gemMessage.Add("I'm gonna buy a big house with this!");
                     gemMessage.Add("I'm going to invest this and get rich!");
                     gemMessage.Add("Going to buy a new iPhone!");
                     int newMessage = random.Next(gemMessage.Count);
                     message = gemMessage[newMessage];  /// sets message to get random phrase from collecting a gem
              }
              else
              {
                     Console.WriteLine("Invalid or no keyword for SetMessage() method");
              }
}
  
  



 
 public string GetMessage(){
        return message;  /// makes getting a message possible
 }
  
}
}


