using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragAndDropMacroCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonPressDownStartDrag_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop((Button)sender, "Something", DragDropEffects.Copy);
        }

        private void ButtonPressUpStartDrag_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ButtonWaitStartDrag_MouseDown(object sender, RoutedEventArgs e)
        {

        }

        private void PreliminaryTimeline_PreviewDragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
        }

        private void PreliminaryTimeline_DragDrop(object sender, DragEventArgs e)
        {
            ((Rectangle)sender).Fill = Brushes.Green;
        }
    }
}