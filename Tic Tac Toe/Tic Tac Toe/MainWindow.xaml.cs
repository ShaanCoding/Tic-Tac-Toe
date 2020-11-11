﻿using System;
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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlayerEnum currentPlayer = PlayerEnum.XPlayer;
        public int turns = 0;
        public int playerXWins = 0;
        public int playerOWins = 0;
        public int playerDraws = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if((string)button.Content != "O" || (string)button.Content != "X")
            {
                if(currentPlayer == PlayerEnum.XPlayer)
                {
                    button.Content = "X";
                    turns++;
                    currentPlayer = PlayerEnum.OPlayer;
                }
                else if(currentPlayer == PlayerEnum.OPlayer)
                {
                    button.Content = "O";
                    turns++;
                    currentPlayer = PlayerEnum.XPlayer;
                }

                if(CheckDraw())
                {
                    MessageBox.Show("Tie!");
                    playerDraws++;
                }
            }


        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            currentPlayer = PlayerEnum.XPlayer;
            turns = 0;
            B00.Content = B01.Content = B02.Content = B10.Content = B11.Content = B12.Content = B20.Content = B21.Content = B22.Content = "";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            currentPlayer = PlayerEnum.XPlayer;
            turns = 0;
            B00.Content = B01.Content = B02.Content = B10.Content = B11.Content = B12.Content = B20.Content = B21.Content = B22.Content = "";
            playerXWins = 0;
            playerOWins = 0;
            playerDraws = 0;
        }

        public bool CheckDraw()
        {
            return turns == 9;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}