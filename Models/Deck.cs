using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using codenames.Models;
using System.Linq;
 
namespace codenames.Models
{
    public class Deck
    {
        public List<Card> Cards;
        public string[] Colors = {"red", "red", "red","red", "red","red","red","red",
                                    "blue","blue","blue","blue","blue","blue","blue","blue",
                                    "black",
                                    "white","white","white", "white", "white","white","white",
                                    "replace"};
        public Deck(string startColor){
            Cards = new List<Card>();
            Colors[24] = startColor;
            Colors = Shuffle(Colors);
            Load();
        }

        public string[] Shuffle(string[] Colors){
            Random rand = new Random();
            int m = 25;
                while(m>0)
            {
                m--;
                int i = rand.Next(m);
                string temp = Colors[m];
                Colors[m] = Colors[i];
                Colors[i] = temp;
                }
            return Colors; 
        }
        public void Load(){
            Random rand = new Random();
            Word allWords = new Word();
            string[] deckWords = new string[25]; 
            for (var i=0;i<25;i++){
                int randIdx = rand.Next(allWords.words.Length);
                while(deckWords.Contains(allWords.words[randIdx])){
                    randIdx = rand.Next(allWords.words.Length);
                }
                deckWords[i] = allWords.words[randIdx];
            }
            for (var j=0;j<25;j++){
                Card newCard = new Card();
                newCard.CardId = j;
                newCard.Text = deckWords[j];
                newCard.Color = Colors[j];
                newCard.IsExposed = false;
                Cards.Add(newCard);
            }
        }
    }
}
