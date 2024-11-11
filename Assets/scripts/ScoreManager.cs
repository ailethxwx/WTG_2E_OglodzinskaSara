using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreCount;

    void Start()
    {
        if (scoreText == null)
        {
            // Automatyczne wyszukiwanie, jeśli scoreText nie przypisano
            scoreText = GameObject.FindObjectOfType<TextMeshProUGUI>();
           
            if (scoreText == null)
            {
                Debug.LogError("Nie znaleziono żadnego obiektu TextMeshProUGUI w scenie!");
            }
            else
            {
                Debug.Log("scoreText został automatycznie przypisany.");
            }
        }
    }

    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + scoreCount;
        }
        else
        {
            Debug.LogError("scoreText jest wciąż null! Upewnij się, że przypisano go w Inspectorze lub dodano TextMeshPro do sceny.");
        }
    }
}