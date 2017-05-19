using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoScene : MonoBehaviour {


    private SceneManager manager = new SceneManager();
    public string levelTag;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void changeScene()
    {
        manager.loadLevel(levelTag);
    }
}
