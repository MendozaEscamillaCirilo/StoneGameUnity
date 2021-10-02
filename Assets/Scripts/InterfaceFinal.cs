﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour {
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

    public void Click(){
        // Application.LoadLevel("Awake");
        SceneManager.LoadScene("Awake");
    }
}
