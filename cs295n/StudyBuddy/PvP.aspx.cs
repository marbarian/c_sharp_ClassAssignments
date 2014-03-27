using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PvP : System.Web.UI.Page
{

    TttBoard myBoard;

    string id;
    const string Q_URL = "Pictures/question.jpg";
    const string X_URL = "Pictures/X.gif";
    const string O_URL = "Pictures/o.jpg";
    const string GAME_GRID = "Pictures/gameGrid";
    const int PIC_DIM = 150;
    int turn;

    //ImageButton[] btns = new ImageButton[9];

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["turn"] == null)
            turn = 1;
        else
            turn = (int)Session["turn"];
        //put images into an array using panel
        if (Session[GAME_GRID] == null)
        {
            //if nothing in session, create new board
            myBoard = new TttBoard();
            Session[GAME_GRID] = myBoard.GameGrid;

        }
        else
        {
            //if something is in session, pull it out and put it into object

            myBoard = new TttBoard((char[,])Session[GAME_GRID]);
        }

        //load all controls on pg w/their data
        //this won't work right if we do it on postbacks since the pg load happens before the click event is processed.
        if (!IsPostBack)
            ReloadPageData();
    }

    private void ReloadPageData()
    {

        //update the display of the game grid on the web page
        ImageButton imgBtn;
        int index = 0;
        for (int r = 0; r < TttBoard.ROWS; r++)
        {
            for (int c = 0; c < TttBoard.COLS; c++)
            {
                //get a reference to the img btn at this location in the table
                string id = "q" + r.ToString() + c.ToString();
                imgBtn = /*btns[index];*/Panel1.FindControl(id) as ImageButton;
                //if statements to put pictures in
                if (myBoard.GameGrid[r, c] == 'q')
                {
                    imgBtn.ImageUrl = Q_URL;
                    imgBtn.Height = PIC_DIM;
                    imgBtn.Width = PIC_DIM;
                }
                else if (myBoard.GameGrid[r, c] == 'x')
                {
                    imgBtn.ImageUrl = X_URL;
                    imgBtn.Height = PIC_DIM;
                    imgBtn.Width = PIC_DIM;
                    imgBtn.Enabled = false;
                }
                else if (myBoard.GameGrid[r, c] == 'o')
                {
                    imgBtn.ImageUrl = O_URL;
                    imgBtn.Height = PIC_DIM;
                    imgBtn.Width = PIC_DIM;
                    imgBtn.Enabled = false;
                }
            }
            index++;
        }
    }


    protected void q00_Click(object sender, ImageClickEventArgs e)
    {
        if (myBoard.Winner() == 'q')
        {
            ImageButton btnClicked = (ImageButton)sender;
            id = btnClicked.ID;
            Session["btnClicked"] = id;
            Session["pos1"] = int.Parse(id.Substring(1, 1));
            Session["pos2"] = int.Parse(id.Substring(2, 1));
            int idNum = -1;
            switch (id)
            {
                case "q00":
                    idNum = 0;
                    break;
                case "q01":
                    idNum = 1;
                    break;
                case "q02":
                    idNum = 2;
                    break;
                case "q10":
                    idNum = 3;
                    break;
                case "q11":
                    idNum = 4;
                    break;
                case "q12":
                    idNum = 5;
                    break;
                case "q20":
                    idNum = 6;
                    break;
                case "q21":
                    idNum = 7;
                    break;
                case "q22":
                    idNum = 8;
                    break;
            }
            Session["id"] = idNum;

            //testing to see if picture will change when clicked
            lblQuestion.Visible = true;
            txtAnswer.Visible = true;
            btnEnter.Visible = true;
            lblQuestion.Text = myBoard.GetQuestion((int)Session["id"]);
        }
        else
        {
            txtSecret.Visible = true;
            txtSecret.Text = "Game is Over.";
        }
    }
    protected void btnEnter_Click1(object sender, EventArgs e)
    {

        if (myBoard.answers[(int)Session["id"]] == txtAnswer.Text)
        {
            lblQuestion.Text = "Correct!";
            myBoard.AddMark((int)Session["pos1"], (int)Session["pos2"], turn);
            if (turn == 1)
                turn = 0;
            else
                turn = 1;
            Session["turn"] = turn;
            ReloadPageData();
            if (myBoard.Winner() == 'x')
            {
                txtSecret.Visible = true;
                txtSecret.Text = "X wins!";
            }
            else if (myBoard.Winner() == 'o')
            {
                txtSecret.Visible = true;
                txtSecret.Text = "Y wins!";
            }
        }

        else
        {
            lblQuestion.Text = "Incorrect!";
            if (turn == 1)
                turn = 0;
            else
                turn = 1;
            Session["turn"] = turn;

        }
        //need to save the btn clicked somewhere so i can change the url
        txtAnswer.Visible = false;
        btnEnter.Visible = false;

    }
}