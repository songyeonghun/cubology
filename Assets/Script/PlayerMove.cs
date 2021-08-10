using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    bool canMove = true;
    GameObject reset;
    int ice;
    float timer;
    RaycastHit2D down,up,right,left, Hdown, Hup, Hright, Hleft;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        //레이캐스트
        down = Physics2D.Raycast(transform.position, Vector2.down,1.45f, LayerMask.GetMask("Cube"));
        up = Physics2D.Raycast(transform.position, Vector2.up, 1.45f, LayerMask.GetMask("Cube"));
        right = Physics2D.Raycast(transform.position, Vector2.right, 1.45f, LayerMask.GetMask("Cube"));
        left = Physics2D.Raycast(transform.position, Vector2.left, 1.45f, LayerMask.GetMask("Cube"));
        Hdown = Physics2D.Raycast(transform.position, Vector2.down, 1.45f, LayerMask.GetMask("HoloOff"));
        Hup = Physics2D.Raycast(transform.position, Vector2.up, 1.45f, LayerMask.GetMask("HoloOff"));
        Hright = Physics2D.Raycast(transform.position, Vector2.right, 1.45f, LayerMask.GetMask("HoloOff"));
        Hleft = Physics2D.Raycast(transform.position, Vector2.left, 1.45f, LayerMask.GetMask("HoloOff"));

        if (timer>0.2f&&canMove == true&&Input.GetKeyDown("down") && down.collider == null && Hdown.collider == null)
        {
            transform.Translate(0, -1, 0);
            ice = 1;
            timer = 0;
        }
        if (timer > 0.2f && canMove == true && Input.GetKeyDown("up") && up.collider == null && Hup.collider == null)
        {
            transform.Translate(0, 1, 0);
            ice = 2;
            timer = 0;
        }
        if (timer > 0.2f && canMove == true && Input.GetKeyDown("left") && left.collider == null && Hleft.collider == null)
        {
            transform.Translate(-1, 0 , 0);
            ice = 3;
            timer = 0;
        }
        if (timer > 0.2f && canMove == true && Input.GetKeyDown("right") && right.collider == null && Hright.collider == null)
        {
            transform.Translate(1, 0, 0);
            ice = 4;
            timer = 0;
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
                case 1:
                    if (down.collider == null && Hdown.collider == null)
                    {
                        audioSource.Play();
                        transform.Translate(0, -1, 0);
                    }
                    break;
                    
                case 2:
                    if (up.collider == null && Hup.collider == null)
                    {
                        audioSource.Play();
                        transform.Translate(0, 1, 0);
                    }
                    break;
                case 3:
                    if (left.collider == null && Hleft.collider == null)
                    {
                        audioSource.Play();
                        transform.Translate(-1, 0, 0);
                    }
                    break;
                case 4:
                    if (right.collider == null && Hright.collider == null)
                    {
                        audioSource.Play();
                        transform.Translate(1, 0, 0);
                    }
                    break;
            }
        }
        

    }
    IEnumerator nowStun()
    {
        yield return new WaitForSeconds(1f);
        canMove = true;
    }

}
