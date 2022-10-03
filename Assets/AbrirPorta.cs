using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPorta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("chave"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
