using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Vector3 goback;
    bool canMove = true;
    GameObject reset;
    int ice;
    void Start()
    {

    }

    void Update()
    {
        if (canMove==true&&Input.GetKeyDown("down"))
        {
            goback =new Vector3(transform.position.x,transform.position.y,0f);
            transform.Translate(0, -1, 0);
            ice = 1;
        }
        else if (canMove == true && Input.GetKeyDown("up"))
        {
           goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(0, 1, 0);
            ice = 2;
        }
        else if (canMove == true && Input.GetKeyDown("left"))
        {
            goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(-1, 0 , 0);
            ice = 3;
        }
        else if (canMove == true && Input.GetKeyDown("right"))
        {
            goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(1, 0, 0);
            ice = 4;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Wall")
        {
            Debug.Log("goback");
            transform.position = goback;
        }
        else if(collision.gameObject.tag == "Stun")
        {
            canMove = false;
            StartCoroutine(nowStun());
        }
        else if (collision.gameObject.tag == "Enemy"|| collision.gameObject.tag == "Fire")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.tag == "IceTile")
        {
            switch (ice)
            {
                case 1: transform.Translate(0, -1, 0);break;
                case 2: transform.Translate(0, 1, 0); break;
                case 3: transform.Translate(-1, 0, 0); break;
                case 4: transform.Translate(1, 0, 0); break;
            }
        }
    }
    IEnumerator nowStun()
    {
        yield return new WaitForSeconds(1f);
        canMove = true;
    }

}
