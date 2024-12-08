using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI sliderText;
    public Slider slider;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void UpdateSliderText()
    {
        sliderText.text = "Game speed: " + slider.value.ToString();
        Settings.gameSpeed = slider.value;
    }
}
