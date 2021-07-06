using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseEnter()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("»Æ¿Œ");
            SceneManager.LoadScene(scene);
        }

    }
}
