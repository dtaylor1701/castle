using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour {

    string[] dirList;
    float xPos;

    public GameObject door;
	// Use this for initialization
	void Start () {
        dirList = getDirNum();
        xPos = 0;

        foreach(string path in dirList)
        {
            var doorN = (GameObject)Instantiate(door);
            doorN.transform.position = new Vector3(xPos, 1, 0);
            doorN.transform.localScale = new Vector3(1, 2, (float)0.1);
            Text label = doorN.GetComponentInChildren<Text>();
            label.text = path;
            
            xPos += 2;
        }
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    string[] getDirNum()
    {

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        return Directory.GetDirectories(path);
       
    }
}
