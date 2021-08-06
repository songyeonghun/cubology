using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1map : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject cube8;
    public GameObject cube9;
    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(1, 10);

        switch (random)
        {
            case 1:
                Instantiate(cube1, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 2:
                Instantiate(cube2, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 3:
                Instantiate(cube3, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 4:
                Instantiate(cube4, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 5:
                Instantiate(cube5, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 6:
                Instantiate(cube6, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 7:
                Instantiate(cube7, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 8:
                Instantiate(cube8, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;

            case 9:
                Instantiate(cube9, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
