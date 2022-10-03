using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarLuz : MonoBehaviour
{
    private Light luz;
    
    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
    }

    public void AcenderLuz()
    {
        luz.enabled = !luz.enabled;
    }
}
