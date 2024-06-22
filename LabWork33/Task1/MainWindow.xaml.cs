using System.Windows;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new List<Game>()
            {
                new Game{IdGame = 1, Name = "Tetris", Site="https\\tetris.ru", Category = "головоломка", Price = 150},
                new Game{IdGame = 2, Name = "Flappy Bird", Site = "https\\flappybird.ru", Category = "платформер", Price = 10},
                new Game{IdGame = 3, Name = "Pac-man", Site = "https\\pacman.ru", Category = "аркада", Price = 300},
                new Game{IdGame = 4, Name = "Arkanoid", Site="https\\arkanoid.ru", Category = "аркада", Price = 400},
                new Game{IdGame = 5, Name = "Mario", Site = "https\\mario.ru", Category = "платформер", Price = 1000},
            };
            GamesListView.ItemsSource = games;
        }
    }
}