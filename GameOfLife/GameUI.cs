using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class GameUI : Form
    {
        private Engine engine = null;
        private static readonly Color aliveCell = Color.DimGray;
        private static readonly Color deadCell = Color.LightSlateGray;
        private const int cellSize = 30;
        private const int screenSize = 390;
        private const int cellNumber = screenSize / cellSize;

        public GameUI()
        {
            InitializeComponent();            
            engine = new Engine(cellNumber, cellNumber);
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            for (int j = 0; j + cellSize <= screenSize; j += cellSize)
                for (int i = 0; i + cellSize <= screenSize; i += cellSize)
                {
                    Button newButton = new Button();
                    newButton.Size = new Size(cellSize, cellSize);
                    newButton.Location = new Point(i, j);
                    newButton.Click += new EventHandler(ClickCell);
                    gameScreen.Controls.Add(newButton);
                }

            UpdateCells();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            engine.Tick();
            lblCount.Text = engine.Ticks.ToString();
            UpdateCells();
        }
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            btnPlay.Enabled = false;
            btnStop.Enabled = true;
        }
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnStop.Enabled = false;
            btnPlay.Enabled = true;
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnStop.Enabled = false;
            btnPlay.Enabled = true;

            engine = new Engine(engine.Height, engine.Width);
            lblCount.Text = engine.Ticks.ToString();

            UpdateCells();
        }
        
        private void ClickCell(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;

            int buttonLinearIndex = gameScreen.Controls.IndexOf(sender as Control);
            int y = buttonLinearIndex / engine.Width;
            int x = buttonLinearIndex % engine.Width;
            
            engine[y, x] = !engine[y, x];
            ((Button)sender).BackColor = engine[y, x] ? aliveCell : deadCell;
            ((Button)sender).BackgroundImage = engine[y, x] ? global::GameOfLife.Properties.Resources.GlowStar_16x : global::GameOfLife.Properties.Resources.Blank_Star;
        }

        private void UpdateCells()
        {
            for (int linearIndex = 0; linearIndex < gameScreen.Controls.Count; ++linearIndex)
            {
                gameScreen.Controls[linearIndex].BackColor =
                    engine[linearIndex / engine.Width, linearIndex % engine.Width] ? aliveCell : deadCell;
                gameScreen.Controls[linearIndex].BackgroundImage =
                    engine[linearIndex / engine.Width, linearIndex % engine.Width] ? global::GameOfLife.Properties.Resources.GlowStar_16x : global::GameOfLife.Properties.Resources.Blank_Star;
                gameScreen.Controls[linearIndex].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            }
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbxHelp_Click(object sender, EventArgs e)
        {
            gbGameInst.Visible = true;
            btnStart.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gbGameInst.Visible = false;
            btnStart.Visible = false;
            btnReset_Click(sender, e);
        }
    }   
}