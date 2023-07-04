using System.Windows;
using System.Windows.Controls;

namespace PuzzleGame
{
    public partial class MainWindow : Window
    {
        private Button b1, b2, b3, b4, b5, b6, b7, b8, b9, next;

        public MainWindow()
        {
            InitializeComponent();
            CreateButtons();
        }

        private void InitializeComponent()
        {
            Title = "Puzzle Game - JavaTpoint";
            Width = 250;
            Height = 300;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            MaxHeight = MinHeight = Height;
            MaxWidth = MinWidth = Width;
        }

        private void CreateButtons()
        {
            b1 = new Button { Content = "1", Width = 50, Height = 40, Margin = new Thickness(10, 30, 0, 0) };
            b2 = new Button { Content = " ", Width = 50, Height = 40, Margin = new Thickness(70, 30, 0, 0) };
            b3 = new Button { Content = "3", Width = 50, Height = 40, Margin = new Thickness(130, 30, 0, 0) };
            b4 = new Button { Content = "4", Width = 50, Height = 40, Margin = new Thickness(10, 80, 0, 0) };
            b5 = new Button { Content = "5", Width = 50, Height = 40, Margin = new Thickness(70, 80, 0, 0) };
            b6 = new Button { Content = "6", Width = 50, Height = 40, Margin = new Thickness(130, 80, 0, 0) };
            b7 = new Button { Content = "7", Width = 50, Height = 40, Margin = new Thickness(10, 130, 0, 0) };
            b8 = new Button { Content = "8", Width = 50, Height = 40, Margin = new Thickness(70, 130, 0, 0) };
            b9 = new Button { Content = "2", Width = 50, Height = 40, Margin = new Thickness(130, 130, 0, 0) };
            next = new Button { Content = "next", Width = 100, Height = 40, Margin = new Thickness(70, 200, 0, 0) };

            b1.Click += Button_Click;
            b2.Click += Button_Click;
            b3.Click += Button_Click;
            b4.Click += Button_Click;
            b5.Click += Button_Click;
            b6.Click += Button_Click;
            b7.Click += Button_Click;
            b8.Click += Button_Click;
            b9.Click += Button_Click;
            next.Click += Button_Click;

            var stackPanel = new StackPanel();
            stackPanel.Children.Add(b1);
            stackPanel.Children.Add(b2);
            stackPanel.Children.Add(b3);
            stackPanel.Children.Add(b4);
            stackPanel.Children.Add(b5);
            stackPanel.Children.Add(b6);
            stackPanel.Children.Add(b7);
            stackPanel.Children.Add(b8);
            stackPanel.Children.Add(b9);
            stackPanel.Children.Add(next);

            Content = stackPanel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            // Rest of your button click logic
            // ...
        }

        public static void Main()
        {
            Application app = new Application();
            app.Run(new MainWindow());
        }
    }
}
