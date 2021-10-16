using System.Windows;

namespace AnimalWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewer
    {
        public string Information { set => OutputText.Text = value; }

        public string Request { get => InputText.Text; }

        Presenter presenter;

        public MainWindow()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            okBtn.Click += (s, e) => presenter.GetResult();
            btnTxt.Click += (s, e) => presenter.SaveToTxt(InputText.Text, OutputText.Text);
            btnCsv.Click += (s, e) => presenter.SaveToCsv(InputText.Text, OutputText.Text);
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    presenter.GetResult();
        //}
    }
}
