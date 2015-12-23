using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilerTATM;

namespace Final_Assignment
{
    public partial class LevelDesignForm : Form
    {
        MapBuilder mapBuilder;
        FindBigTile findBigTile;
        FindOutsideWalls findOutsideWalls;
        Boolean hasClickedRightWall = false;
        Boolean hasClickedBottomWall = false;
        Boolean bigTileIsClicked = false;
        Int32 maxRow;
        ITile Theseus;
        ITile Mino;
        ITile Exit;
        List<BigTilePosition> bigTilesSelectPos = new List<BigTilePosition>();
        List<OutsideWallPos> rightWallSeclectPos = new List<OutsideWallPos>();
        List<OutsideWallPos> bottomWallSeclectPos = new List<OutsideWallPos>();
        FilerSave fs;
        FilerLoad fl;
        String map;

        public LevelDesignForm(String newMap)
        {
            InitializeComponent();
            this.map = newMap;

            InitializeMapBuilder();
            //MapPanel.map = LevelDesignPanel;

        }

        public void InitializeMapBuilder()
        {
            maxRow = 0;
            Int32 newCount;

            mapBuilder = new MapBuilder(map, LevelDesignPanel.Width, LevelDesignPanel.Height);
            foreach (List<ITile> item in mapBuilder.TileList)
            {
                newCount = item.Count;
                if (newCount > maxRow)
                {
                    maxRow = newCount;
                }
            }
            findBigTile = new FindBigTile(maxRow, mapBuilder.TileList.Count, mapBuilder.tileWidth / 4, mapBuilder.iniPosX, mapBuilder.iniPosY);
            findOutsideWalls = new FindOutsideWalls(maxRow, mapBuilder.TileList.Count, mapBuilder.tileWidth/4, mapBuilder.iniPosX, mapBuilder.iniPosY);
            
        }

        private void LevelDesignForm_Load(object sender, EventArgs e)
        {
            LevelDesignPanel.Show();
            LevelDesignButtonsPanel.Show();
            this.CenterToScreen();
        }

        private void LevelLoadBtn_Click(object sender, EventArgs e)
        {
            fl = new FilerLoad("Design");

            //flr.mapTextBox.AppendText(ConverToString());
            fl.Show();
        }

        private void LevelGoBackBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void levelNewMapBtn_Click(object sender, EventArgs e)
        {
            LevelDesignPanel.Show();
            LevelDesignButtonsPanel.Show();
            LevelDesignPanel.BringToFront();
            
        }
        private void HighlightSelectedTiles() 
        {
            Graphics g = LevelDesignPanel.CreateGraphics();
            Brush brush;
            brush = new SolidBrush(Color.FromArgb(128, 242, 216, 48));

            for (int i = 0; i < bigTilesSelectPos.Count; i++)
            {
                g.FillRectangle(brush, bigTilesSelectPos[i].iniPosX, bigTilesSelectPos[i].iniPosY, bigTilesSelectPos[i].width * 4, bigTilesSelectPos[i].width * 4);
                
            }
        }

