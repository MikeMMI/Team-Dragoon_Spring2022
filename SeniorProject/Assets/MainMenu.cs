using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public TMPro.TextMeshProUGUI text;
    public GameObject StartScreen;

    public void Start()
    {

    }

    public void Update()
    {
        if (Input.anyKeyDown && text.enabled == true)
        {
            Debug.Log("key pressed");
            text.enabled = false;
            StartScreen.SetActive(true);
        }

        if (volumeSlider.value != AudioListener.volume)
        {
            ChangeMusicVolume();
        }
    }

    //loads playerhouse scene for now, will try to implement a save function
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayerHouse");
    }

    //quits the game, only works when game is built
    public void QuitGame()
    {
        Application.Quit();
    }

    //changes music volumes based on the slider in the options menu
    public void ChangeMusicVolume() {
        AudioListener.volume = volumeSlider.value;
    }
}
