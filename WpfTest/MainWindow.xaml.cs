using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public IEnumerable Colours_P { get; }

        public MainWindow()
        {
            //Test
            InitializeComponent();
            //cmbColors.ItemsSource = Colours;
            //this.DataContext = this;
            //this.GroupBoxes = new ObservableCollection<GroupBox>();
            //this.GroupBoxes.Add(new GroupBox() { Name = "AAA", Header = "AAA", Height = 100, Background = Brushes.Purple });
            //this.GroupBoxes.Add(new GroupBox() { Name = "BBB", Header = "BBB", Height = 100, Background = Brushes.Purple });
            //this.GroupBoxes.Add(new GroupBox() { Name = "CCC", Header = "CCC", Height = 100, Background = Brushes.Purple });
            //this.GroupBoxes.Add(new GroupBox() { Name = "DDD", Header = "DDD", Height = 100, Background = Brushes.Purple });
            //this.GroupBoxes.Add(new GroupBox() { Name = "EEE", Header = "EEE", Height = 100, Background = Brushes.Purple });
        }
        public class Colour
        {
            public string Name { get; set; }
        }

        public List<Colour> Colours
        {
            get
            {
                return GetColors();
            }
            set
            {

            }

        }

        public static List<Colour> GetColors()
        {
            List<Colour> colours = new List<Colour>();
            colours.Add(new Colour() { Name = "Red" });
            colours.Add(new Colour() { Name = "Blue" });
            colours.Add(new Colour() { Name = "Green" });
            colours.Add(new Colour() { Name = "Black" });
            colours.Add(new Colour() { Name = "Navy" });
            return colours;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            //var item = cmbColors.SelectedValue;
        }
    }
}



//#region GroupBoxesProperty

//public static readonly DependencyProperty GroupBoxesProperty = DependencyProperty.Register(
//    "GroupBoxes", typeof(ObservableCollection<GroupBox>), typeof(MainWindow)
//);

//public ObservableCollection<GroupBox> GroupBoxes
//{
//    get { return (ObservableCollection<GroupBox>)GetValue(GroupBoxesProperty); }
//    set { SetValue(GroupBoxesProperty, value); }
//}

//#endregion

//#region SelectedGroupBoxProperty

//public static readonly DependencyProperty SelectedGroupBoxProperty = DependencyProperty.Register(
//    "SelectedGroupBox", typeof(GroupBox), typeof(MainWindow),
//    new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, (s, e) => (s as MainWindow).OnSelectedGroupBoxChanged())
//);

//public GroupBox SelectedGroupBox
//{
//    get { return (GroupBox)GetValue(SelectedGroupBoxProperty); }
//    set { SetValue(SelectedGroupBoxProperty, value); }
//}

//void OnSelectedGroupBoxChanged()
//{
//    Console.WriteLine("selection is now " + this.SelectedGroupBox.Name);
//}

//#endregion




