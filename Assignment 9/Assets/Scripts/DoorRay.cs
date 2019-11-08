using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRay : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;

    private void Start()
    {
        ray.origin = this.transform.position + new Vector3(0, 0, 2);
        ray.direction = Vector3.back;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(ray.origin, ray.direction * 3f);

        if (Physics.Raycast(ray.origin, ray.direction, out hit, 4f) && hit.rigidbody.gameObject.tag == "player")
        {
            Debug.Log("hit");
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 100);
        }
        else
        {
            //this.gameObject.GetComponent<Rigidbody>().force
        }

    }
}
