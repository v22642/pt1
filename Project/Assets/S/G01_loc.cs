using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G01_loc : MonoBehaviour
{


    public GameObject lX;
    public GameObject lY;
    public Transform lZ;

    public GameObject pol;
    public GameObject stena;
    public GameObject lift;
    public GameObject fon;
    public GameObject[] trap;
    public Transform[] S;
    public Transform[] P;


    void Start()
    {
        //0000000000000000000000000000
        //X
        //00000000000000000000000000000


        int p = Random.Range(6, 10);
        int h = p * 2;
        int n = 0;
        lX.transform.localScale = new Vector2(transform.localScale.x * h, transform.localScale.y + n);

        //0000000000000000000000000000
        //Y
        //00000000000000000000000000000


        int p1 = Random.Range(4, 6);
        int h1 = p1 * 2;

        lY.transform.localScale = new Vector2(transform.localScale.x + n, transform.localScale.y * h1);


        //0000000000000000000000000000
        //размер стена связан с y
        //00000000000000000000000000000


        stena.transform.localScale = new Vector2(transform.localScale.x + n, transform.localScale.y * h1);


        //0000000000000000000000000000
        //размер пол связан с X
        //00000000000000000000000000000


        pol.transform.localScale = new Vector2(transform.localScale.x * h, transform.localScale.y + n);


        //0000000000000000000000000000
        //появления стены в точке S
        //00000000000000000000000000000


        Instantiate(stena, S[0].position, Quaternion.identity);
        if (Instantiate(stena, S[1].position, Quaternion.identity))
        {
            stena.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -90));
        }

        //0000000000000000000000000000
        //появления стены в точке P
        //00000000000000000000000000000

        Instantiate(pol, P[0].position, Quaternion.identity);
        if (pol = Instantiate(pol, P[1].position, Quaternion.identity))
        {
            pol.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
        }

        //0000000000000000000000000000
        //появления лифта (респаут играка)
        //00000000000000000000000000000

        Instantiate(lift, P[0].position, Quaternion.identity);

        //0000000000000000000000000000
        // появления фона
        //00000000000000000000000000000

        fon_c(p1, p);


       

    }
    public void fon_c( int p1, int p) 
    {
        //0000000000000000000000000000
        // фон в +
        //00000000000000000000000000000
        int x;
        int y;
        int pp1 = p1 + 1;//y
        int plusY = pp1 * 10;
        int minusY = plusY * -1;
        int pp = p + 1;//x
        int plusX = pp * 10;
        int minusX = plusX * -1;
        for (y = 0; y < plusY; y += 10)
        {
            for (x = 0; x < plusX; x += 10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            for (x = 0; x > minusX; x += -10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
        }
        //0000000000000000000000000000ы
        // фон в -
        //00000000000000000000000000000


        for (y = -10; y > minusY; y += -10)
        {
            for (x = 0; x < plusX; x += 10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            for (x = 0; x > minusX; x += -10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
        }

    }
}

 



