using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCompl : MonoBehaviour
{
    private int currentScenceIndex;

    public void LoadLevel()
    {
        currentScenceIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentScenceIndex +1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    
}