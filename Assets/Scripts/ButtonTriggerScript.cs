using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerScript : MonoBehaviour
{
    public GameObject target;
    public bool check = false;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(("GUS")))
        {
            target.SetActive(check);
        }
    }
}
