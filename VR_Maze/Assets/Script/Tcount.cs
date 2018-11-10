using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tcount : MonoBehaviour {

    public Text timeLabel;
    public float timeCount;
    public Canvas cv;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
        timeCount = 15;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (timeCount > 0)
            timeCount -= Time.deltaTime;
        else if (timeCount < 0)
            exit();
        timeLabel.text = string.Format("{0:N0}", timeCount);

    }

    void exit()
    {
        Time.timeScale = 0;
        cv.gameObject.SetActive(true);
        
    }
}
