using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFinge: MonoBehaviour {
    private Text text;
    private float timer = 0;
    private SceneManager manager = new SceneManager();
    void Start()
    {
        text = GetComponent<Text>();
    }

	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 0)
        {
            text.text = "BOIS DE FINGE";
        }
   
        //text.text = "TIMER : " + timer;
         
    }
}
