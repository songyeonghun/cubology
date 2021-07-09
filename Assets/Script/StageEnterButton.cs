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
            this.transform.FindChild("�ڽ��� ���������̸����� �̸�").GetComponent<UILabel>().text = _no;
        }
    }

    public bool unlock
    {
        get { return _unlock; }
        set
        {
            _unlock = value;

            if (unlockSprite == null)
                unlockSprite = this.transform.FindChild("�ڽ��� �������� ��ݽ�������Ʈ�� �̸�").GetComponent<UISprite>();

            unlockSprite.SetActive(false);
        }
    }
}