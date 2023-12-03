using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerSettings : MonoBehaviour
{

    public Text TextTimer;
    public float Waktu;
    
    public bool GameAktif = true;
    public GameObject CanvasKalah;
    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00") +":"+ Detik.ToString("00");
    }

    float s;
    private void Update()
    {
        
        if(GameAktif)
        {
            s += Time.deltaTime;
        if(s >= 1)
        {
            Waktu--;
            s = 0;
        }
        }

        if(GameAktif && Waktu <= 0)
        {
            Debug.Log("Game Kalah");
            CanvasKalah.SetActive(true);
            GameAktif = false;
            Time.timeScale = 0;
        }

         SetText();

    }

    public void QuitLevel()
    {
        SceneManager.LoadScene(0);

    }
}
