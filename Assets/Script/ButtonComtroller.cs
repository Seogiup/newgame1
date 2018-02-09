using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonComtroller : MonoBehaviour {
    
       
    public void OpenMainScene() {

        SceneManager.LoadScene("25");

    }

    public void resetrecord()
    {
        PlayerPrefs.SetFloat("High_score", 0.0f);
        PlayerPrefs.Save();
    }


    public void quit()
    {
        Application.Quit();
    }
}
