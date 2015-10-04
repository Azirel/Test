using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MVPTimer
{
    
    class Presenter
    {
        Model model;
        MainWindow window;
        
        public Presenter(Model model,MainWindow window)
        {
            this.model = model;
            this.window = window;
            this.Initialize();
        }
        delegate void ShowTimeDelegate(System.Windows.Controls.Label label,System.Diagnostics
            .Stopwatch watch);
        void Initialize()
        {
            window.startButton_ClickEvent += Start; //Комментарий для GIT'a v1.1
            window.pauseButton_ClickEvent += Pause;
            window.breakButton_ClickEvent += Reset;
        }
        async void Start(object sender, EventArgs e)
        {
            model.StartWatch();
            //await ShowTime();
            //Task showTime = new Task(ShowTime);
            //showTime.Start();
            Action showTime = ShowTime;
            //showTime.BeginInvoke(null, null);
            window.labelTime.Dispatcher.BeginInvoke(showTime, null);

        }
        void  ShowTime()
        {
            while (model.watch.IsRunning)
            {
                window.labelTime.Content= model.watch.Elapsed;
                Thread.Sleep(50);
            }
        }
        void Pause(object sender, EventArgs e)
        {
            window.labelTime.Content = model.watch.Elapsed;
            model.StopWatch();
        }
        void Reset(object sender, EventArgs e)
        {
            model.ResetWatch();
            window.labelTime.Content = "";
        }
    }
}
