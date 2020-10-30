using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    public static int highscore;
    public Text scoreTxt; 
    void Start() {
        score = 0;
        highscore = PlayerPrefs.GetInt("Highscore", 0);
    }
    public static void updateScore(int increase) {
        score += increase;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        scoreTxt.text = "Score: " + score;
        if (score >= highscore) {
            PlayerPrefs.SetInt("Highscore", score);
            highscore = score;
        }
    }
}
