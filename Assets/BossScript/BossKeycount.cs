using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossKeycount : MonoBehaviour
{
    static public int bossKey;
    public int bossKeyCount;
    public string nextboss;
    // Start is called before the first frame update
    void Start()
    {
        bossKey = bossKeyCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (bossKey <= 0)
        {
            SceneManager.LoadScene(nextboss);
        }
    }
}
