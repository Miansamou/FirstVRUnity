using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject teleporte;
    public void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,
                transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            var target = hit.transform.gameObject;
            if (target.CompareTag("boneco"))
            {
                Destroy(target.gameObject);
                teleporte.SetActive(true);
            }
        }
    }

}
