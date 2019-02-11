using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadscene : MonoBehaviour
{


    public void LoadByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        //Application.LoadLevelAdditive(sceneIndex);
    }
}
