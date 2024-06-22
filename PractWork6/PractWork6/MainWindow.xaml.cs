﻿using System.Windows;

namespace PractWork6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Sale;

        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new()
            {
                new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
                new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
                new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
                new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
                new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
                new Game{IdGame = 6, Name = "Tetris2", Category = "головоломка", Price = 150},
                new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
                new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "аркада", Price = 300},
                new Game{IdGame = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
                new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Category = "платформер", Price = 1000},
            };

            List<Category> categories = new()
            {
                new Category{Name = "головоломка", Description = "описание жанра головоломка"},
                new Category{Name = "платформер", Description = "описание жанра платформер"},
                new Category{Name = "RPG", Description = "описание жанра RPG"},
                new Category{Name = "аркада", Description = "описание жанра аркада"}
            };

            Sale = Convert.ToInt32(SalePriceTextBox.Text) / 100;
            
            gameDataGrid.ItemsSource = games;
            categoryComboBox.ItemsSource = categories;
        }
    }
}