using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scoreScript : MonoBehaviour {

    public int score = 0;
    private Text textComponent;
	// Use this for initialization
	void Start () {
        textComponent = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        textComponent.text = "score = " + score;
	}

    public void addScore()
    {
        score += 1;
    }
}
