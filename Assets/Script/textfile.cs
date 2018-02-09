using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textfile : MonoBehaviour {

    public Text testText;
    float score = 10.0f;
    private float lastlogTime=0;

    void Start () {
        testText = GetComponent<Text>();
    }
	
	void Update () {

        if (Time.time - lastlogTime > 10.0f)
        {
            score += 1;
            lastlogTime = Time.time;
        }
            testText.text = string.Format("Score:{0}", score);
    }

}