        public void LevelDesignPanel_Click(object sender, EventArgs e)
        {
            
            Graphics g = LevelDesignPanel.CreateGraphics();
            Brush brush;
            Boolean hasFound = false;
            Point point = LevelDesignPanel.PointToClient(Cursor.Position);
            BigTilePosition BigTilePos;
            Single mapWidthMinusVWall = mapBuilder.iniPosX + ((maxRow - 1) * findBigTile.sTileWidth);
            Single mapHeightMinusBWall = mapBuilder.iniPosY + (((mapBuilder.TileList.Count - 1)/2) * (mapBuilder.tileWidth));
            Boolean alreadySelected = false;

            brush = new SolidBrush(Color.FromArgb(128, 242, 216, 48));

            if (point.X > mapWidthMinusVWall) 
            {
                hasClickedRightWall = true;
                if (bigTileIsClicked == true)
                {
                    MessageBox.Show(AlertOutput.alertTileRight);
                    hasClickedRightWall = false;
                }
                else if (hasClickedBottomWall == true)
                {
                    MessageBox.Show(AlertOutput.alertRightBottom);
                    hasClickedRightWall = false;
                }
                else
                {
                    for (int i = 0; i < findOutsideWalls.outsideRightWalls.Count; i++)
                    {
                        OutsideRightWallsPos rightWall = findOutsideWalls.outsideRightWalls[i];
                        
                        if (point.Y >= rightWall.iniPosY && point.Y <= rightWall.endPosY)
                        {
                            if (rightWallSeclectPos.Count > 0)
                            {
                                for (int j = 0; j < rightWallSeclectPos.Count; j++)
                                {
                                    if (Math.Floor(rightWallSeclectPos[j].iniPosY) == Math.Floor(rightWall.iniPosY))
                                    {
                                        
                                        
                                        rightWallSeclectPos.RemoveAt(j);
                                        DeselectWalls(rightWall);
                                        alreadySelected = true;
                                        break;
                                    }
                                }
                                if (alreadySelected == false)
                                {
                                    rightWallSeclectPos.Add(rightWall);
                                    g.FillRectangle(brush, rightWall.iniPosX, rightWall.iniPosY, mapBuilder.tileWidth / 4, mapBuilder.tileWidth);
                                }
                            }
                            else
                            {
                                rightWallSeclectPos.Add(rightWall);
                                g.FillRectangle(brush, rightWall.iniPosX, rightWall.iniPosY, mapBuilder.tileWidth / 4, mapBuilder.tileWidth);
                            } 
                        }
                    }
                }
                
            }
            else if (point.Y > mapHeightMinusBWall)
            {
                hasClickedBottomWall = true;
                if (bigTileIsClicked == true)
                {
                    MessageBox.Show(AlertOutput.alertTileBottom);
                    hasClickedBottomWall = false;
                }
                else if (hasClickedRightWall == true)
                {
                    MessageBox.Show(AlertOutput.alertRightBottom);
                    hasClickedBottomWall = false;
                }
                else
                {
                    for (int i = 0; i < findOutsideWalls.outsideBottomWalls.Count; i++)
                    {
                        OutsideBottomWallsPos bottomWall = findOutsideWalls.outsideBottomWalls[i];
                        if (point.X >= bottomWall.iniPosX && point.X <= bottomWall.endPosX)
                        {
                            if (bottomWallSeclectPos.Count > 0)
                            {
                                for (int j = 0; j < bottomWallSeclectPos.Count; j++)
                                {
                                    if (Math.Floor(bottomWallSeclectPos[j].iniPosX) == Math.Floor(bottomWall.iniPosX))
                                    {
                                        bottomWallSeclectPos.RemoveAt(j);
                                        DeselectWalls(bottomWall);
                                        alreadySelected = true;
                                        break;
                                    }
                                }
                                if (alreadySelected == false)
                                {
                                    bottomWallSeclectPos.Add(bottomWall);
                                    g.FillRectangle(brush, bottomWall.iniPosX, bottomWall.iniPosY, (mapBuilder.tileWidth / 4) * 4, mapBuilder.tileWidth / 4);
                                }
                            }
                            else
                            {
                                bottomWallSeclectPos.Add(bottomWall);
                                g.FillRectangle(brush, bottomWall.iniPosX, bottomWall.iniPosY, (mapBuilder.tileWidth / 4) * 4, mapBuilder.tileWidth / 4);
                            } 
                        }
                    }
                }
                
            }
            else
            {
                bigTileIsClicked = true;
                if (hasClickedBottomWall == true)
                {
                    MessageBox.Show(AlertOutput.alertTileBottom);
                    bigTileIsClicked = false;
                }
                else if (hasClickedRightWall == true)
                {
                    MessageBox.Show(AlertOutput.alertTileRight);
                    bigTileIsClicked = false;
                }
                else
                {
                    for (int i = 0; i < findBigTile.BTilePos.Count; i++)
                    {
                        for (int j = 0; j < findBigTile.BTilePos[i].Count; j++)
                        {
                            BigTilePos = findBigTile.BTilePos[i][j];
                            if (point.X >= BigTilePos.iniPosX && point.X <= BigTilePos.endPosX &&
                                point.Y >= BigTilePos.iniPosY && point.Y <= BigTilePos.endPosY)
                            {
                                if (bigTilesSelectPos.Count > 0)
                                {
                                    for (int k = 0; k < bigTilesSelectPos.Count; k++)
                                    {
                                        BigTilePosition currentBigTPos = bigTilesSelectPos[k];
                                        Double currBigIniPosX = Math.Floor(currentBigTPos.iniPosX);
                                        Double currBigIniPosY = Math.Floor(currentBigTPos.iniPosY);

                                        if (Math.Floor(BigTilePos.iniPosX) == currBigIniPosX && Math.Floor(BigTilePos.iniPosY) == currBigIniPosY)
                                        {
                                            bigTilesSelectPos.RemoveAt(k);
                                            DeselectTileAndReDraw(BigTilePos);
                                            alreadySelected = true;
                                            break;
                                        }
                                    }
                                    if (alreadySelected == false)
                                    {
                                        bigTilesSelectPos.Add(BigTilePos);
                                        g.FillRectangle(brush, BigTilePos.iniPosX, BigTilePos.iniPosY, BigTilePos.width * 4, BigTilePos.width * 4);
                                    }
                                }
                                else
                                {
                                    bigTilesSelectPos.Add(BigTilePos);
                                   g.FillRectangle(brush, BigTilePos.iniPosX, BigTilePos.iniPosY, BigTilePos.width * 4, BigTilePos.width * 4);
                                }

                                hasFound = true;
                                break;
                            }
                        }

                        if (hasFound == true)
                        {
                            break;
                        }
                    }
                }
                
                ////Brush brush = new SolidBrush(Color.FromArgb(alpha, red, green, blue))
            }
            //Invalidate();

            LevelDesignPanel.Update();
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
            Graphics e = LevelDesignPanel.CreateGraphics();
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
                        Theseus = tile;
                        redrawTheseus = true;
                        theseusX = i;
                        theseusY = j;

                    }
                    else if (tile is DrawMinotaur)
                    {
                        Mino = tile;
                        redrawMinotaur = true;
                        minotaurX = i;
                        minotaurY = j;


                    }
                    else if (tile is DrawExit)
                    {
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
                e.FillEllipse(Brushes.Red, Theseus.PosX, Theseus.PosY, (mapBuilder.tileWidth / 4 * 3) - 2, Theseus.Height - 2);
                //Theseus.PosX += mapBuilder.tileWidth / 4;
                //DrawTME(Theseus, theseusX, theseusY, false);
            }
            if (redrawMinotaur == true)
            {
                e.FillEllipse(Brushes.Black, Mino.PosX, Mino.PosY, (mapBuilder.tileWidth / 4 * 3) - 2, Mino.Height - 2);

                //DrawTME(Mino, minotaurX, minotaurY, false);
            }

