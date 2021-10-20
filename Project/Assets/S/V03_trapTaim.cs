using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V03_trapTaim : MonoBehaviour
{
    public GameObject FOne;
    public GameObject FTwo;
    public GameObject FThree;
    public GameObject thorns;
    public Transform pol;
    public bool akt = true;
    
    void OnTriggerEnter2D(Collider2D ot)
    {
        if (ot && akt == true) 
        {
            StartCoroutine(MoveCoroutine());
            print(ot.gameObject.name);
        }
    }
   
    IEnumerator MoveCoroutine()

    {
        akt = false;
        FOne.GetComponent<Renderer>().material.color = new Color(255,0,0);
        yield return new WaitForSeconds(1f);
        FTwo.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(1f);
        FThree.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(1f);

        //Instantiate(thorns).transform.SetParent((t).transform);

        thorns.transform.localScale = new Vector2(transform.localScale.x + 0, transform.localScale.y + 1);

        yield return new WaitForSeconds(5f);

        thorns.transform.localScale = new Vector2(transform.localScale.x + 0, transform.localScale.y * 0);
        FOne.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        FTwo.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        FThree.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        akt = true;
    }
}
