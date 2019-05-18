using MaterialDesignThemes.Wpf;
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

namespace DesidnMaterialsExperements
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Mess.Blocks.Clear();
            Card card = new Card();
            card.Padding = new Thickness { Bottom = 8, Left = 8, Right = 8, Top = 8 };
            TextBlock textBlock = new TextBlock();
            //textBlock.Style = 
            textBlock.Text = "bla bla bla";
            textBlock.FontSize = 14;
            card.Content = textBlock;
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(card);
            Mess.Blocks.Add(paragraph);

        }

        
    }
}
