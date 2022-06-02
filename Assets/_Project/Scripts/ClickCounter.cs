using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    private int counter;
    public GameObject button;
    public enum Move { 
        left = -100,
        right = 100
    }

    public void clicked()
    {
        counter++;
        if(counter == 10)
        {
            moveleft();
        }
        else if(counter == 20)
        {
            moveright();
            counter = 0;
        }
    }

    private void moveleft()
    {
        button.transform.localPosition = new Vector3((int)Move.left, 0, 0);
    }
    private void moveright()
    {
        button.transform.localPosition += new Vector3((int)Move.right, 0, 0);
    }
}
