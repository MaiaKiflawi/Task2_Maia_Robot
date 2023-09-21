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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UCworker.xaml
    /// </summary>
    public partial class UCworker : UserControl
    {
        public UCworker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker; //binding✅
            lbID.Content = worker.GetIdNumber();
            lbBday.Content = IsBirthday(worker) + worker.GetBirthDate().ToShortDateString() + IsBirthday(worker);
            if (worker is GeneralManager)
            {
                lbWRole.Content = "General Manager";
                lbWRole.FontWeight = FontWeights.UltraBold;
            }
            else if (worker is OperationManager)
            {
                lbWRole.Content = "Operational Manager";
                lbWRole.FontWeight = FontWeights.Bold;
            }
            else
            {
                lbWRole.Content = "Operational Worker";
            }
            brMain.Background = BgColour(worker);
        }

        public SolidColorBrush BgColour(Worker worker)
        {
            if (worker is GeneralManager)
            {
                return Brushes.LightBlue;
            }
            else if (worker is OperationManager)
            {
                return Brushes.LightGray;
            }
            return Brushes.Beige;
        }

        public string IsBirthday(Worker worker)
        {
            if (worker.GetBirthDate().Day.Equals(DateTime.Today.Day) && worker.GetBirthDate().Month.Equals(DateTime.Today.Month))
                return "🎂";
            return "";
        }
    }
}