            if (redrawExit == true)
            {
                e.FillRectangle(Brushes.White, Exit.PosX, Exit.PosY, Exit.Width, Exit.Height);
                Pen pen = new Pen(Color.Red);
                pen.Width = 4.0f;
                PointF point1 = new PointF(Exit.PosX + 2, Exit.PosY + 2);
                PointF point2 = new PointF(Exit.PosX + Exit.Width - 2, Exit.PosY + Exit.Width - 2);
                PointF point3 = new PointF(Exit.PosX + Exit.Width - 2, Exit.PosY + 2);
                PointF point4 = new PointF(Exit.PosX + 2, Exit.PosY + Exit.Width - 2);
                e.DrawLine(pen, point1, point2);
                e.DrawLine(pen, point3, point4);
                //Exit.PosX += mapBuilder.tileWidth / 4;
                //DrawTME(Exit, exitX, exitY, false);
            }
            // Exit is a char
        }

        private void DrawTME(ITile tile, Int32 x, Int32 y, Boolean redraw)
        {
            Graphics e = LevelDesignPanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            Single trim;
            Single tWidth = mapBuilder.tileWidth/4;

            if (tile is DrawTheseus)
            {
                if (mapBuilder.hasTheseus == true)
                {
                    tile = mapBuilder.TileList[x][y];
                    trim = tWidth;
                    e.FillRectangle(Brushes.White, tile.PosX - tWidth, tile.PosY, tile.Width, tile.Height);
                    e.FillEllipse(Brushes.Red, tile.PosX - tWidth, tile.PosY, (tWidth * 3) - 2, tile.Height - 2);
                }
            }
            else if (tile is DrawMinotaur)
            {
                if (mapBuilder.hasMinotaur == true)
                {
                    tile = mapBuilder.TileList[x][y];
                    trim = tWidth;
                    e.FillRectangle(Brushes.White, tile.PosX - tWidth, tile.PosY, tile.Width, tile.Height);
                    e.FillEllipse(Brushes.Black, tile.PosX - tWidth, tile.PosY, (tWidth * 3) - 2, tile.Height - 2);
                }
            }
            else if (tile is DrawExit)
            {
                if (mapBuilder.hasExit == true)
                {
                    tile = mapBuilder.TileList[x][y];
                    trim = tWidth;
                    e.FillRectangle(Brushes.White, tile.PosX - tWidth, tile.PosY, tile.Width, tile.Height);
                    pen.Width = 4.0f;
                    PointF point1 = new PointF(tile.PosX - tWidth + 2, tile.PosY + 2);
                    PointF point2 = new PointF(tile.PosX - tWidth + tile.Width - 2, tile.PosY + tile.Width - 2);
                    PointF point3 = new PointF(tile.PosX - tWidth + tile.Width - 2, tile.PosY + 2);
                    PointF point4 = new PointF(tile.PosX - tWidth + 2, tile.PosY + tile.Width - 2);
                    e.DrawLine(pen, point1, point2);
                    e.DrawLine(pen, point3, point4);
                }
            }
        }


