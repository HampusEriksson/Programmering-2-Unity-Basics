using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private float timer = 0f;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI enemiesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
        UpdateEnemiesText();
       

    }

    private void UpdateEnemiesText()
    {
        // Räkna antal enemies - metod 1
        int amountOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        // Metod 2
        amountOfEnemies = GameObject.FindObjectsByType<EnemyMovement>(FindObjectsSortMode.None).Length;

        enemiesText.text = "Enemies: " + amountOfEnemies.ToString();
    }

    private void UpdateTimer()
    {
        timer += Time.deltaTime;
        timerText.text = timer.ToString("F2") + " sec";
    }
}
