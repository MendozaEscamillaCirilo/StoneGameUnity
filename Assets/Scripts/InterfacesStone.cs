using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InterfacesStone : MonoBehaviour {
    public Text textThrown;
    public Text textDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Stone's number: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Destroyed: " +  GameManager.currentNumberDestroyedStones;
    }
}
