using UnityEngine;

public class Encounter : MonoBehaviour
{

    public RockPaperScissors rps;
    private Animator animator;
    public int whatIplay;
    public int whatHePlay;
    public bool doit = false;

    //our anim param "strike" names, same order as the RPS LUT
    string[] play = { "Rock", "Paper", "Scissors" };

    private void Start()
    {
        //get this character's animation behaviour
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        //if told to do it...
        if(doit)
        {
            doit = false;

            animator.SetTrigger(play[whatIplay]);  //set the strike

            string animparam = rps.PlayOnce(whatIplay, whatHePlay); //get the result param name
            
            animator.SetTrigger(animparam);         //play the reaaction

        }
    }
}
