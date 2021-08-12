using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public GameObject StoryScene;
    public string Stage;
public void StageStart()
    {
        StoryScene.SetActive(false);
    }
    public void StageEnd()
    {
        SceneManager.LoadScene(Stage);
    }
}
