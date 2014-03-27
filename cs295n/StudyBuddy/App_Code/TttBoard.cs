using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TttBoard
/// </summary>
public class TttBoard
{
    //TODO:  session variable for turn?  Not incrementing.  Always 1.

    //need an array to act as placeholder to determine pictures based on char in array
    private char[,] boardGrid;
    //board will have an array of questions/answers from db, created manually until more learning happens
    public string[] questions = {"What is the air speed velocity of an unladen swallow?","What is your favorite color?","What is 2 + 2?","How many licks does it take to get to the center of a Tootsie Pop?",
                                    "Boxers or briefs?", "cats or dogs?", "book or movie?", "Is this working?","What?"};
    public string[] answers = { "i don't know that", "blue", "whatever big brother says it is", "2 licks then bite", "boxers", "cats", "book", "hope so", "huh" };
    //need some constants for row & column
    public const int ROWS = 3;
    public const int COLS = 3;
    public int turn = 1;
    //constructor without session stuff
    public TttBoard()
    {
        char[,] board = new char[ROWS, COLS];
        //create array in constructor using rows & columns & puts q's into array to pull in q img in UI
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                board[r, c] = 'q';
            }

        }
        boardGrid = board;
        turn = Turn;
    }
    //constrctor with session stuff
    public TttBoard(char[,] board)
    {

        boardGrid = board;
        Turn = turn;
    }


    //array that holds the state of the game
    public char[,] GameGrid
    {
        get { return boardGrid; }
    }
    //need a property that will get or set the arrays
    //make methods to move things around in the array

    //property for turn #
    public int Turn
    {
        get { return turn; }
        set { turn = value; }
    }


    //board has 3 horizontal rows, 3 vertical rows and 2 diagonal rows to test for win

    //TODO: get position to get corresponding position of question & answer  

    public int GetIndex(string pic)
    {
        int id = 0;
        return id;

    }
    //old one for reference == this worked
    public string GetQuestion(int id)
    {
        string question = questions[id];
        return question;
    }
    //Need to get set of 9 random questions from question set

    //when correct answer is given, x or y is entered into box
    public string GetAnswer(int id)
    {
        string a = answers[id];
        return a;
    }

    //Determine turn (x or o)

    public bool AddMark(int row, int col, int turn)
    {

        if (turn == 1)
        {
            boardGrid[row, col] = 'x';
        }
        else
        {
            boardGrid[row, col] = 'o';
        }

        return true;
    }

    //TODO:  method to check for winner
    public char Winner()
    {
        //a 'q' means nothing has been put into square
        char winner = 'q';

        //vertical checking
        for (int c = 0; c < COLS; c++)
            if (boardGrid[1, c] != 'q' && boardGrid[1, c] == boardGrid[0, c] && boardGrid[1, c] == boardGrid[2, c])
                //winner is the occupant of grid[1,c]
                winner = boardGrid[1, c];
        //no winner yet
        if (winner == 'q')
        {
            //horizontal checking
            for (int r = 0; r < ROWS; r++)
                if (boardGrid[r, 1] != 'q' && boardGrid[r, 1] == boardGrid[r, 0] && boardGrid[r, 1] == boardGrid[r, 2])
                    winner = boardGrid[r, 1];
        }
        //still no winner
        if (winner == 'q')
        {
            //check diagonals
            if (boardGrid[1, 1] != 'q' &&
                ((boardGrid[1, 1] == boardGrid[0, 0] && boardGrid[1, 1] == boardGrid[2, 2]) ||
                (boardGrid[1, 1] == boardGrid[0, 2] && boardGrid[1, 1] == boardGrid[2, 0])))
                winner = boardGrid[1, 1];
        }
        return winner;
    }
    //



}