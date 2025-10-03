using UnityEngine;

public class HeroBackstory : MonoBehaviour
{

    /*
     * who:     Amy
     * what:    A Storm  
     * when:    Several Days Ago
     * where:   Norway
     * why:     Global Warming
     * how:     Magic, the storm becomes a character
    */

    public string[] dialog;
    public int curDialog = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialog = new string[6];
        dialog[0] = "Hello, my name is Amy";
        dialog[1] = "I'm a Storm";
        dialog[2] = "I was born several days ago";
        dialog[3] = "I was born off the coast of Norway";
        dialog[4] = "The result of human stupidity, and greed";
        dialog[5] = "I have been named, because humans fear me.";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DisplayDialog(dialog[curDialog]);

            curDialog++;

            if(curDialog >= dialog.Length)
            {
                curDialog = 0;
            }
        }
        
    }

    private void DisplayDialog(string text)
    {
        //how do you want to display? 2d GUI? lazy programmer does:
        Debug.Log(text);

    }

}
