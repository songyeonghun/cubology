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
    RaycastHit2D down,up,right,left;
    void Start()
    {

    }

    void Update()
    {
        //����ĳ��Ʈ
        down = Physics2D.Raycast(transform.position, Vector2.down,1, LayerMask.GetMask("Cube"));
        up = Physics2D.Raycast(transform.position, Vector2.up, 1, LayerMask.GetMask("Cube"));
        right = Physics2D.Raycast(transform.position, Vector2.right, 1, LayerMask.GetMask("Cube"));
        left = Physics2D.Raycast(transform.position, Vector2.left, 1, LayerMask.GetMask("Cube"));

        if (canMove == true&&Input.GetKeyDown("down") && down.collider == null)
        {
            transform.Translate(0, -1, 0);
            ice = 1;
        }
        if (canMove == true && Input.GetKeyDown("up") && up.collider == null)
        {
            transform.Translate(0, 1, 0);
            ice = 2;
        }
        if (canMove == true && Input.GetKeyDown("left") && left.collider == null)
        {
            transform.Translate(-1, 0 , 0);
            ice = 3;
        }
        if (canMove == true && Input.GetKeyDown("right") && right.collider == null)
        {
            transform.Translate(1, 0, 0);
            ice = 4;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.tag == "Stun")
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
                case 1: if(down.collider == null)
                        transform.Translate(0, -1, 0);break;
                case 2: if (up.collider == null) 
                        transform.Translate(0, 1, 0); break;
                case 3: if (left.collider == null) 
                        transform.Translate(-1, 0, 0); break;
                case 4: if (right.collider == null) 
                        transform.Translate(1, 0, 0); break;
            }
        }
    }
    IEnumerator nowStun()
    {
        yield return new WaitForSeconds(1f);
        canMove = true;
    }

}
