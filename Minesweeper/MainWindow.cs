using System;
using System.Drawing;
using System.Windows.Forms;
using Minesweeper.Properties;

namespace Minesweeper
{
    public partial class Window : Form
    {
        private static int _mines = 40, _closedsafetiles = 256, _time;

        private readonly Tilestruct[,] _tiles = new Tilestruct[18, 18];

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            create_new_field();
            choose_difficulty();
        }

        // Generates the 16x16 game field
        private void create_new_field()
        {
            timepastvalue.Text = _time.ToString();

            for (var i = 0; i < 18; i++)
            {
                _tiles[i, 0].Coverstatus = -1;
                _tiles[i, 17].Coverstatus = -1;
            }
            for (var j = 1; j < 17; j++)
            {
                _tiles[0, j].Coverstatus = -1;
                _tiles[17, j].Coverstatus = -1;
            }

            int l = 0, t = 0;

            for (var i = 1; i < 17; i++)
            {
                for (var j = 1; j < 17; j++)
                {
                    _tiles[i, j].Value = new Label
                    {
                        Left = l,
                        Top = t,
                        Width = 32,
                        Height = 32,
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Consolas", 20, FontStyle.Bold),
                        Text = null,
                        TextAlign = ContentAlignment.TopCenter
                    };
                    field.Controls.Add(_tiles[i, j].Value);

                    _tiles[i, j].Cover = new Button
                    {
                        Left = l,
                        Top = t,
                        Width = 32,
                        Height = 32,
                        BackgroundImage = Resources.tile
                    };
                    _tiles[i, j].Cover.MouseDown += tile_MouseDown;
                    _tiles[i, j].Cover.MouseUp += tile_MouseUp;
                    field.Controls.Add(_tiles[i, j].Cover);
                    _tiles[i, j].Cover.BringToFront();

                    l += 32;
                }
                l = 0;
                t += 32;
            }
        }

