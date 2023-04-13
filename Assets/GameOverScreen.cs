using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverScreen : MonoBehaviour
{
    public GameObject GOScreen;
    public TMP_Text ScoreText;
    public float Score = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GOScreen.SetActive(true);
        ScoreText.text = "SCORE: " + Score;
    }

}
