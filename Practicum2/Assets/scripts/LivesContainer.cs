using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesContainer : MonoBehaviour {

    public GameObject[] lives = new GameObject[2];
    public int lives2 = 3;
    public Text uiText;

    private void Start()
    {

        UpdateUI();
        onCLick();

    }
    // Use this for initialization
    public void onCLick()
    {
        transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);
        Destroy(lives[2]);
        lives2--;


    }

    private void UpdateUI()
    {
        uiText.text = "Lives: " + lives2.ToString();
        
    }
}
