using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuX : MonoBehaviour
{
    public GameObject Menu,OptionBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        Menu.SetActive(false);
        OptionBtn.SetActive(true);
    }
}
