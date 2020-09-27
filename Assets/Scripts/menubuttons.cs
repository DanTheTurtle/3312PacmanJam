using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menubuttons : MonoBehaviour
{

    public void StartGame()
    {
        Manager.instance.GameStart();
    }
    public void ResetGame()
    {
        Manager.instance.RestartGame();
    }
}
