using UnityEngine;

public class EncounterDriver : MonoBehaviour
{
    //the players playing
    public Encounter player1;
    public Encounter player2;

    //when to doit
    public bool fight = false;

    // Update is called once per frame
    void Update()
    {
        //tell them both to fight
        if(fight)
        {
            fight = false;
            player1.doit = true;
            player2.doit = true;
        }
    }
}