        private void LevelDesignPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawMapOnPanel(mapBuilder.TileList);
        }

        private void ReplaceTilesOnClick(IBigTile bigTile, BigTilePosition selected, String firstChar, 
                                         String secondChar, String thirdChar,String fourthChar)
        { 
            Int32 row, col;
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    row = selected.sTileIndexes[k][j].row;
                    col = selected.sTileIndexes[k][j].col;
                    if (k == 0 && j == 0)
                    {
                        mapBuilder._2DMap[row][col] = firstChar;
                    }
                    if (k == 0 && j > 0)
                    {
                        mapBuilder._2DMap[row][col] = secondChar;
                    }
                    if (k == 1 && j == 0)
                    {
                        mapBuilder._2DMap[row][col] = thirdChar;
                    }
                    if (k == 1 && j > 0)
                    {
                        mapBuilder._2DMap[row][col] = fourthChar;
                    }
                }
                DrawMapOnPanel(bigTile.smallTiles);
            }
        }

        private void ReplaceOutsideWallOnClick(OutsideWallPos selected, Boolean changeToEmpty)
        {
            Int32 row, col;
            row = selected.walls[0].row;
            col = selected.walls[0].col;

            if (selected is OutsideRightWallsPos)
            {
                if (changeToEmpty == true)
                {
                    mapBuilder._2DMap[row + 1][col] = " ";
                }
                else
                {
                    mapBuilder._2DMap[row + 1][col] = "|";
                }
                

            }
            else if (selected is OutsideBottomWallsPos)
            {
                for (int i = 1; i < 4; i++)
                {
                    if (changeToEmpty == true)
                    {
                        //MessageBox.Show("" + row);
                        mapBuilder._2DMap[row][col + i] = " ";
                    }
                    else
                    {
                        mapBuilder._2DMap[row][col + i] = "_";
                    }
                }
            }
        }

        private void DeselectTileAndReDraw(BigTilePosition selected)
        {
            Int32 row, col;
            IBigTile bigTile;
            row = selected.sTileIndexes[0][0].row;
            col = col = selected.sTileIndexes[0][0].col;
            if (mapBuilder._2DMap[row][col + 1] == "_" && mapBuilder._2DMap[row + 1][col] == "|")
            {
                bigTile = new BigTileTopLeftWall(selected.iniPosX, selected.iniPosY, selected.width, selected.width);
                DrawMapOnPanel(bigTile.smallTiles);
            }
            else if (mapBuilder._2DMap[row][col + 1] == "_" && mapBuilder._2DMap[row + 1][col] == " ")
            {
                bigTile = new BigTileTopWall(selected.iniPosX, selected.iniPosY, selected.width, selected.width);
                DrawMapOnPanel(bigTile.smallTiles);
            }
            else if (mapBuilder._2DMap[row][col + 1] == " " && mapBuilder._2DMap[row + 1][col] == "|")
            {
                bigTile = new BigTileLeftWall(selected.iniPosX, selected.iniPosY, selected.width, selected.width);
                DrawMapOnPanel(bigTile.smallTiles);
            }else if (mapBuilder._2DMap[row][col + 1] == " " && mapBuilder._2DMap[row + 1][col] == " ")
            {
                bigTile = new BigTileEmpty(selected.iniPosX, selected.iniPosY, selected.width, selected.width);
                DrawMapOnPanel(bigTile.smallTiles);
            }

            if (bigTilesSelectPos.Count == 0)
            {
                bigTileIsClicked = false;
            }
        }

        private void DeselectWalls(OutsideWallPos selected)
        {
            Graphics e = LevelDesignPanel.CreateGraphics();
            Single width = mapBuilder.tileWidth/4;
            Int32 row, col;
            row = selected.walls[0].row;
            col = selected.walls[0].col;

            if (selected is OutsideRightWallsPos)
            {
                if (mapBuilder._2DMap[row +1][col] == "|")
                {
                    e.FillRectangle(Brushes.Blue, selected.iniPosX, selected.iniPosY, width, width * 4);

                }
                else
                {
                    e.FillRectangle(Brushes.White, selected.iniPosX, selected.iniPosY, width, width * 4);
                }
            }
            else if (selected is OutsideBottomWallsPos)
            {
                if (mapBuilder._2DMap[row][col + 1] == "_")
                {
                    e.FillRectangle(Brushes.Blue, selected.iniPosX, selected.iniPosY, width * 4, width);

                }
                else
                {
                    e.FillRectangle(Brushes.White, selected.iniPosX, selected.iniPosY, width * 4, width);
                }
            }

            if (rightWallSeclectPos.Count == 0)
            {

                hasClickedRightWall = false;
            } 
            if (bottomWallSeclectPos.Count == 0)
            {
                hasClickedBottomWall = false;
            }

        }

        private void ReplaceAndAddTile(Type className, String firstChar, String secChar, String thirdChar, String fourthChar)
        {
            BigTilePosition selected;
            IBigTile bigTile;
            object obj;
            if (bigTilesSelectPos.Count > 0)
            {
                for (int i = 0; i < bigTilesSelectPos.Count; i++)
                {
                    selected = bigTilesSelectPos[i];
                    obj = Activator.CreateInstance(className, selected.iniPosX, selected.iniPosY, selected.width, selected.width);
                    bigTile = (IBigTile)obj;
                    ReplaceTilesOnClick(bigTile, selected, firstChar, secChar, thirdChar, fourthChar);
                    DrawMapOnPanel(bigTile.smallTiles);
                }
            }

            bigTilesSelectPos.Clear();
            bigTileIsClicked = false;
            mapBuilder.ConvertStringListToObjectList();
        }

        private void TopLeftWallButton_Click(object sender, EventArgs e)
        {
            ReplaceAndAddTile(typeof(BigTileTopLeftWall), ".", "_", "|", " ");
        }

        private void TopWallButton_Click(object sender, EventArgs e)
        {
            ReplaceAndAddTile(typeof(BigTileTopWall), ".", "_", " ", " ");
        }

        private void LeftWallButton_Click(object sender, EventArgs e)
        {
            ReplaceAndAddTile(typeof(BigTileLeftWall), ".", " ", "|", " ");
        }

        private void EmptyTileButton_Click(object sender, EventArgs e)
        {
            ReplaceAndAddTile(typeof(BigTileEmpty), ".", " ", " ", " ");
            
        }

        private void ChangeWall(List<OutsideWallPos> wallList, Boolean changeToEmpty)
        {
            Graphics g = LevelDesignPanel.CreateGraphics();
            Single width = mapBuilder.tileWidth / 4;
            OutsideWallPos myWall;
            Single x, y;

            if (wallList.Count > 0)
            {
                for (int i = 0; i < wallList.Count; i++)
                {
                    myWall = wallList[i];
                    x = myWall.iniPosX;
                    y = myWall.iniPosY;

                    ReplaceOutsideWallOnClick(myWall, changeToEmpty);
                    for (int j = 0; j < 4; j++)
                    {
                        if (changeToEmpty == true)
                        {
                            g.FillRectangle(Brushes.White, x, y, width, width);
                        }
                        else
                        {
                            g.FillRectangle(Brushes.Blue, x, y, width, width);
                        }
                        
                        if (myWall is OutsideBottomWallsPos)
                        {
                            x += width;
                        }
                        else if (myWall is OutsideRightWallsPos)
                        {
                            y += width;
                        }
                    }
                }

                wallList.Clear();
            }
            LevelDesignPanel.Update();
        }

        

        private void EmptyBotWallBtn_Click(object sender, EventArgs e)
        {
            ChangeWall(bottomWallSeclectPos, true);
            hasClickedBottomWall = false;
            mapBuilder.ConvertStringListToObjectList();
            
        }

        private void HorizontalWallButton_Click(object sender, EventArgs e)
        {
            ChangeWall(bottomWallSeclectPos, false);
            hasClickedBottomWall = false;
            mapBuilder.ConvertStringListToObjectList();
        }

        private void VerticalWallButton_Click(object sender, EventArgs e)
        {
            ChangeWall(rightWallSeclectPos, false);
            hasClickedRightWall = false;
            mapBuilder.ConvertStringListToObjectList();
        }

        private void EmptyRightWallBtn_Click(object sender, EventArgs e)
        {
            ChangeWall(rightWallSeclectPos, true);
            hasClickedRightWall = false;
            mapBuilder.ConvertStringListToObjectList();
        }

        private void MoveTME(String theChar, ITile tile, String alert, Boolean hasTME)
        { 
            Graphics g = LevelDesignPanel.CreateGraphics();
            BigTilePosition selected;
            //IBigTile bigTile;
            Int32 row, col;
            Boolean found = false;

            if (bigTilesSelectPos.Count == 1)
            {
                for (int i = 0; i < mapBuilder._2DMap.Count; i++)
                {
                    for (int j = 0; j < mapBuilder._2DMap[i].Count; j++)
                    {
                        if (mapBuilder._2DMap[i][j] == theChar)
                        {
                            mapBuilder._2DMap[i][j] = " ";
                            found = true;
                            if (hasTME == true)
                            {
                                g.FillRectangle(Brushes.White, tile.PosX, tile.PosY, tile.Width, tile.Height);
                                break;
                            }
                        }
                    }
                    if (found == true)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < bigTilesSelectPos.Count; i++)
            {
                DeselectTileAndReDraw(bigTilesSelectPos[i]);
            }

            if (bigTilesSelectPos.Count == 1)
            {
                selected = bigTilesSelectPos[0];
                row = selected.sTileIndexes[0][0].row;
                col = selected.sTileIndexes[0][0].col;
                mapBuilder._2DMap[row + 1][col + 2] = theChar;

                if (hasTME == true)
                {
                    tile.PosX = selected.iniPosX + mapBuilder.tileWidth / 4;
                    tile.PosY = selected.iniPosY + mapBuilder.tileWidth / 4;
                    DrawTME(tile, row + 1, col + 2, true);
                }
                else
                {
                    mapBuilder.ConvertStringListToObjectList();
                    DrawMapOnPanel(mapBuilder.TileList);
                }
                
            }
            else
            {
                MessageBox.Show(alert);
            }

            bigTilesSelectPos.Clear();
            bigTileIsClicked = false;
        }

        private void AddTheseusButton_Click(object sender, EventArgs e)
        {

            MoveTME("T", Theseus, AlertOutput.alertT, mapBuilder.hasTheseus);
            mapBuilder.ConvertStringListToObjectList();
            
        }

        private void AddMinotaurButton_Click(object sender, EventArgs e)
        {
            MoveTME("M", Mino, AlertOutput.alertM, mapBuilder.hasMinotaur);
            mapBuilder.ConvertStringListToObjectList();
        }

        private void AddExitBtn_Click(object sender, EventArgs e)
        {
            MoveTME("X", Exit, AlertOutput.alertE, mapBuilder.hasExit);
            mapBuilder.ConvertStringListToObjectList();
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

        private void SaveMapBtn_Click(object sender, EventArgs e)
        {
            fs = new FilerSave();
            fs.mapTextBox.AppendText(ConverToString());
            fs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawMapOnPanel(mapBuilder.TileList);
        }

        
    }
}
