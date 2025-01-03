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
using ChessLogic;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml (code behind)
    /// </summary>
    public partial class MainWindow : Window
    {
        //create a 2d array for the image controls
        //it must have 8 rows and 8 columns to match the board
        private readonly Image[,] pieceImages = new Image[8, 8];
        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    //for each position create an image control
                    Image image = new Image();
                    //store it in 2d array
                    pieceImages[r, c] = image;
                    //add it in the UniformGrid as a child
                    PieceGrid.Children.Add(image);
                }
            }
            //we will call InitializeBoard() from the constructor after InitializeComponent()
        }
    }
}