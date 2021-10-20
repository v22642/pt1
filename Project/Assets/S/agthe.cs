using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agthe : MonoBehaviour
{
    //открытые переменные
    public GameObject[] pol;
    public Transform lZ;
  //закрыте переменные 

    List<GameObject> gol = new List<GameObject>();
    int c = 0;
    //int n = 0;

    void Start()
    {
        loc();
    }
    public void loc()
    {

        //int финТоч =3;
        int y = 0;


        //int t = 0;
        
        int x=0;
        scenario1(/*ref  i,*/ ref y, ref x);
        scenario2(/*ref  i,*/ ref y, ref x);
       
        //for (int i = 0; i < финТоч; i += 1) 
        //{

        //}






        //}

    }
    public void scenario1(/*ref int i,*/ ref int y , ref int x) 
    {
        int l = Random.Range(1, 3);
        if (l == 2) l=-1;
        x += 5;
        x *= l;
        gol.Add(Instantiate(pol[0], lZ));
        gol[c].transform.localPosition = new Vector2(x/*в стороны*/, y/*в верх*/);//расположения 
        gol[c].transform.localScale = new Vector2(transform.localScale.x * 2, transform.localScale.y + 0);//размер


        x += 15*l;
        y += 10;
        gol.Add(Instantiate(pol[0], lZ));
        gol[++c].transform.localPosition = new Vector2(x/*в стороны*/, y/*в верх*/);//расположения 
        int Ы= Random.Range(1, 3);
        if (l == 2) l = -1;
    }

    public void scenario2(/*ref int i,*/ ref int y, ref int x)
    {

        gol.Add(Instantiate(pol[0], lZ));
        gol[++c].transform.localPosition = new Vector2(x/*в стороны*/, y/*в верх*/);//расположения 

        //gol.Add(Instantiate(pol[0], lZ));
        //gol[++c].transform.localPosition = new Vector2(x/*в стороны*/, y/*в верх*/);//расположения 

    }















    void Update()
    {
        
    }

    //for (x = 0; x < plusX; x += 10)
    //{
    //    var cell = Instantiate(pol[0], lZ);
    //    cell.transform.localPosition = new Vector3(x, y, 0);
    //}
    //if (y % 20 == 0)
    //{
    //    i += Random.Range(-1, 2);
    //    t = i;
    //    t *= 10;
    //    x = t;
    //    n = y;
    //    cell.transform.localPosition = new Vector3(x, y, 0);
    //}
    //else
    //{
    //    x *= 2;
    //    cell.transform.localPosition = new Vector3(x, n, 0);

    //}

}
