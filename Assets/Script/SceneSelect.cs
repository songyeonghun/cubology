using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSelect : MonoBehaviour
{
    public string Stage;

public void StgSelect()
    {
        SceneManager.LoadScene(Stage);
    }
}
