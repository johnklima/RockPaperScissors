using UnityEngine;

public class Armour : MonoBehaviour
{

    public string version;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        version = Application.unityVersion;
    }

    // Update is called once per frame
    void Update()
    {
        if (version != "6000.2.6f2")
        {
            Debug.Log("You have chink in your security, ugrade your armour to 6000.2.6f2");

        }

        if (version == "6000.2.6f2")
        {
            Debug.Log("Your armour is busted, upgrade your armour to 6.3 beta (at your own risk)");
        }
    }
}
