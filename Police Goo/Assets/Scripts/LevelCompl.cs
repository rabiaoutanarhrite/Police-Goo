using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCompl : MonoBehaviour
{
    public GameObject rewardPanel;
    public GameObject youWinPanel;

    public void LoadLevel()
    {
        rewardPanel.SetActive(true);
        youWinPanel.SetActive(false);

    }

    public void restartLevels()
    {
        SceneManager.LoadScene(1);
    }

    
}