using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuMgr : MonoBehaviour
{
    public void GotoScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
