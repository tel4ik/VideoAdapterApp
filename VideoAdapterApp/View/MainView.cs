using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoAdapterApp.Domain;


namespace VideoAdapterApp.View
{
    public partial class MainView : Form, IView
    {
        const int N = 19;
        public MainView()
        {
            InitializeComponent();
        }
        public IEnumerable<VideoCard> katalog
        {
            set
            {
                listBox1.DataSource = value.ToList();
            }
        }

        public VideoCard SelectedVideoCard
        {
            get => listBox1.SelectedItem as VideoCard;
            set => listBox1.SelectedItem = value;
        }

        public event EventHandler AddVideoCard
        {
            add { button1.Click += value; }
            remove { button1.Click -= value;  }
        }


        public event EventHandler SelectedVideoCardChanged
        {
            add { listBox1.SelectedIndexChanged += value;  }
            remove { listBox1.SelectedIndexChanged -= value;  }
        }

        public event EventHandler ClearGridButton
        {
            add { добавитьВидеокартыToolStripMenuItem.Click += value; }
            remove { добавитьВидеокартыToolStripMenuItem.Click -= value; }
        }

        public event EventHandler ShowMainL
        {
            add { полныйСписокВидеокартToolStripMenuItem.Click += value; button2.Visible = false; }
            remove { полныйСписокВидеокартToolStripMenuItem.Click -= value; }
        }

        public event EventHandler ShowCompareList
        {
            add { списокКартДляСравненияToolStripMenuItem.Click += value; button2.Visible = true; }
            remove { списокКартДляСравненияToolStripMenuItem.Click -= value; }
        }

        public event EventHandler AddToCompareList
        {
            add { добавитьКСравнениюВидеокартуToolStripMenuItem.Click += value;  }
            remove { добавитьКСравнениюВидеокартуToolStripMenuItem.Click -= value; }
        }

        
        public event EventHandler DeleteFromCompareList
        {
            add { button2.Click += value; }
            remove { button2.Click -= value; }
        }

        public event EventHandler DropCompareListInFile
        {
            add { button3.Click += value;  }
            remove { button3.Click -= value; }
        }
        public void ClearGrid()
        {
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = "                                               ";
            }
            button1.Visible = true;
            MessageBox.Show(Text = "Введите данные видеокарты в соответствующие ячейки таблицы");
        }

        public event EventHandler DeleteVideoCard
        {
            add { удалитьВыбраннуюВидеокартуToolStripMenuItem.Click += value;  }
            remove { удалитьВыбраннуюВидеокартуToolStripMenuItem.Click -= value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public VideoCard ShowSpecification
        {
            set {
                Specification sp = new Specification();
                List<string> _spec = sp.CreateSpec();
                List<string> _videocard = sp.CreateVideoSpec(value);
                dataGridView1.ColumnCount = 2;
                dataGridView1.RowCount = N;
                dataGridView1.Columns[0].Width = 90;
                dataGridView1.Columns[1].Width = 100;

                for (int i = 0; i < N; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = _spec[i];
                    dataGridView1.Rows[i].Cells[1].Value = _videocard[i];
                }
            }
        }

        public VideoCard TakeFromGrid
        {
            get
            {
                VideoCard _videocard = new VideoCard();
                _videocard.name = dataGridView1.Rows[0].Cells[1].Value.ToString();
                _videocard.Core = dataGridView1.Rows[1].Cells[1].Value.ToString();
                _videocard.technicalProcess = dataGridView1.Rows[2].Cells[1].Value.ToString();
                _videocard.transistor = dataGridView1.Rows[3].Cells[1].Value.ToString();
                _videocard.frequency = dataGridView1.Rows[4].Cells[1].Value.ToString();
                _videocard.frequencyShaders = dataGridView1.Rows[5].Cells[1].Value.ToString();
                _videocard.ShadersBlocks = dataGridView1.Rows[6].Cells[1].Value.ToString();
                _videocard.TMU = dataGridView1.Rows[7].Cells[1].Value.ToString();
                _videocard.ROP = dataGridView1.Rows[8].Cells[1].Value.ToString();
                _videocard.frequencyMem = dataGridView1.Rows[9].Cells[1].Value.ToString();
                _videocard.busMem = dataGridView1.Rows[10].Cells[1].Value.ToString();
                _videocard.TypeMem = dataGridView1.Rows[11].Cells[1].Value.ToString();
                _videocard.ValueMem = dataGridView1.Rows[12].Cells[1].Value.ToString();
                _videocard.DirectX = dataGridView1.Rows[13].Cells[1].Value.ToString();
                _videocard.Interface = dataGridView1.Rows[14].Cells[1].Value.ToString();
                _videocard.energy = dataGridView1.Rows[15].Cells[1].Value.ToString();
                _videocard.date = dataGridView1.Rows[16].Cells[1].Value.ToString();
                _videocard.price = dataGridView1.Rows[17].Cells[1].Value.ToString();
                _videocard.url = dataGridView1.Rows[18].Cells[1].Value.ToString();

                button1.Visible = false;
                return _videocard;
            }
        }

        public new void Show()
        {
            Application.Run(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
