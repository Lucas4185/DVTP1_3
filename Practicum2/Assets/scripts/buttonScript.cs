using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {

  
    // Use this for initialization
    public void onCLick()
    {
        transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);
        Destroy(gameObject);

    }
}
