using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SnakeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int headSize = 5;
        int direction = 0;
        int previousDirection = 0;

        Brush snakeColor = Brushes.Green;
        Brush blankSpace = Brushes.White;
        Point currentPosition = new Point(1, 1);


        public MainWindow()
        {
            InitializeComponent();
            PaintSnake(currentPosition);
            DispatcherTimer timer = new DispatcherTimer();
            KeyDown += new KeyEventHandler(OnButtonKeyDown);

            timer.Tick += new EventHandler(GameRunTimer);
            timer.Interval = new TimeSpan(10000);
            timer.Start();



        }

        public void PaintSnake(Point currentPos)
        {
            Ellipse newEllipse = new Ellipse();
            int snakeSize = paintCanvas.Children.Count;

            newEllipse.Fill = snakeColor;
            newEllipse.Width = headSize;
            newEllipse.Height = headSize;

            Canvas.SetTop(newEllipse, currentPos.Y);
            Canvas.SetLeft(newEllipse, currentPos.X);

            paintCanvas.Children.Add(newEllipse);

            

        }

        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {

                case Key.Left:
                    direction = 4;
                    previousDirection = direction;
                    break;
                case Key.Up:
                    direction = 8;
                    previousDirection = direction;
                    break;
                case Key.Right:
                    direction = 6;
                    previousDirection = direction;
                    break;
                case Key.Down:
                    direction = 2;
                    previousDirection = direction;

                    break;

            }
        }

        private void GameRunTimer(object sender, EventArgs e)
        {
            switch (direction)
            {
                case 2:
                    currentPosition.Y += 1;
                    PaintSnake(currentPosition);
                    break;

                case 8:
                    currentPosition.Y -= 1;
                    PaintSnake(currentPosition);
                    break;

                case 4:
                    currentPosition.X -= 1;
                    PaintSnake(currentPosition);
                    break;

                case 6:
                    currentPosition.X += 1;
                    PaintSnake(currentPosition);
                    break;

            }
        }
    }
}
