using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageEnterButton : MonoBehaviour
{
    int _no = 0;
    bool _unlock = false;
    UISprite unlockSprite = null;

    public int no
    {
        get { return _no; }
        set
        {
            _no = value;
            this.transform.FindChild("자식인 스테이지이름라벨의 이름").GetComponent<UILabel>().text = _no;
        }
    }

    public bool unlock
    {
        get { return _unlock; }
        set
        {
            _unlock = value;

            if (unlockSprite == null)
                unlockSprite = this.transform.FindChild("자식인 스테이지 잠금스프라이트의 이름").GetComponent<UISprite>();

            unlockSprite.SetActive(false);
        }
    }
}