using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment
{
    public partial class GameForm : Form
    {
        MainMenuForm mmf;
        ITile Theseus, Mino, Exit;
        MapBuilder mapBuilder;
        Graphics e;
        Boolean gameOver = false;
        Boolean tNotMoved = false;
        Boolean mazeStarts = false;
        DateTime _LastExecution = DateTime.MinValue;
        Int32 TimeCount = 0;
        Int32 level = 0;

        enum Direction
        { 
            Left, Right, Down, Up, Stay
        }

        Direction _moveTheseus;
        String map;

        public GameForm(String newMap)
        {
            this.map = newMap;
            InitializeComponent();
            InitializeMapBuilder();
            GameControlPanel.Show();
            
            //this.BringToFront();
            //this.Focus();
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(GameForm_KeyDown);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //GamePanel.Hide();
            //GameControlPanel.Hide();
            GamePanel.Show();
            //GamePanel = MapPanel.map;
            GamePanel.BringToFront();
            GameControlPanel.BringToFront();
            this.CenterToScreen();
        }

        public void InitializeMapBuilder()
        {
            mapBuilder = new MapBuilder(map, GamePanel.Width, GamePanel.Height);

        }

        public Boolean IsDotWall(List<List<ITile>> tileList, Int32 i, Int32 j, Int32 count = 1)
        {
            try
            {
                if (count == 1) // UP
                {
                    if (tileList[i - 1][j] is DrawVWall)
                    {
                        return true;
                    }
                }
                else if (count == 2) // BOTTOM
                {
                    if (tileList[i + 1][j] is DrawVWall)
                    {
                        return true;
                    }

                }
                else if (count == 3) // Left
                {
                    if (tileList[i][j - 1] is DrawHWall)
                    {
                        return true;
                    }
                }
                else if (count == 4) // Right
                {

                    if (tileList[i][j + 1] is DrawHWall)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                //do nothing
                // paints a big red x on panel if index out of range is not handled
            }

            return IsDotWall(tileList, i, j, count += 1);

        }

        public void DrawMapOnPanel(List<List<ITile>> tileList)
        {
            e = GamePanel.CreateGraphics();
            ITile tile;
            Int32 theseusX = 0;
            Int32 theseusY = 0;
            Int32 minotaurX = 0;
            Int32 minotaurY = 0;
            Int32 exitX = 0;
            Int32 exitY = 0;
            Boolean redrawTheseus = false;
            Boolean redrawMinotaur = false;
            Boolean redrawExit = false;

            for (int i = 0; i < tileList.Count; i++)
            {
                for (int j = 0; j < tileList[i].Count; j++)
                {
                    tile = tileList[i][j];

                    if (tile is DrawHWall || tile is DrawVWall)
                    {
                        e.FillRectangle(Brushes.Blue, tile.PosX, tile.PosY, tile.Width, tile.Height);//(mapBuilder.tileWidth/4) * 3);
                    }

                    else if (tile is DrawDot)
                    {
                        if (IsDotWall(tileList, i, j) == true)
                        {
                            e.FillRectangle(Brushes.Blue, tile.PosX, tile.PosY, tile.Width, tile.Height);
                        }
                        else
                        {
                            e.FillRectangle(Brushes.White, tile.PosX, tile.PosY, tile.Width, tile.Height);
                        }
                    }
                    else if (tile is DrawTheseus)
                    {
                        e.FillRectangle(Brushes.White, tile.PosX, tile.PosY, tile.Width, tile.Height);
                        Theseus = tile;
                        redrawTheseus = true;
                        theseusX = i;
                        theseusY = j;

                    }
                    else if (tile is DrawMinotaur)
                    {
                        e.FillRectangle(Brushes.White, tile.PosX, tile.PosY, tile.Width, tile.Height);
                        Mino = tile;
                        redrawMinotaur = true;
                        minotaurX = i;
                        minotaurY = j;


                    }
                    else if (tile is DrawExit)
                    {
                        e.FillRectangle(Brushes.White, tile.PosX, tile.PosY, tile.Width, tile.Height);
                        Exit = tile;
                        redrawExit = true;
                        exitX = i;
                        exitY = j;
                    }
                    else
                    {
                        e.FillRectangle(Brushes.White, tile.PosX, tile.PosY, tile.Width, tile.Height);
                    }
                }
            }
            if (redrawTheseus == true)
            {
                e.FillEllipse(Brushes.Red, Theseus.PosX, Theseus.PosY, (mapBuilder.tileWidth / 4 * 3), Theseus.Height);
                //Theseus.PosX += mapBuilder.tileWidth / 4;
                //DrawTME(Theseus, theseusX, theseusY, false);
            }
            if (redrawMinotaur == true)
            {
                e.FillEllipse(Brushes.Black, Mino.PosX, Mino.PosY, (mapBuilder.tileWidth / 4 * 3), Mino.Height);

                //DrawTME(Mino, minotaurX, minotaurY, false);
            }

            if (redrawExit == true)
            {
                e.FillRectangle(Brushes.White, Exit.PosX, Exit.PosY, Exit.Width, Exit.Height);
                Pen pen = new Pen(Color.Red);
                pen.Width = 4.0f;
                PointF point1 = new PointF(Exit.PosX, Exit.PosY);
                PointF point2 = new PointF(Exit.PosX + Exit.Width, Exit.PosY + Exit.Width);
                PointF point3 = new PointF(Exit.PosX + Exit.Width, Exit.PosY);
                PointF point4 = new PointF(Exit.PosX, Exit.PosY + Exit.Width);
                e.DrawLine(pen, point1, point2);
                e.DrawLine(pen, point3, point4);
                //Exit.PosX += mapBuilder.tileWidth / 4;
                //DrawTME(Exit, exitX, exitY, false);
            }
            // Exit is a char
        }
        

        private void GameGoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mmf == null)
            {
                mmf = new MainMenuForm();
                mmf.FormClosed += Mmf_FormClosed;
                mmf.Show();
            }

            else
            {
                mmf.Activate();
            }

        }

        private void Mmf_FormClosed(object sender, FormClosedEventArgs e)
        {
            mmf = null;
        }

        private void GamePlayBtn_Click(object sender, EventArgs e)
        {
            GameControlPanel.Show();
            GamePanel.Show();
            //GamePanel = MapPanel.map;
            GamePanel.BringToFront();
            GameControlPanel.BringToFront();
            //panel1.Show();
            //panel2.Show();
            //panel2.BringToFront();
        }

        private void GameExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawMapOnPanel(mapBuilder.TileList);
            //g.FillEllipse(Brushes.Red, Theseus.PosX, Theseus.PosY, (mapBuilder.tileWidth / 4 * 3), Theseus.Height);
        }

        private Boolean HasWall(Int32 row, Int32 col)
        {
            try
            {
                if (mapBuilder._2DMap[row][col] == "|" || mapBuilder._2DMap[row][col] == "_")
                {
                    return true;
                }
            }
            catch
            {
                return true;
            }
            return false;
        }

        private Boolean BlockMove(Direction direction, Int32 row, Int32 col, String thisChar) //set the new position of Theseus too
        {
            if (direction == Direction.Up)
            {
                if (HasWall(row -1, col))
                {
                    return true;
                }
                else
                {
                    mapBuilder._2DMap[row][col] = " ";
                    mapBuilder._2DMap[row-2][col] = thisChar;
                    return false;
                }
            }
            else if (direction == Direction.Right)
            {
                if (HasWall(row, col + 2))
                {
                    return true;
                }
                else
                {
                    mapBuilder._2DMap[row][col] = " ";
                    mapBuilder._2DMap[row][col + 4] = thisChar;
                    return false;
                }
            }
            else if (direction == Direction.Down)
            {
                if (HasWall(row + 1, col))
                {
                    return true;
                }
                else
                {
                    mapBuilder._2DMap[row][col] = " ";
                    mapBuilder._2DMap[row + 2][col] = thisChar;
                    return false;
                }
            }
            else if (direction == Direction.Left)
            {
                if (HasWall(row, col - 2))
                {
                    return true;
                }
                else
                {
                    mapBuilder._2DMap[row][col] = " ";
                    mapBuilder._2DMap[row][col - 4] = thisChar;
                    return false;
                }
            }
            return false;
        }


        private Tuple<int, int> GetCharPos(String findThisChar)
        {
            String ch;
            for (int i = 0; i < mapBuilder._2DMap.Count; i++)
            {
                for (int j = 0; j < mapBuilder._2DMap[i].Count; j++)
                {
                    ch = mapBuilder._2DMap[i][j];
                    if (ch == findThisChar)
                    {
                        return new Tuple<int, int>(i,j);
                    }
                }
            }

            return new Tuple<int, int>(0, 0);
            
        }
        private Direction TryMoveHorizontal(Int32 row, Int32 col, Int32 rowT, Int32 colT)
        {
            if (colT > col)
            {
                if (HasWall(row, col + 2)) //right
                {
                    return Direction.Stay;
                }
                else
                {
                    return Direction.Right;
                }
            }
            else if (colT < col)
            {
                if (HasWall(row, col - 2)) //left
                {
                    return Direction.Stay;
                }
                else
                {
                    return Direction.Left;
                }
            }
            return Direction.Stay;
        }

        private Direction MinoDirection()
        {
            Int32 row = GetCharPos("M").Item1;
            Int32 col = GetCharPos("M").Item2;

            Int32 rowT = GetCharPos("T").Item1;
            Int32 colT = GetCharPos("T").Item2;

            if (row == rowT)
            {
                return TryMoveHorizontal(row, col, rowT, colT);
            }
            else
            {
                if (col != colT)
                {
                    if (TryMoveHorizontal(row, col, rowT, colT) != Direction.Stay)
                    {
                        return TryMoveHorizontal(row, col, rowT, colT);
                    }
                    
                }
                if (rowT < row)
                {
                    if (HasWall(row, col + 2) && HasWall(row, col - 2))
                    {
                        if (HasWall(row - 1, col)) //up
                        {
                            return Direction.Stay;
                        }
                        else
                        {
                            return Direction.Up;
                        }
                    }
                    else
                    {
                        return Direction.Up;
                    }
                    

                }
                else if (rowT > row)
                {
                    if (HasWall(row + 1, col)) //down
                    {
                        return Direction.Stay;
                    }
                    else
                    {
                        return Direction.Down;
                    }
                    }
                    else
                    {
                        return Direction.Down;
                    }
            }
        }

        private void MoveCharacter(Direction charDir, ITile character, Int32 row, Int32 col, SolidBrush myBrush, String thisChar)
        {

            Graphics d = GamePanel.CreateGraphics();
            if (charDir == Direction.Up)
            {
                if (!BlockMove(Direction.Up, row, col, thisChar))
                {
                    d.FillEllipse(Brushes.White, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                    character.PosY -= mapBuilder.tileWidth;
                    d.FillEllipse(myBrush, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                }
                else
                {
                    tNotMoved = true;
                }
                
            }
            else if (charDir == Direction.Right)
            {
                if (!BlockMove(Direction.Right, row, col, thisChar))
                {
                    d.FillEllipse(Brushes.White, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                    character.PosX += mapBuilder.tileWidth;
                    d.FillEllipse(myBrush, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                }
                else
                {
                    tNotMoved = true;
                }
                
            }
            else if (charDir == Direction.Down)
            {
                if (!BlockMove(Direction.Down, row, col, thisChar))
                {
                    d.FillEllipse(Brushes.White, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                    character.PosY += mapBuilder.tileWidth;
                    d.FillEllipse(myBrush, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                }
                else
                {
                    tNotMoved = true;
                }
                
            }
            else if (charDir == Direction.Left)
            {
                if (!BlockMove(Direction.Left, row, col, thisChar))
                {
                    d.FillEllipse(Brushes.White, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                    character.PosX -= mapBuilder.tileWidth;
                    d.FillEllipse(myBrush, character.PosX, character.PosY, (mapBuilder.tileWidth / 4 * 3), character.Height);
                }
                else
                {
                    tNotMoved = true;
                }

            }
            else if (charDir == Direction.Stay)
            {
                
            }
           Invalidate();
        }


        private void TimeMover_Tick(object sender, EventArgs e)
        {
            if (mazeStarts == true)
            {
                TimeCount += 1;
                if (TimeCount <= 2)
                {
                    MoveCharacter(MinoDirection(), Mino, GetCharPos("M").Item1, GetCharPos("M").Item2, new SolidBrush(Color.Black), "M");
                }
                if (hasLose() == true)
                {
                    TimeMover.Stop();
                    MessageBox.Show("GAME OVER!!");
                    gameOver = true;

                }
                else if (TimeCount == 2)
                {
                    TimeMover.Stop();
                    TimeCount = 0;

                }
            }
            
        }

        private String ConverToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < mapBuilder._2DMap.Count; i++)
            {
                foreach (String line in mapBuilder._2DMap[i])
                {
                    sb.Append(line);
                }
                sb.Append(System.Environment.NewLine);
            }
            return sb.ToString();
        }

        private Boolean hasLose()
        {
            Double rowT = Math.Floor(Theseus.PosY);
            Double colT = Math.Floor(Theseus.PosX);

            Double rowM = Math.Floor(Mino.PosY);
            Double colM = Math.Floor(Mino.PosX);

            if (rowT == rowM && colM == colT)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver == false && (DateTime.Now - _LastExecution).TotalMilliseconds > 101) // limit keystroke, stop users rapid keystroke which left minotaur far behind.
            {
                if (e.KeyCode == Keys.Left)
                {
                    _moveTheseus = Direction.Left;
                    tNotMoved = false;
                    startMoving();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    _moveTheseus = Direction.Right;
                    tNotMoved = false;
                    startMoving();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    _moveTheseus = Direction.Up;
                    tNotMoved = false;
                    startMoving();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    _moveTheseus = Direction.Down;
                    tNotMoved = false;
                    startMoving();
                }
                else if (e.KeyCode == Keys.D)
                {
                    _moveTheseus = Direction.Stay;
                    tNotMoved = false;
                    startMoving();
                }
                _LastExecution = DateTime.Now;
            }

           // MessageBox.Show(ConverToString());
        }

        private void startMoving()
        {
            mazeStarts = true;
            MoveCharacter(_moveTheseus, Theseus, GetCharPos("T").Item1, GetCharPos("T").Item2, new SolidBrush(Color.Red), "T");
            if (tNotMoved == false)
            {
                if (Math.Floor(Theseus.PosX) == Math.Floor(Exit.PosX) && Math.Floor(Theseus.PosY) == Math.Floor(Exit.PosY))
                {
                    MessageBox.Show("YOU WIN!!!");
                    gameOver = true;
                }
                else
                {
                    TimeMover.Start();
                }
            }
        
        }

        private void restartMazeBtn_Click(object sender, EventArgs e)
        {
            mapBuilder = new MapBuilder(map, GamePanel.Width, GamePanel.Height);
            DrawMapOnPanel(mapBuilder.TileList);
            gameOver = false;
            mazeStarts = true;
            TimeCount = 0;
            
        }

        private void GameNextBtn_Click(object sender, EventArgs e)
        {
            if (level < 7)
            {
                level += 1;
                this.GamePanel.Controls.Clear();
                map = PlayByLevel.Maps[level];
                mapBuilder = new MapBuilder(map, GamePanel.Width, GamePanel.Height);
                DrawMapOnPanel(mapBuilder.TileList);
                gameOver = false;
                mazeStarts = true;
                TimeCount = 0;
                GamePanel.Invalidate();
            }
        }

        private void GamePrevBtn_Click(object sender, EventArgs e)
        {
            if (level > 0)
            {
                level -= 1;
                this.GamePanel.Controls.Clear();
                map = PlayByLevel.Maps[level];
                mapBuilder = new MapBuilder(map, GamePanel.Width, GamePanel.Height);
                DrawMapOnPanel(mapBuilder.TileList);
                gameOver = false;
                mazeStarts = true;
                TimeCount = 0;
                GamePanel.Invalidate();
            }
        }

        private void GameQuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                GameForm_KeyDown(this, new KeyEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
