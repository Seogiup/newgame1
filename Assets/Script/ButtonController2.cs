using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController2 : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject hpPanel;
    //public Text RecordText;
    private bool musiconoff = false;
    //public PlayerHp tttime;
  
    public void OpenSplashScene()
    {

        SceneManager.LoadScene("Splash");

    }

    public void PlaySound ()
    {
       if(!musiconoff)
        {
            audioSource.Play();
            musiconoff = true;
        }
        else { audioSource.Stop();
            musiconoff = false;
        }            
    }

    public bool Musicss()
    {
        if (musiconoff == false)
            return false;
        else return true;
    }



    //public void ToggleHpPanel()
    //{
    //    PlayerPrefs.SetFloat("High_score", 0.0f);
    //    PlayerPrefs.Save();
    //    //if (hpPanel.activeSelf)
    //    //{
    //    //    hpPanel.SetActive(false);
    //    //} else
    //    //{
    //    //    hpPanel.SetActive(true);
    //    //}

    //}

    //public void save()
    //{
    //    var value = PlayerPrefs.GetFloat("High_score", 0);
    //    ////var addNumber = PlayerPrefs.GetInt("Add_NUMBER", 1);
    //    if (tttime.ttime < value)
    //    {
    //        RecordText.text = string.Format("최고 기록은 : {0}", value);

    //            }

    //    else
    //    {
    //        RecordText.text = string.Format("최고 기록은 : {0}", tttime.lasttime);
    //        PlayerPrefs.SetFloat("High_score", tttime.ttime);
    //        PlayerPrefs.Save();
    //    }

    //}

}
