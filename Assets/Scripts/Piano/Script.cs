using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    bool MouseDown = false;
    public Transform CenterPoint;
    public float MaxDistanceX = 8.5f;
    public float MaxDistanceY = 2.5f;

    private void OnMouseDown()
    {
        Debug.Log("!!!");
        MouseDown = true;
    }

    private void OnMouseUp()
    {
        MouseDown = false;
    }

    void Update()
    {
        
        Vector2 Cursor = Input.mousePosition;
        Cursor = Camera.main.ScreenToWorldPoint(Cursor);
        
        float distX = Mathf.Abs(this.transform.position.x - CenterPoint.position.x);
        float distY = Mathf.Abs(this.transform.position.y - CenterPoint.position.y);

        if(MouseDown)
        {
            
            if (MaxDistanceX > distX && MaxDistanceY > distY)
                this.transform.position = Cursor;
        }
    }
}
