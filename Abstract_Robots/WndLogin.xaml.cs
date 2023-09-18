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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            workers = AllWorkersLst();
            activeRobots = AllRobotsLst();
            activeMissions = AllMissionsLst();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }

        //משימה 1
        public List<Worker> AllWorkersLst()
        {
            List<Worker> workersLst = new List<Worker>();
            workersLst.Add(new OperationalWorker("Jake", "123456789", DateTime.Now, "pass1", 40, 12));
            workersLst.Add(new OperationalWorker("Emma", "223456789", DateTime.Now, "pass2", 40, 12));
            workersLst.Add(new OperationalWorker("Mike", "323456789", DateTime.Now, "pass3", 32, 10));
            workersLst.Add(new OperationManager(52.5, 8, 2, "Josef", "987654321", DateTime.Now, "4pass"));
            workersLst.Add(new OperationManager(55, 12, 2, "Samantha", "887654321", DateTime.Now, "5pass"));
            workersLst.Add(new GeneralManager(20000, 10, 4, "Jimmy", "1928374655", DateTime.Now, "6pass6"));
            return workersLst;
        }

        //משימה 2
        public List<RobotSpy> AllRobotsLst()
        {
            List<RobotSpy> robotsLst = new List<RobotSpy>();
            robotsLst.Add(new RobotWheels());
            robotsLst.Add(new RobotWheels());
            robotsLst.Add(new RobotWheels());
            robotsLst.Add(new RobotQuad());
            robotsLst.Add(new RobotQuad());
            robotsLst.Add(new RobotQuad());
            robotsLst.Add(new RobotFly());
            robotsLst.Add(new RobotFly());
            return robotsLst;
        }


        //משימה 3
        public List<Mission> AllMissionsLst()
        {
            List<Mission> missionsLst = new List<Mission>();
            missionsLst.Add(new Mission(DateTime.Now, "desc1"));
            missionsLst.Add(new Mission(DateTime.Now, "desc2"));
            missionsLst.Add(new Mission(DateTime.Now, "desc3"));
            missionsLst.Add(new Mission(DateTime.Now, "desc4"));
            missionsLst.Add(new Mission(DateTime.Now, "desc5"));
            return missionsLst;
        }


        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //...אם מספר הזיהוי והסיסמה תואמים לעובד ברשימה, אז

            foreach (var w in workers)
            {
                if (tbxID.Text.Equals(w.GetIdNumber())
                    && tbxPassword.Password.Equals(w.GetPassword()))
                {
                    Worker worker = w;
                    WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                    return;
                }
            }
        }
    }
}
