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

        //add GameState
        private GameState gameState;
        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();

            //initialize gameState, white starts the game (Player.White) + we pass the initial board (Board.Initial())
            gameState = new GameState(Player.White, Board.Initial());

            //draw the board
            DrawBoard(gameState.Board);
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

        //Method to draw a Board, it takes a board as a parameter and sets the source of all image controls
        //so they match the pieces on that board
        //With the pieceImages array and Images class it's easy to do
        private void DrawBoard(Board board)
        {
            //going through each position
            for (int r = 0;r < 8; r++)
            {
                for (int c = 0;c < 8;c++)
                {
                    //grad the piece at that position 
                    Piece piece = board[r, c];
                    //update the source of the corresponding image control accordingly
                    pieceImages[r, c].Source = Images.GetImage(piece);
                }
            }
        }
    }
}