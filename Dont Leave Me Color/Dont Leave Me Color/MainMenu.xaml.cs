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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Dont_Leave_Me_Color
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        Storyboard mystory = new Storyboard();
        DispatcherTimer timer = new DispatcherTimer();
        int i = 0;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.Focus();
            mystory = (Storyboard)this.Resources["moving"];
            mystory.Begin(this);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(movement);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60); // = 60FPS  1000ms/60
            timer.Start();
        }

        private void movement(object sender, EventArgs e)
        {
            if (Canvas.GetLeft(home) >= -300)
            {
                Canvas.SetLeft(home, Canvas.GetLeft(home) - 5);
            }
            else
            {
                Canvas.SetLeft(home, 1300);
            }

            if (Canvas.GetLeft(tree) >= -300)
            {
                Canvas.SetLeft(tree, Canvas.GetLeft(tree) - 5);
            }
            else
            {
                Canvas.SetLeft(tree, 1300);
            }

            if (Canvas.GetLeft(bike) >= -300)
            {
                Canvas.SetLeft(bike, Canvas.GetLeft(bike) - 5);
            }
            else
            {
                Canvas.SetLeft(bike, 1300);
            }
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                mystory.Stop();
                timer.Tick += new EventHandler(ender);
                timer.Interval = new TimeSpan(0, 0, 0, 1, 0); // = 60FPS  1000ms/60
                timer.Start();
            }

        }

        private void ender(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                mystory = (Storyboard)this.Resources["end"];
                mystory.Begin(this);
            }
            else if (i == 3)
            {
                mystory.Stop();
                timer.Stop();
                this.NavigationService.Navigate(new Uri("HowToPlay.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
