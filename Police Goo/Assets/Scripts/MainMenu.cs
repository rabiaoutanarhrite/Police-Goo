using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject Doors;
    public GameObject nextGiga;

    public void PlayGame()
    {
        Doors.SetActive(true);
        StartCoroutine(nextG());
        StartCoroutine(closeDoors());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator closeDoors()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    IEnumerator nextG()
    {
        yield return new WaitForSeconds(1f);
        nextGiga.SetActive(true);
        Debug.Log("hey!");
    }
}
