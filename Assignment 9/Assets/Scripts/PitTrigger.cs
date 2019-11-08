/*
 * Stephen Gruver
 * PitTrigger.cs
 * Assignment09
 * Handles trigger entry for the pits' trigger objects and applies an upward force to whaatever entered the trigger.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitTrigger : MonoBehaviour
{
    public float strength;
    private ForceMode forcemode;

    // Start is called before the first frame update
    void Start()
    {
        if (this.tag == "Flare")
            forcemode = ForceMode.Acceleration;
        else if (this.tag == "Smoke")
            forcemode = ForceMode.Force;
        else if (this.tag == "Fire")
            forcemode = ForceMode.Impulse;
        else if (this.tag == "Steam")
            forcemode = ForceMode.VelocityChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.tag == "Fire" || this.tag == "Steam")
        {
            Debug.Log("Force applied by Fire or Steam");
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * strength * Time.deltaTime, forcemode);
        }
    }

    private void OnTriggerStay (Collider other)
    {
        if (this.tag == "Flare" || this.tag == "Smoke")
        {
            Debug.Log("Force applied by Flare or Smoke");
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * strength * Time.deltaTime, forcemode);
        }
    }
}
