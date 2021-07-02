using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Vector3 goback;
    bool canMove = true;
    GameObject reset;
    
    void Start()
    {

    }

    void Update()
    {
        if (canMove==true&&Input.GetKeyDown("down"))
        {
            goback =new Vector3(transform.position.x,transform.position.y,0f);
            transform.Translate(0, -1, 0);
        }
        else if (canMove == true && Input.GetKeyDown("up"))
        {
           goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(0, 1, 0);
        }
        else if (canMove == true && Input.GetKeyDown("left"))
        {
            goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(-1, 0 , 0);
        }
        else if (canMove == true && Input.GetKeyDown("right"))
        {
            goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(1, 0, 0);
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
    }
    IEnumerator nowStun()
    {
        yield return new WaitForSeconds(1f);
        canMove = true;
    }

}
