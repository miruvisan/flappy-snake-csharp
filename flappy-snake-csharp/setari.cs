using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Atestat_Visan_Miruna_1
{
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };

    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    };

    class setari
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; } 
        public static int Score { get; set; } 
        public static int Points { get; set; } 
        public static bool GameOver { get; set; } 
        public static Directions direction { get; set; }
        public static DifficultyLevel Difficulty { get; set; }

        public setari()
        {
            Width = 16; 
            Height = 16; 
            Speed = 20; 
            Score = 0; 
            Points = 100; 
            GameOver = false; 
            direction = 0;
            Difficulty = DifficultyLevel.Medium;
            ApplyDifficulty();
        }

        public static void ApplyDifficulty()
        {
            switch (Difficulty)
            {
                case DifficultyLevel.Easy:
                    Speed = 15;
                    Points = 150;
                    break;
                case DifficultyLevel.Medium:
                    Speed = 20;
                    Points = 100;
                    break;
                case DifficultyLevel.Hard:
                    Speed = 30;
                    Points = 50;
                    break;
            }
        }
    }
}