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

namespace BeatGorilla
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// スタートボタン : 押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            var storyboard = new Storyboard();

            var a = new DoubleAnimation();

            Storyboard.SetTarget(a, rect1);
            Storyboard.SetTargetProperty(a, new PropertyPath("(Canvas.Top)"));
            a.To = 700;
            a.Duration = TimeSpan.FromSeconds(1);
            storyboard.Children.Add(a);

            var c = new DoubleAnimationUsingKeyFrames();

            Storyboard.SetTarget(c, rect2);
            Storyboard.SetTargetProperty(c, new PropertyPath("(Canvas.Top)"));
            a.Duration = TimeSpan.FromSeconds(10);

            c.KeyFrames.Add(new LinearDoubleKeyFrame(300, TimeSpan.FromSeconds(1)));
            c.KeyFrames.Add(new LinearDoubleKeyFrame(200, TimeSpan.FromSeconds(2)));

            storyboard.Children.Add(c);

            // アニメーションを開始します
            storyboard.Begin();
        }
    }
}
