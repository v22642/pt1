using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V01_floorDearing : MonoBehaviour
{
    public GameObject TBearing;
    public float P;
    //void FixedUpdate()



    // float i = o += 0f;
    // TBearing.transform.rotation = Quaternion.Euler(new Vector3(0, i, 0));
    private Vector3 targetPosition;
    private Vector3 startPosition;
    void Start()
    {
        
        StartCoroutine(MoveCoroutine());
    }
    IEnumerator MoveCoroutine()

    {
        while (true)
        {
            for (float i = 0; i >= -90; i += -1)
            {
                TBearing.transform.rotation = Quaternion.Euler(new Vector3(0, 0, EasingLinear(i)));
                yield return null;
            }
            yield return new WaitForSeconds(3f);
            for (float i = -90; i <= 0; i += 1)
            {
                TBearing.transform.rotation = Quaternion.Euler(new Vector3(0, 0, EasingLinear(i)));
                yield return null;
            }
            yield return new WaitForSeconds(3f);
        }
       
        

    }
    float EasingLinear(float x)
    {
        return x;
    }
}
