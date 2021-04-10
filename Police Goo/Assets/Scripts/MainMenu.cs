using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;

    public GameObject Doors;
    public GameObject nextGiga;

    public GameObject settingPnl;
    private float audioVolume = 1f;

    private int sceneContinue;

    private void Start()
    {
        instance = this;
        
        audioVolume = PlayerPrefs.GetFloat("AudioSave", audioVolume);
    }

    private void Update()
    {
        
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.volume = audioVolume;
        }
    }

    public void PlayGame()
    {
        Doors.SetActive(true);
        StartCoroutine(nextG());
        StartCoroutine(closeDoors());
    }

    public void SettingEnter()
    {
        settingPnl.SetActive(true);
    }

    public void SettingExit()
    {
        settingPnl.SetActive(false);
    }

    public void UpdateVolume(float volume)
    {
        audioVolume = volume;
        PlayerPrefs.SetFloat("AudioSave", audioVolume);
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

    public void ExitShop()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator closeDoors()
    {
        yield return new WaitForSeconds(2);
        
        sceneContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneContinue != 0)
            SceneManager.LoadScene(sceneContinue);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    
    IEnumerator nextG()
    {
        yield return new WaitForSeconds(1f);
        nextGiga.SetActive(true);
        
    }
}
