using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tcount : MonoBehaviour {

    public Text timeLabel;
    public float timeCount;

	// Use this for initialization
	void Start () {
        timeCount = 15;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (timeCount > 0) timeCount -= Time.deltaTime;
        timeLabel.text = string.Format("{0:N0}", timeCount);
		
	}
}
