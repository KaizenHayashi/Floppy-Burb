using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleLogicScript : MonoBehaviour
{
    public void newGame()
    {
        SceneManager.LoadScene(sceneName: "GameScreen");
    }
}
