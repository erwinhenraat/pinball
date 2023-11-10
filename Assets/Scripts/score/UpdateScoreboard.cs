using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UpdateScoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text scoreboardText;
    // Start is called before the first frame update
    void Start()
    {
        scoreboardText= GetComponent<TMP_Text>();
        Bump.OnBump += GetBumperScore;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GetBumperScore() {
        score += 15;
        Debug.Log(score);
        scoreboardText.text = "score: " + score;
    }
}
