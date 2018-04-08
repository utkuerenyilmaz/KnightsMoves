using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtinHareketi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Size = 5, Score = 0 ; //GameBoard sınırları için Size ve Oyunda Skor için Score tanımlandı

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //Yeni Oyun Başlatma 
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Score = 0; //Skor 0lanıyor

            //RadioButton lardan size seçiliyor
            if (radioFive.Checked)
                Size = 5;
            else if (radioSix.Checked)
                Size = 6;
            else if (radioSeven.Checked)
                Size = 7;
            else if (radioEight.Checked)
                Size = 8;
            else if (radioNine.Checked)
                Size = 9;

            //Oyun tahtası oluşturuluyor
            GameBoard.Enabled = true; 
            GameBoard.Rows.Clear(); 
            GameBoard.Columns.Clear();
            GameBoard.Size = new Size(Size * 51, Size * 51);

            for (int i = 0; i < Size; i++)
            {
                GameBoard.Columns.Add(null,null);
                GameBoard.Rows.Add();
                DataGridViewColumn column = GameBoard.Columns[i]; //Size kadar column
                DataGridViewRow row = GameBoard.Rows[i]; //Size kadar row

                //Satır-Sütun boyutları ayarlanıyor
                row.Height = 50;
                column.Width = 50;
            }

            //Oyun başladığında Oyun Durumları gösteriliyor
            grpPossibleMoves.Visible = true;
            grpResult.Visible = true;
        }


        //Oyun tahtasında seçilen hücreye tıklama
        private void OyunTahtasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen pozisyon değerleri tutuluyor.
            int PositionX = GameBoard.CurrentCell.RowIndex; 
            int PositionY = GameBoard.CurrentCell.ColumnIndex;

            
            if (GameBoard.Rows[PositionX].Cells[PositionY].Style.BackColor == Color.SteelBlue || Score == 0) 
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (GameBoard.Rows[i].Cells[j].Style.BackColor != Color.LightSeaGreen)
                            GameBoard.Rows[i].Cells[j].Style.BackColor = Color.WhiteSmoke;
                    } 
                }

                Score++;
                GameBoard.Rows[GameBoard.CurrentCell.RowIndex].Cells[GameBoard.CurrentCell.ColumnIndex].Value = Score;
                GameBoard.Rows[GameBoard.CurrentCell.RowIndex].Cells[GameBoard.CurrentCell.ColumnIndex].Style.BackColor = Color.LightSeaGreen;


                int PossibleMoveCounter=0; //Gidilebilecek muhtemel hamle sayısı tutuluyor - 0lanıyor


                //Atın gidebileceği pozisyonlar kontrol ediliyor
                // (+2,+1) (+2,-1) (-2,+1) (-2,-1) (+1,+2) (+1,-2) (-1,+2) (-1,-2)
                //Hamlelerinden birine gidilebiliyorsa muhtemel hamle sayısı arttırılıyor
                if (PositionX + 2 < Size && PositionY + 1 < Size && GameBoard.Rows[PositionX + 2].Cells[PositionY + 1].Style.BackColor != Color.LightSeaGreen) //+2,+1
                {
                    GameBoard.Rows[PositionX + 2].Cells[PositionY + 1].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                }

                if (PositionX + 2 < Size && PositionY - 1 >= 0 && GameBoard.Rows[PositionX + 2].Cells[PositionY - 1].Style.BackColor != Color.LightSeaGreen) //+2,-1
                {
                    GameBoard.Rows[PositionX + 2].Cells[PositionY - 1].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                }

                if (PositionX - 2 >= 0 && PositionY + 1 < Size && GameBoard.Rows[PositionX - 2].Cells[PositionY + 1].Style.BackColor != Color.LightSeaGreen)  //-2,+1
                {
                    GameBoard.Rows[PositionX - 2].Cells[PositionY + 1].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                }
                if (PositionX - 2 >= 0 && PositionY - 1 >= 0 && GameBoard.Rows[PositionX - 2].Cells[PositionY - 1].Style.BackColor != Color.LightSeaGreen) //-2,-1
                {
                    GameBoard.Rows[PositionX - 2].Cells[PositionY - 1].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                }
                if (PositionX + 1 < Size && PositionY + 2 < Size && GameBoard.Rows[PositionX + 1].Cells[PositionY + 2].Style.BackColor != Color.LightSeaGreen) //+1,+2
                {
                    GameBoard.Rows[PositionX + 1].Cells[PositionY + 2].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                } 
                if (PositionX + 1 < Size && PositionY - 2 >= 0 && GameBoard.Rows[PositionX + 1].Cells[PositionY - 2].Style.BackColor != Color.LightSeaGreen) //+1,-2
                {
                    GameBoard.Rows[PositionX + 1].Cells[PositionY - 2].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                }
                if (PositionX - 1 >= 0 && PositionY + 2 < Size && GameBoard.Rows[PositionX - 1].Cells[PositionY + 2].Style.BackColor != Color.LightSeaGreen) //-1,+2
                {
                    GameBoard.Rows[PositionX - 1].Cells[PositionY + 2].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                }
                    
                if (PositionX - 1 >= 0 && PositionY - 2 >= 0 && GameBoard.Rows[PositionX - 1].Cells[PositionY - 2].Style.BackColor != Color.LightSeaGreen) //-1,-2
                {
                    GameBoard.Rows[PositionX - 1].Cells[PositionY - 2].Style.BackColor = Color.SteelBlue;
                    PossibleMoveCounter++;
                }


                if (PossibleMoveCounter != 0) // Muhtemel hamle varsa
                {
                    lblMoveCounter.Text = "There are " + PossibleMoveCounter + " possible moves."; //Muhtemelen hamle sayısı yazdırılıyor
                    lblGameResult.Text = "Oyun devam ediyor.";
                }
                    
                else // Muhtemelen hamle kalmadıysa
                {
                    lblGameResult.ForeColor = Color.Red; //Oyun ekranı kırmızı oluyor
                    lblMoveCounter.ForeColor = Color.Red;
                    for(int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j<Size; j++)
                             GameBoard.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    lblMoveCounter.Text = "There are no possible moves!"; 
                    lblGameResult.Text = "FAILURE, TRY AGAIN!"; //Başarısız mesajı gösteriliyor
                }

                if(Score == Size*Size) // Oyun bittiyse
                {
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size; j++)
                            GameBoard.Rows[i].Cells[j].Style.BackColor = Color.Green; // Oyun ekranı yeşil oluyor
                    }
                    lblMoveCounter.Text = "";
                    lblGameResult.ForeColor = Color.Green;
                    lblGameResult.Text = "CONGRATS, YOU WON!"; // Başarı mesajı gösteriliyor
                }
            }
            if (GameBoard.Rows[PositionX].Cells[PositionX].Style.BackColor == Color.Yellow)
            {
                GameBoard.Rows[PositionX].Cells[PositionY].Value = Score;
                GameBoard.Rows[PositionX].Cells[PositionY].Style.BackColor = Color.GreenYellow;
            }
        }

        

    }
}
