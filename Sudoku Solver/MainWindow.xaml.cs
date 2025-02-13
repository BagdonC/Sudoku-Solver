// Ignore Spelling: Sudoku

using System;
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
using Sudoku_Solver.Logic;

namespace Sudoku_Solver
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Solver Solver;

        public MainWindow()
        {
            InitializeComponent();
            int[,] mat = new int[9,9];
            mat = this.ConvertTxtsToInt(new List<string> { this.txt11.Text, this.txt12.Text, this.txt13.Text, this.txt14.Text, this.txt15.Text, this.txt16.Text, this.txt17.Text, this.txt18.Text, this.txt19.Text,
                this.txt21.Text, this.txt22.Text, this.txt23.Text, this.txt24.Text, this.txt25.Text, this.txt26.Text, this.txt27.Text, this.txt28.Text, this.txt29.Text,
                this.txt31.Text, this.txt32.Text, this.txt33.Text, this.txt34.Text, this.txt35.Text, this.txt36.Text, this.txt37.Text, this.txt38.Text, this.txt39.Text,
                this.txt41.Text, this.txt42.Text, this.txt43.Text, this.txt44.Text, this.txt45.Text, this.txt46.Text, this.txt47.Text, this.txt48.Text, this.txt49.Text,
                this.txt51.Text, this.txt52.Text, this.txt53.Text, this.txt54.Text, this.txt55.Text, this.txt56.Text, this.txt57.Text, this.txt58.Text, this.txt59.Text,
                this.txt61.Text, this.txt62.Text, this.txt63.Text, this.txt64.Text, this.txt65.Text, this.txt66.Text, this.txt67.Text, this.txt68.Text, this.txt69.Text,
                this.txt71.Text, this.txt72.Text, this.txt73.Text, this.txt74.Text, this.txt75.Text, this.txt76.Text, this.txt77.Text, this.txt78.Text, this.txt79.Text,
                this.txt81.Text, this.txt82.Text, this.txt83.Text, this.txt84.Text, this.txt85.Text, this.txt86.Text, this.txt87.Text, this.txt88.Text, this.txt89.Text,
                this.txt91.Text, this.txt92.Text, this.txt93.Text, this.txt94.Text, this.txt95.Text, this.txt96.Text, this.txt97.Text, this.txt98.Text, this.txt99.Text });

            this.Solver = new Solver(mat);
        }

        private int[,] ConvertTxtsToInt(List<string> texts)
        {
            int[,] values = new int[9,9];
            int i = 0;
            int y = 0;

            foreach(var text in texts)
            {
                if (text == string.Empty)
                    values[y,i] = 0;
                else
                    values[y,i] = Int32.Parse(text);

                if (i == 9)
                {
                    i = 0;
                    y++;
                }
                else
                    i++;
            }

            return values;
        }
    }
}
