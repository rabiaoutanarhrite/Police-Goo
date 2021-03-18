using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject Doors;
    public GameObject nextGiga;

    private int sceneContinue;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
    }

    public void PlayGame()
    {
        Doors.SetActive(true);
        StartCoroutine(nextG());
        StartCoroutine(closeDoors());
    }

    public void EnterStore()
    {
        SceneManager.LoadScene(11);
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
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
        Debug.Log("hey!");
    }
}
