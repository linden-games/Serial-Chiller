using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bulletforce : MonoBehaviour
{
    Vector3 offset;
    private float forward_speed = 15;
    public Rigidbody Ball;

    void FixedUpdate()
    {
        Ball.MovePosition(transform.position + transform.forward * forward_speed * Time.deltaTime);

    }


    Vector3 myposition;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
            myposition = touchPosition;
            transform.position = Vector3.Lerp(transform.position, myposition, Time.deltaTime);
        }
    }
    private void LateUpdate()
    {
        offset = new Vector3(0, 0, -4);
        if (Shootter.isIns == false)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, gameObject.transform.position + offset, 1);
        }
    }
}
