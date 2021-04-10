using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject pausePanel;

    public Sprite playImg;
    public Sprite pauseImg;

    public Button pauseBtn;

    bool isPaused = false;

    private float audioVolume = 1f;

    private void Start()
    {
        GameManager.instance.audioSlider.value = PlayerPrefs.GetFloat("AudioSave", audioVolume);
    }
    private void Update()
    {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.volume = audioVolume;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Menu()
    {
        if(isPaused)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Pause()
    {
        if(isPaused)
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();

            foreach(AudioSource a in audios)
            {
                a.UnPause();
            }
            pauseBtn.image.sprite = pauseImg;
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();

            foreach (AudioSource a in audios)
            {

                a.Pause();
            }
            pauseBtn.image.sprite = playImg;
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            isPaused = true; 
        }
    }

    public void UpdateVolume(float volume)
    {
        audioVolume = volume;
        PlayerPrefs.SetFloat("AudioSave", audioVolume);
    }
}