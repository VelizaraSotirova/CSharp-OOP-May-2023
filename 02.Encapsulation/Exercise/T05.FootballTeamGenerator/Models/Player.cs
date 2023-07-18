using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private const int StatMin = 0;
        private const int StatMax = 100;


        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public int Endurance
        {
            get { return endurance; }
            set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get { return sprint; }
            set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException($"{nameof(Sprint)} should not be empty.");
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get { return dribble; }
            set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException($"{nameof(Dribble)} should not be empty.");
                }
                dribble = value;
            }
        }
        public int Passing
        {
            get { return passing; }
            set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException($"{nameof(Passing)} should not be empty.");
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get { return shooting; }
            set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException($"{nameof(Shooting)} should not be empty.");
                }
                shooting = value;
            }
        }

        public double Stats => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;

        private bool CheckStatValue(int value) => value < StatMin || value > StatMax;
    }
}