        // Populates the game field with mines
        private void create_new_mines()
        {
            var rnd = new Random();
            var m = _mines;

            while (m > 0)
            {
                var x = rnd.Next(1, 17);
                var y = rnd.Next(1, 17);
                if (_tiles[x, y].Valuestatus == 0)
                {
                    _tiles[x, y].Valuestatus = -1;
                    m--;
                }
            }

            for (var i = 1; i < 17; i++)
            {
                for (var j = 1; j < 17; j++)
                {
                    if (_tiles[i, j].Valuestatus != -1)
                    {
                        _tiles[i, j].Valuestatus = 0;
                        if (_tiles[i - 1, j - 1].Valuestatus == -1) _tiles[i, j].Valuestatus++;
                        if (_tiles[i - 1, j].Valuestatus == -1) _tiles[i, j].Valuestatus++;
                        if (_tiles[i - 1, j + 1].Valuestatus == -1) _tiles[i, j].Valuestatus++;
                        if (_tiles[i, j - 1].Valuestatus == -1) _tiles[i, j].Valuestatus++;
                        if (_tiles[i, j + 1].Valuestatus == -1) _tiles[i, j].Valuestatus++;
                        if (_tiles[i + 1, j - 1].Valuestatus == -1) _tiles[i, j].Valuestatus++;
                        if (_tiles[i + 1, j].Valuestatus == -1) _tiles[i, j].Valuestatus++;
                        if (_tiles[i + 1, j + 1].Valuestatus == -1) _tiles[i, j].Valuestatus++;

                        if (_tiles[i, j].Valuestatus > 0)
                        {
                            _tiles[i, j].Value.Text = _tiles[i, j].Valuestatus.ToString();
                            switch (_tiles[i, j].Valuestatus)
                            {
                                case 1:
                                    _tiles[i, j].Value.ForeColor = Color.Blue;
                                    break;
                                case 2:
                                    _tiles[i, j].Value.ForeColor = Color.Green;
                                    break;
                                case 3:
                                    _tiles[i, j].Value.ForeColor = Color.Red;
                                    break;
                                case 4:
                                    _tiles[i, j].Value.ForeColor = Color.Purple;
                                    break;
                                case 5:
                                    _tiles[i, j].Value.ForeColor = Color.Brown;
                                    break;
                                case 6:
                                    _tiles[i, j].Value.ForeColor = Color.Aqua;
                                    break;
                                case 7:
                                    _tiles[i, j].Value.ForeColor = Color.Black;
                                    break;
                                case 8:
                                    _tiles[i, j].Value.ForeColor = Color.Gray;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        // Executes events when a tile is pressed
        private void tile_MouseDown(object sender, MouseEventArgs e)
        {
            var clickedtile = (Button) sender;
            var x = clickedtile.Top/32 + 1;
            var y = clickedtile.Left/32 + 1;

            if (e.Button == MouseButtons.Left)
            {
                if (_tiles[x, y].Coverstatus != 1)
                {
                    newgame.BackgroundImage = Resources.leftclick;

                    if (timer.Enabled == false)
                    {
                        _tiles[x, y].Valuestatus = 9;
                        create_new_mines();
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (_tiles[x, y].Coverstatus == 0)
                {
                    if (_mines > 0)
                    {
                        _tiles[x, y].Cover.BackgroundImage = Resources.tile_flagged;
                        _tiles[x, y].Coverstatus = 1;

                        _mines--;
                        minesleftvalue.Text = _mines.ToString();
                    }
                }
                else if (_tiles[x, y].Coverstatus == 1)
                {
                    _tiles[x, y].Cover.BackgroundImage = Resources.tile_unsure;
                    _tiles[x, y].Coverstatus = 2;

                    _mines++;
                    minesleftvalue.Text = _mines.ToString();
                }
                else
                {
                    _tiles[x, y].Cover.BackgroundImage = Resources.tile;
                    _tiles[x, y].Coverstatus = 0;
                }
            }
        }

        // Executes events when a tile is released
        private void tile_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var clickedtile = (Button) sender;
                var x = clickedtile.Top/32 + 1;
                var y = clickedtile.Left/32 + 1;

                if (_tiles[x, y].Coverstatus != 1)
                {
                    if (timer.Enabled == false) timer.Start();
                    field.Controls.Remove(_tiles[x, y].Cover);
                    _tiles[x, y].Coverstatus = -1;

                    if (_tiles[x, y].Valuestatus == -1) game_lost(x, y);
                    else
                    {
                        newgame.BackgroundImage = Resources.newgame;
                        _closedsafetiles--;
                        if (_tiles[x, y].Valuestatus == 0) open_tile(x, y);
                        if (_closedsafetiles <= 0) game_won();
                    }
                }
            }
        }

        // Prompts the user to create a new game
        private void newgame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you really want to start a new game?", @"New Game", MessageBoxButtons.YesNo) ==
                DialogResult.Yes) Application.Restart();
        }

        // Updates the time past value
        private void timer_Tick(object sender, EventArgs e)
        {
            timepastvalue.Text = (++_time).ToString();
        }

        // Executes if a game is lost
        private void game_lost(int x, int y)
        {
            newgame.BackgroundImage = Resources.gamelost;
            _tiles[x, y].Value.Image = Resources.redmine_broken;
            timer.Stop();

            for (var i = 1; i < 17; i++)
            {
                for (var j = 1; j < 17; j++)
                {
                    if (_tiles[i, j].Coverstatus != -1)
                    {
                        if (_tiles[i, j].Valuestatus == -1)
                        {
                            _tiles[i, j].Cover.BackgroundImage = _tiles[i, j].Coverstatus == 1
                                ? Resources.tile_mine_flag
                                : Resources.tile_mine;
                        }
                        else
                        {
                            if (_tiles[i, j].Coverstatus == 1)
                                _tiles[i, j].Cover.BackgroundImage = Resources.tile_mine_nomine;
                        }
                    }
                }
            }

            if (
                MessageBox.Show(@"Sorry, you lost this game. Do you want to start a new one?", @"Game Lost",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Restart();
            else Application.Exit();
        }

        // Executes if a game is won
        private void game_won()
        {
            newgame.BackgroundImage = Resources.gamewon;
            timer.Stop();

            _mines = 0;
            minesleftvalue.Text = _mines.ToString();

            for (var i = 1; i < 17; i++)
            {
                for (var j = 1; j < 17; j++)
                {
                    if (_tiles[i, j].Coverstatus != -1 && _tiles[i, j].Coverstatus != 1)
                        _tiles[i, j].Cover.BackgroundImage = Resources.tile_mine;
                }
            }

            if (
                MessageBox.Show(@"Congratulations, you won the game!. Do you want to start a new one?", @"Game Won",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Restart();
            else Application.Exit();
        }

        // Opens all empty tiles and the first non-mine tiles, around a clicked empty tile 
        private void open_tile(int x, int y)
        {
            if (_tiles[x - 1, y - 1].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x - 1, y - 1].Cover);
                _tiles[x - 1, y - 1].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x - 1, y - 1].Valuestatus == 0) open_tile(x - 1, y - 1);
            }

            if (_tiles[x - 1, y].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x - 1, y].Cover);
                _tiles[x - 1, y].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x - 1, y].Valuestatus == 0) open_tile(x - 1, y);
            }

            if (_tiles[x - 1, y + 1].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x - 1, y + 1].Cover);
                _tiles[x - 1, y + 1].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x - 1, y + 1].Valuestatus == 0) open_tile(x - 1, y + 1);
            }

            if (_tiles[x, y - 1].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x, y - 1].Cover);
                _tiles[x, y - 1].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x, y - 1].Valuestatus == 0) open_tile(x, y - 1);
            }

            if (_tiles[x, y + 1].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x, y + 1].Cover);
                _tiles[x, y + 1].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x, y + 1].Valuestatus == 0) open_tile(x, y + 1);
            }

            if (_tiles[x + 1, y - 1].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x + 1, y - 1].Cover);
                _tiles[x + 1, y - 1].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x + 1, y - 1].Valuestatus == 0) open_tile(x + 1, y - 1);
            }

            if (_tiles[x + 1, y].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x + 1, y].Cover);
                _tiles[x + 1, y].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x + 1, y].Valuestatus == 0) open_tile(x + 1, y);
            }

            if (_tiles[x + 1, y + 1].Coverstatus != -1)
            {
                field.Controls.Remove(_tiles[x + 1, y + 1].Cover);
                _tiles[x + 1, y + 1].Coverstatus = -1;
                _closedsafetiles--;
                if (_tiles[x + 1, y + 1].Valuestatus == 0) open_tile(x + 1, y + 1);
            }
        }

        private void choose_difficulty()
        {
            var difficulty = new DifficultyWindow();
            difficulty.ShowDialog();
            _mines = difficulty.Level;
            minesleftvalue.Text = _mines.ToString();
            _closedsafetiles -= _mines;
        }

        private struct Tilestruct
        {
            public sbyte Valuestatus, Coverstatus;
            /*
             * Legend:
             * 
             * valuestatus:
             * -1 - mine tile
             * 0 - empty tile
             * 1-8 - non-mine tile with 1-8 adjacent mines
             * 9 - first clicked tile
             * 
             * coverstatus:
             * -1 - opened status
             * 0 - default (empty) status
             * 1 - flagged status
             * 2 - unsure (?) status
             */
            public Label Value;
            public Button Cover;
        }
    }
}