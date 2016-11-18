using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerGameGUI
{
    class FarmerGame
    {
        public enum Direction
        {
            north,
            south
        }

        List<string> northBank;
        List<string> southBank;
        Direction farmer;

        public FarmerGame()
        {
            northBank = new List<string>();
            southBank = new List<string>();
            farmer = Direction.north;
            northBank.Add("CHICKEN");
            northBank.Add("GRAIN");
            northBank.Add("FOX");
        }

        public void Move(string choice)
        {
            bool result;

            if (farmer == Direction.north)
            {
                result = northBank.Remove(choice);
                if (result == true)
                    southBank.Add(choice);
                farmer = Direction.south;
            }
            else
            {
                result = southBank.Remove(choice);
                if (result == true)
                    northBank.Add(choice);

                farmer = Direction.north;
            }
        }

        public bool AnimalAteFood()
        {
            bool foodEaten = false;

            if (farmer == Direction.south)
            {
                if (northBank.Contains("CHICKEN") == true && northBank.Contains("FOX") == true)
                {
                    foodEaten = true;
                }
                else if (northBank.Contains("CHICKEN") == true && northBank.Contains("GRAIN") == true)
                {
                    foodEaten = true;
                }
            }

            else
            {
                if (southBank.Contains("CHICKEN") == true && southBank.Contains("FOX") == true)
                {
                    foodEaten = true;
                }
                else if (southBank.Contains("CHICKEN") == true && southBank.Contains("GRAIN") == true)
                {
                    foodEaten = true;
                }
            }

            return foodEaten;
        }

        public bool DetermineWin()
        {
            bool win = false;

            if (farmer == Direction.south)
            {

                if (southBank.Contains("CHICKEN") == true && southBank.Contains("FOX") == true && southBank.Contains("GRAIN") == true)
                {
                    win = true;
                }
            }

            return win;
        }

        public bool GameOver(bool userWon)
        {
            bool finalStatus = false;

            if (userWon == true)
            {
                finalStatus = true;
            }

            else if (AnimalAteFood() == true)
            {
                finalStatus = false;
            }

            return finalStatus;
        }

        public Direction Farmer
        {
            get { return farmer; }
        }

        public List<string> NorthBank
        {
            get { return northBank; }
        }

        public List<string> SouthBank
        {
            get { return southBank; }
        }
    }
}
