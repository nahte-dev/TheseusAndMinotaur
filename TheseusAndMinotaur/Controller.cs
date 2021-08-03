using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheseusAndMinotaur
{
    public class Controller
    {
        protected Game game;
        protected GameViewForm view;
        protected Popup popForm;

        public int height;
        public int width;
        public int levelCount;
        public string currentLevelName;
        public int moveCount;
        public List<Level> allLevels;

        public Controller(Game theGame, GameViewForm theView, Popup thePopForm)
        {
            this.game = theGame;
            this.view = theView;
            this.popForm = thePopForm;
        }

        //Setting controller variables to game variables after constructor
        //as controller is constructed before game data is populated
        public void ImportLevelData()
        {
            height = game.LevelHeight;
            width = game.LevelWidth;
            currentLevelName = game.CurrentLevelName;
            moveCount = game.MoveCount;
            allLevels = game.allLevels;
        }

        public void AddNewLevel(string levelName, int width, int height, string data) => game.AddLevel(levelName, width, height, data);

        public void MoveInput(Moves direction) => game.MoveTheseus(direction);

        public void LoadLevel(Level selectedLevel)
        {
            game.LoadLevel(selectedLevel);
            view.Refresh();
            ImportLevelData();
            view.DisplayLoadedLevel();
            view.StartTimer();
        }

        public void RestartLevel()
        {
            game.RestartLevel();
            view.Refresh();
            ImportLevelData();
            view.DisplayLoadedLevel();
            view.ResetTimer();
            view.StartTimer();
        }

        public void LoadNextLevel()
        {
            game.LoadNextLevel();
            view.Refresh();
            ImportLevelData();
            view.DisplayLoadedLevel();
            view.ResetTimer();
            view.StartTimer();
        }

        public void QuitGame()
        {
            popForm.Close();
            view.Close();
        }

        public bool MinotaurWins()
        {
            return game.HasMinotaurWon();
        }

        public bool TheseusWins()
        {
            return game.HasTheseusWon();
        }

        public Square GetSquare(int row, int col)
        {
            return game.WhatIsAt(row, col);
        }
    }
}
