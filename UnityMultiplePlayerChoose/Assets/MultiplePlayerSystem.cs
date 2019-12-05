using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplePlayerSystem : MonoBehaviour
{
    public List<KeyCode> keys = new List<KeyCode>
    {
        KeyCode.W, KeyCode.I, KeyCode.Y
    };

    public List<KeyCode> controller = new List<KeyCode>(3);

    public RectTransform[] player;

    private void Update()
    {
        Check();
        Move();
    }

    private void Check()
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < keys.Count; i++)
            {
                if (Input.inputString == keys[i].ToString().ToLower())
                {
                    controller.Add(keys[i]);
                    keys.RemoveAt(i);
                }
            }
        }
    }

    private void Move()
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < controller.Count; i++)
            { 
                if (Input.inputString == controller[i].ToString().ToLower())
                {
                    player[i].anchoredPosition += Vector2.right * 250;
                }
            }
        }
    }
}
