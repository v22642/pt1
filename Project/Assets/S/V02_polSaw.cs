using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V02_polSaw : MonoBehaviour
{
    public Vector3 targetPosition;
    public Vector3 startPosition;
    void Start()
    {
        
        StartCoroutine(MoveCoroutine());
    }
    IEnumerator MoveCoroutine()
    {
        while (true)
        {
            for (float i = 0; i < 1; i += Time.deltaTime)
            {
                transform.position = Vector3.Lerp(startPosition, targetPosition, EasingLinear(i));
                yield return null;
                transform.position = targetPosition;
            }
            yield return new WaitForSeconds(1.5f);

            for (float i = 0; i < 1; i += Time.deltaTime)
            {
                transform.position = Vector3.Lerp(targetPosition, startPosition, EasingLinear( i));
                yield return null;
                transform.position = startPosition;
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    float EasingLinear(float x)
    {
        return x;
    }
}
