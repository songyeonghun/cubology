using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoving : MonoBehaviour
{
    public int time = 1;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Movestart());
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