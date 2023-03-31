using System;
using System.Drawing;
using System.Windows.Forms;
using SnakeWFA.GameLogic;

namespace SnakeWFA
{
    public partial class MainForm : Form
    {
        private GameState _gameState;
        private static readonly int PixelSize = 16;

        public MainForm()
        {
            InitializeComponent();
            _gameState = new GameState();
            gameTimer.Interval = 1000 / _gameState.Speed;
            gameTimer.Tick += RenderTick;
            gameTimer.Start();
            StartGame();
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _gameState.Snake.Direction = Directions.Up; break;
                case Keys.Down:
                    _gameState.Snake.Direction = Directions.Down; break;
                case Keys.Left:
                    _gameState.Snake.Direction = Directions.Left; break;
                case Keys.Right:
                    _gameState.Snake.Direction = Directions.Right; break;
                case Keys.Enter:
                    if (_gameState.GameOver)
                        StartGame();
                    break;
            }
        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            labelScoreValue.Text = _gameState.Score.ToString();
            if (_gameState.GameOver)
            {
                labelGameOver.Text = "Game Over\nFinal Score is " + _gameState.Score + "\nPress Enter to restart\n";
                labelGameOver.Visible = true;
                return;
            }

            Graphics canvas = e.Graphics;
            for (int i = 0; i < _gameState.Snake.Body.Count; ++i)
                canvas.FillRectangle((i == 0) ? Brushes.Black : Brushes.Green, new Rectangle(_gameState.Snake.Body[i].X * PixelSize, _gameState.Snake.Body[i].Y * PixelSize, PixelSize - 1, PixelSize - 1));
            canvas.FillRectangle(Brushes.Red, new Rectangle(_gameState.Apple.X * PixelSize, _gameState.Apple.Y * PixelSize, PixelSize - 1, PixelSize - 1));
        }

        private void RenderTick(object sender, EventArgs e)
        {
            if (!_gameState.GameOver)
                _gameState.Update();
            pbCanvas.Invalidate();
        }

        private void StartGame()
        {
            _gameState = new GameState();
            labelScoreValue.Text = _gameState.Score.ToString();
            labelGameOver.Visible = false;
        }
    }
}
