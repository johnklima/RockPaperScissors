using UnityEngine;

public class Encounter : MonoBehaviour
{

    public RockPaperScissors rps;
    private Animator animator;
    public int whatIplay;
    public int whatHePlay;
    public bool doit = false;

    string[] play = { "Rock", "Paper", "Scissors" };

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if(doit)
        {
            doit = false;

            animator.SetTrigger(play[whatIplay]);

            string animparam = rps.PlayOnce(whatIplay, whatHePlay);
            
            animator.SetTrigger(animparam);

        }
    }
}
