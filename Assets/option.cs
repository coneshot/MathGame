using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour {
    public GameObject ans;
    GameController GC;
   

    public bool isCorrect;

    void OnMouseDown()
    {
        
        Color orange = new Color(231.0f/255, 155.0f/255, 13.0f/255);

        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;

        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;
            ans.GetComponent<TextMesh>().color = orange;
        }
       

    }


    // Use this for initialization
    void Start () {

       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
