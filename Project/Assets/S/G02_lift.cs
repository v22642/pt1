using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G02_lift : MonoBehaviour
{
    public GameObject Pler;
    public Transform pPler;
    void Start()
    {
        Instantiate(Pler, pPler.position, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
