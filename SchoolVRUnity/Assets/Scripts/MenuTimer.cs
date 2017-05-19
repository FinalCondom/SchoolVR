using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTimer : MonoBehaviour {
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
            text.text = "SchoolVR";
        }
        if (timer > 4)
        {
            text.text = "Venez visiter le Valais !";
        }
        if (timer > 8)
        {
            text.text = "Choisissez ce que vous voulez voir !";
        }
        if (timer > 12)
        {
            manager.loadLevel("SelectionMenu");
        }
        //text.text = "TIMER : " + timer;
         
    }
}
