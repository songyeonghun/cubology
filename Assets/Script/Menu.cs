using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuselectpoint1;
    public GameObject menuselectpoint2;
    public string Nextscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    void OnMouseEnter()
    {
        menuselectpoint1.SetActive(true);
        menuselectpoint2.SetActive(true);
    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnMouseExit() 
    {
        menuselectpoint1.SetActive(false);
        menuselectpoint2.SetActive(false);
    }
}
