using UnityEngine;

public class RockPaperScissors : MonoBehaviour
{

    //RPS LUT

                //rock      //paper     //scissors
    //rock      0            1            2

    //paper     2            0            1

    //scissors  1            2            0


    // 0 draw
    // 1 loss
    // 2 win

    int[,] resultTable = new int[3, 3];

    public int ROCK = 0;
    public int PAPER = 1;
    public int SCISSORS = 2;

    int DRAW = 0;
    int LOSS = 1;
    int WIN = 2;

    string[] play = { "Rock", "Paper", "Scissors" };
    string[] result = { "Draw", "Lose", "Win" };

    public bool playIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resultTable[ROCK, ROCK] = DRAW;     //is tie
        resultTable[ROCK, PAPER] = LOSS;    //is loss
        resultTable[ROCK, SCISSORS] = WIN;  //is win

        resultTable[PAPER, ROCK] = WIN;
        resultTable[PAPER, PAPER] = DRAW;
        resultTable[PAPER, SCISSORS] = LOSS;

        resultTable[SCISSORS, ROCK] = LOSS;
        resultTable[SCISSORS, PAPER] = WIN;
        resultTable[SCISSORS, SCISSORS] = DRAW;

       
    }

    // Update is called once per frame
    void Update()
    {
        if(playIt)
        {
            playIt = false;

            int me = Random.Range(0, 3);
            int him = Random.Range(0, 3);

            int r = resultTable[me, him];

            Debug.Log("I played " + play[me] + " he played " + play[him]);
            Debug.Log("I " + result[r]);

        }
    }

    public string PlayOnce(int me, int him)
    {
        int r = resultTable[me, him];

        Debug.Log("I played " + play[me] + " he played " + play[him]);
        Debug.Log("I " + result[r]);

        return result[r];
    }

}
