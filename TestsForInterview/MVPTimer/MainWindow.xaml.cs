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
using System.Timers;

namespace MVPTimer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model model = new Model();
            Presenter presenter = new Presenter(model, this);
        }

        public event System.EventHandler startButton_ClickEvent;
        public event System.EventHandler pauseButton_ClickEvent;
        public event System.EventHandler breakButton_ClickEvent;

        async private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startButton_ClickEvent.BeginInvoke(sender, e, null, null);
        }

        async private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            pauseButton_ClickEvent.Invoke(sender, e);
        }

        async private void breakButton_Click(object sender, RoutedEventArgs e)
        {
            breakButton_ClickEvent.Invoke(sender, e);
        }


    }
}
