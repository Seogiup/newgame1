using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour {

    public Text Score;
	// Use this for initialization
	void Start () {

        Score.text = string.Format("현재 점수는 최고 점수는 : {0:f2}초", PlayerPrefs.GetFloat("High_score"), 0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
