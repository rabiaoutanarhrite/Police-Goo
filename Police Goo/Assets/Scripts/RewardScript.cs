using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RewardScript : MonoBehaviour
{
    public Button nextBtn;
    public Text nextText;

    private int currentScenceIndex;

    // Start is called before the first frame update
    void Start()
    {
       

        nextBtn.interactable = false;

        StartCoroutine(NextDispaly());
    }

    IEnumerator NextDispaly()
    {
        nextText.text = "5";

        yield return new WaitForSeconds(1f);

        nextText.text = "4";

        yield return new WaitForSeconds(1f);

        nextText.text = "3";

        yield return new WaitForSeconds(1f);

        nextText.text = "2";

        yield return new WaitForSeconds(1f);

        nextText.text = "1";

        yield return new WaitForSeconds(1f);

        nextText.text = "Next";
        nextBtn.interactable = true;

    }

    public void NextLevel()
    {
        currentScenceIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentScenceIndex + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
