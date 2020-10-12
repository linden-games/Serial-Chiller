using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootter : MonoBehaviour
{
    public GameObject bullet;
    public float force = 20f;
    public static bool isIns = true;
    public static bool evir = true;
    Vector3 offset;
    private void Update()
    {
        if (isIns)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, transform.position, Quaternion.Euler(45,0,0));
                isIns = false;
                evir = false;
            }
        }
    }
    private void LateUpdate()
    {
        offset = new Vector3(0, 0, -2);
        if (!isIns)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, bullet.transform.position + offset, 1);
        }
    }
}
