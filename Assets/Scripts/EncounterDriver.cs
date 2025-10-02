using UnityEngine;

public class EncounterDriver : MonoBehaviour
{
    public Encounter player1;
    public Encounter player2;


    public bool fight = false;

    // Update is called once per frame
    void Update()
    {
        if(fight)
        {
            fight = false;
            player1.doit = true;
            player2.doit = true;
        }
    }
}
