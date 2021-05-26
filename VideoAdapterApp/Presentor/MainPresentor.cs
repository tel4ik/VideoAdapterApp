using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

using VideoAdapterApp.Domain;
using VideoAdapterApp.View;
using VideoAdapterApp.DAL;


namespace VideoAdapterApp.Presentor
{
    public class MainPresentor : IPresentor
    {
        public IView View { get; }
        private IVideoKatalog service { get; set; }

        private List<VideoCard> _katalog;
        private List<VideoCard> CompareVD = new List<VideoCard> { };
        public MainPresentor(IView view, IVideoKatalog creater)
        {
            View = view;

            service = creater;
            _katalog = service.GetKatalog().VideoCards.ToList();
            View.katalog = _katalog;
            View.ShowSpecification = _katalog[0];

            View.SelectedVideoCardChanged += SelectedVD;

            View.DeleteVideoCard += DeleteSelectedVD;
            View.DeleteFromCompareList += DeleteVDfromCompare;

            View.ClearGridButton += ClearGrid;
            View.AddVideoCard += AddVD;

            View.ShowMainL += ShowMainList;
            View.ShowCompareList += ShowCompareList;

            View.AddToCompareList += AddToCompare;

            View.DropCompareListInFile += DropCompareList;


            View.Show();
        }

        private void SelectedVD(object sender, EventArgs e)
        {
            View.ShowSpecification = View.SelectedVideoCard;            
        }

        private void DeleteSelectedVD(object sender, EventArgs e)
        {

            _katalog.Remove(View.SelectedVideoCard);
            View.katalog = _katalog;

        }

        private void ClearGrid(object sender, EventArgs e)
        {
            View.ClearGrid();
        }

        private void AddVD(object sender, EventArgs e)
        {
            VideoCard VD = new VideoCard();
            VD = View.TakeFromGrid;
            _katalog.Add(VD);
            View.katalog = _katalog;
        }

        private void ShowMainList(object sender, EventArgs e)
        {
            View.katalog = _katalog;
        }

        private void ShowCompareList(object sender, EventArgs e)
        {
            
            View.katalog = CompareVD;
        }

        private void DeleteVDfromCompare(object sender, EventArgs e)
        {
            View.DeleteVideoCard -= DeleteSelectedVD;

            CompareVD.Remove(View.SelectedVideoCard);
            View.katalog = CompareVD;
            if (CompareVD == null) { View.katalog = _katalog; }

            View.DeleteVideoCard += DeleteSelectedVD;
        }

        private void AddToCompare(object sender, EventArgs e)
        {
            CompareVD.Add(View.SelectedVideoCard);
        }

        private void DropCompareList(object sender, EventArgs e)
        {
            string fileName = @".\Content\CompareVidecart.xlsx";
            List<string> chars = new List<string> { "B", "C", "D", "E", "F", "G", "H", "I", "J", };

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWb = xlApp.Workbooks.Open(fileName); 
            Excel.Worksheet xlSht = xlWb.Sheets[1]; 

            int iLastRow = 0;
            int N = CompareVD.Count;
            Specification spec = new Specification();
            List<string> Specific = spec.CreateSpec();

            for (int i = 0; i < 19; i++)
            {
                iLastRow++;
                xlSht.Cells[iLastRow, "A"].Value = Specific[i];
            }



            for (int j = 0; j < N; j++)
            {
                xlSht.Cells[1, chars[j]].Value = CompareVD[j].name;
                xlSht.Cells[2, chars[j]].Value = CompareVD[j].Core;
                xlSht.Cells[3, chars[j]].Value = CompareVD[j].technicalProcess;
                xlSht.Cells[4, chars[j]].Value = CompareVD[j].transistor;
                xlSht.Cells[5, chars[j]].Value = CompareVD[j].frequency;
                xlSht.Cells[6, chars[j]].Value = CompareVD[j].frequencyShaders;
                xlSht.Cells[7, chars[j]].Value = CompareVD[j].ShadersBlocks;
                xlSht.Cells[8, chars[j]].Value = CompareVD[j].TMU;
                xlSht.Cells[9, chars[j]].Value = CompareVD[j].ROP;
                xlSht.Cells[10, chars[j]].Value = CompareVD[j].frequencyMem;
                xlSht.Cells[11, chars[j]].Value = CompareVD[j].busMem;
                xlSht.Cells[12, chars[j]].Value = CompareVD[j].TypeMem;
                xlSht.Cells[13, chars[j]].Value = CompareVD[j].ValueMem;
                xlSht.Cells[14, chars[j]].Value = CompareVD[j].DirectX;
                xlSht.Cells[15, chars[j]].Value = CompareVD[j].Interface;
                xlSht.Cells[16, chars[j]].Value = CompareVD[j].energy;
                xlSht.Cells[17, chars[j]].Value = CompareVD[j].date;
                xlSht.Cells[18, chars[j]].Value = CompareVD[j].price;
                xlSht.Cells[19, chars[j]].Value = CompareVD[j].url;


            }
            xlWb.Close(true); //закрыть и сохранить книгу
            xlApp.Quit();
            MessageBox.Show("Файл успешно сохранён!");
        }

    }
}
