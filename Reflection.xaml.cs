using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Drawing
{
    /// <summary>
    /// Interaction logic for Reflection.xaml
    /// </summary>

    public partial class Reflection : System.Windows.Window
    {

        public Reflection()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            double startHeight = txt.ActualHeight;
            Console.WriteLine(startHeight);
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = startHeight,
                To = startHeight / 2,
                Duration = new TimeSpan(0, 0, 2),
                RepeatBehavior = RepeatBehavior.Forever,
                AutoReverse = true
            };
            rect.BeginAnimation(Rectangle.HeightProperty, animation);
            base.OnActivated(e);
        }
    }
}