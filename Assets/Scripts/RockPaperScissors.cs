using UnityEngine;

public class RockPaperScissors : MonoBehaviour
{
    /*
    A lookup table is nothing more than a spreadsheet
    In the case of RPS, it is a "3x3 matrix" consisting of rows and columns
    
    -------------------------------------------------------
    RPS LUT       |     rock    |    paper   |   scissors |
    -------------------------------------------------------
    rock          |     draw    |    lose    |    win     |
    -------------------------------------------------------
    paper         |     win     |    draw    |    lose    |
    -------------------------------------------------------
    scissors      |     lose    |    win     |    draw    |
    -------------------------------------------------------

    For some strange reason, I enjoy laying it out in fixed width code comments.
    It gives me a chance to think about what it is I'm trying to solve.
    I usually make the rows "me" and the columns "them." Dont know why.

    Keep in mind that a LUT is a Swiss Army Knife for all sorts of solutions

    */

    int[,] resultTable = new int[3, 3];  //declare the LUT, 3 x 3 matrix of integers

    //define human readable meaning to the rows and columns
    public int ROCK = 0;        //both row and column index, right?
    public int PAPER = 1;       //both row and column index, right?
    public int SCISSORS = 2;    //both row and column index, right?

    //define human readable results, just assign consecutive ints to mean something
    int DRAW = 0;
    int LOSE = 1;
    int WIN = 2;

    //define some friendly text, mapped to the same order as above play strings:  0, 1, 2 
    string[] play = { "Rock", "Paper", "Scissors" };
    //do the same for the result strings
    string[] result = { "Draw", "Lose", "Win" };

    //I like to use a simple bool trigger for testing at run-time
    public bool playIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //build the table - yeas we could actually read this in from a huge spreadsheet
        //for RPS, ahh, just code it. Once I have defined meaning to my ints, it becomes trivial
        //but yet another opportunity to contempate my purpose

        resultTable[ROCK, ROCK] = DRAW;     
        resultTable[ROCK, PAPER] = LOSE;    
        resultTable[ROCK, SCISSORS] = WIN;  

        resultTable[PAPER, ROCK] = WIN;
        resultTable[PAPER, PAPER] = DRAW;
        resultTable[PAPER, SCISSORS] = LOSE;

        resultTable[SCISSORS, ROCK] = LOSE;
        resultTable[SCISSORS, PAPER] = WIN;
        resultTable[SCISSORS, SCISSORS] = DRAW;

       
    }

    // Update is called once per frame
    void Update()
    {
        //I always first enable some debug mechanism - just tick playIt in the inspector
        if(playIt)
        {
            playIt = false;  //one shot trigger!

            //get some random choices
            int me = Random.Range(0, 3);
            int him = Random.Range(0, 3);

            //look it up
            int r = resultTable[me, him];

            //log the action to the console
            Debug.Log("I played " + play[me] + " he played " + play[him]);
            Debug.Log("I " + result[r]);

        }
    }

    /// <summary>
    /// Function for each "player" to call when it's time
    /// </summary>
    /// <param name="me"></param>
    /// <param name="him"></param>
    /// <returns> the result animation parameter </returns>
    public string PlayOnce(int me, int him)
    {
        int r = resultTable[me, him];  //fight

        //log is always good as a sanity check
        Debug.Log("I played " + play[me] + " he played " + play[him]);
        Debug.Log("I " + result[r]);

        //return the name of the animation parameter to trigger
        return result[r];
    }

}
