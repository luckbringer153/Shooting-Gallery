using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointtoCursor : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get position of cursor
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //find distance between cursor and object
        Vector2 direction = mousePosition - transform.position;

        //find angle of rotation
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

}
