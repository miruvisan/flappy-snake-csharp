using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Atestat_Visan_Miruna_1
{

    public partial class frm_sarpe : Form
    {
        private List<cerc> snake = new List<cerc>();
        private cerc mancare = new cerc();

        public frm_sarpe()
        {
            InitializeComponent();
            new setari();
            gameTimer.Interval = 1000 / setari.Speed;
            gameTimer.Tick += updatescreen;
            gameTimer.Start();
            StartGame();
        }
        private void updatescreen(object sender, EventArgs e)
        {
            if (setari.GameOver != true)
            {
                if (input.KeyPress(Keys.Right) && setari.direction != Directions.Left)
                {
                    setari.direction = Directions.Right;
                }
                else if (input.KeyPress(Keys.Left) && setari.direction != Directions.Right)
                {
                    setari.direction = Directions.Left;
                }
                else if (input.KeyPress(Keys.Up) && setari.direction != Directions.Down)
                {
                    setari.direction = Directions.Up;
                }
                else if (input.KeyPress(Keys.Down) && setari.direction != Directions.Up)
                {
                    setari.direction = Directions.Down;
                }
                movePlayer();
            }
            else
            {
                gameTimer.Stop();

                // Incrementare joc jucat și update total points
                DatabaseInitializer.IncrementGamesPlayedSnake(username.user);
                DatabaseInitializer.UpdateTotalPoints(username.user, setari.Score);

                // Salveaza scorul in baza de date
                DatabaseInitializer.UpdateBestSnakeScore(username.user, setari.Score);

                // Actualizeaza scorul in clasa statica
                scorul.snake = setari.Score.ToString();

                var Result = MessageBox.Show($"Sarpele s-a lovit!\nScor final: {setari.Score}", "Ouch", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                {
                    pagia_intrare f = new pagia_intrare();
                    f.Show();
                    this.Hide();
                }
            }
            pbCanvas.Invalidate();
        }

        private void StartGame()
        {
            new setari();
            snake.Clear();
            cerc head = new cerc { X = 10, Y = 5 };
            snake.Add(head);
            lblscor.Text = setari.Score.ToString();
            genereazamancare();
        }

        private void genereazamancare()
        {
            int maxXpos = pbCanvas.Size.Width / setari.Width;
            int maxYpos = pbCanvas.Size.Height / setari.Height;
            Random rnd = new Random();
            mancare = new cerc { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
        }

        private void mananca()
        {
            cerc body = new cerc
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };
            snake.Add(body);
            setari.Score += setari.Points;
            lblscor.Text = setari.Score.ToString();
            genereazamancare();
        }

        private void oopsie()
        {
            setari.GameOver = true;
        }

        private void movePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (setari.direction)
                    {
                        case Directions.Right:
                            snake[i].X++;
                            break;
                        case Directions.Left:
                            snake[i].X--;
                            break;
                        case Directions.Up:
                            snake[i].Y--;
                            break;
                        case Directions.Down:
                            snake[i].Y++;
                            break;
                    }

                    int maxXpos = pbCanvas.Size.Width / setari.Width;
                    int maxYpos = pbCanvas.Size.Height / setari.Height;
                    if (
                        snake[i].X < 0 || snake[i].Y < 0 ||
                        snake[i].X > maxXpos || snake[i].Y > maxYpos
                        )
                    {
                        oopsie();
                    }
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            oopsie();
                        }
                    }
                    if (snake[0].X == mancare.X && snake[0].Y == mancare.Y)
                    {
                        mananca();
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }

        private void keyisdow(object sender, KeyEventArgs e)
        {
            input.changeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            input.changeState(e.KeyCode, false);
        }


        private void frm_sarpe_Load(object sender, EventArgs e)
        {

        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (setari.GameOver == false)
            {
                Brush snakeColour;
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColour = Brushes.Black;
                    }
                    else
                    {
                        snakeColour = Brushes.Orange;
                    }
                    canvas.FillEllipse(snakeColour,
                                        new Rectangle(
                                            snake[i].X * setari.Width,
                                            snake[i].Y * setari.Height,
                                            setari.Width, setari.Height
                                            ));
                    canvas.FillEllipse(Brushes.Red,
                                        new Rectangle(
                                            mancare.X * setari.Width,
                                            mancare.Y * setari.Height,
                                            setari.Width, setari.Height
                                            ));
                }




            }
            else
            {

            }


        }
    }


}
