﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame() {
        SceneManager.LoadScene(1);
    }
    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
}
