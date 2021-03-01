using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCompl : MonoBehaviour
{
    public void LoadLevel()
    {
        // load the nextlevel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
}