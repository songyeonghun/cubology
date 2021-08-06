uusing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class BossMoving2 : MonoBehaviour
{
    public int time = 1;
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Movestart());
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        var curPos = transform.position;

        curPos += new Vector3(h, v, 0) * speed * Time.deltaTime;
        curPos.x = Clamp(curPos.x, -5, 5);
        curPos.y = Clamp(curPos.y, -5, 5);

        transform.position = curPos;
    }

    IEnumerator Movestart()
    {
        while (time > 0)
        {
            int random = Random.Range(0, 4);

            yield return new WaitForSeconds(5f);

            switch (random)
            {
                case 0:
                    transform.Translate(5, 0, 0);
                    break;

                case 1:
                    transform.Translate(-5, 0, 0);
                    break;

                case 2:
                    transform.Translate(0, 5, 0);
                    break;

                case 3:
                    transform.Translate(0, -5, 0);
                    break;

            }
        }
    }


}
