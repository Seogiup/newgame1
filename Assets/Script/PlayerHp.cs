using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour {

    private int HP = 15;
    public Text hpText;
    public Text TimeShow;
    public Text RecordText;
    public GameObject endmessage;
    float lastlogtime = 0;
    float ttime = 0;
    float startpoint = 0;
    public GameObject returnButton;
    public GameObject record;
    public float lasttime;
    private bool deading;


    public void HealHp(int amount) {

        if (!Dead())
        {
            HP += amount;
            UpdateHp();
        }

    }


    public void DamageHp(int amount) {

        {
            HP -= amount;
            UpdateHp();
        }

    }


    public bool Dead()
    {
        return HP <= 0;
    }


    private void UpdateHp ()
    {

       hpText.text = string.Format("HP:{0}", HP);

    }


    void Start () {
        deading = true;
        lastlogtime = 0;
        HP = 3;
        UpdateHp();
        startpoint = Time.time;
    }


    void save() {

        var value = PlayerPrefs.GetFloat("High_score", 0);

        if (ttime < value)
        {
            RecordText.text = string.Format("현재 최고 기록은 : {0:f2}초", value);

        }
        else
        {
            RecordText.text = string.Format("신기록입니다 추카! : {0:f2}초", ttime);
            PlayerPrefs.SetFloat("High_score", ttime);
            PlayerPrefs.Save();
        }

    }




    void Update () {

        if (Dead() && deading)
        {
            deading = false;
            save();
            endmessage.SetActive(true);
            returnButton.SetActive(true);
            record.SetActive(true);

        }

        ttime = Time.time - startpoint;

        if (!Dead())
        TimeShow.text = string.Format("Time: {0:f2}초", ttime);



        if (ttime - lastlogtime > 10.0f)
        {
            if (!Dead())
            {
                HealHp(1);
                lastlogtime = Time.time;
            }
        }
    
    }
}
