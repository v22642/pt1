using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G01_loc_1 : MonoBehaviour
{
    //это кардинаты креста генерации 
    public GameObject lX;//линия Х
    public GameObject lY;//линия Y
    public Transform lZ;//точка для платформы 

    //точки генерации пола ,стен
    public Transform[] dot;//точки на Х ,точки на Y

    //обЪекты генерации 
    public GameObject pol;//пол
    public GameObject stena;//стена
    public GameObject lift;//точка спавна ГГ
    public GameObject fon;//задний фон 
    List<GameObject> gol = new List<GameObject>();
    int c = 0;
    //переменные для всего
    int n = 0;
    
    void Start()
    {
        int SizeX = 0;
        int SizeY = 0;
        //генерация лакации 
        gen_rathemer(ref SizeX, ref SizeY);
        gen_pol(ref SizeX, ref SizeY);
        gen_fon(ref SizeX, ref SizeY);
        gen_Mpol(ref SizeX, ref SizeY);

    }


    //генерация лакации 
    public void gen_rathemer(ref int SizeX, ref int SizeY)
    {
        //X
        SizeX = Random.Range(4, 10);
        SizeX *= 2;
        lX.transform.localScale = new Vector2(transform.localScale.x * SizeX, transform.localScale.y + n);
        //Y
        SizeY = Random.Range(4, 6);
        SizeY *= 2;
        lY.transform.localScale = new Vector2(transform.localScale.x + n, transform.localScale.y * SizeY);
    }
    public void gen_pol(ref int SizeX, ref int SizeY)
    {
        GameObject[] GPol = new GameObject[4];

        int a = 0;

        for (int i = 0; i < 4; i++)
        {
            GPol[i] = Instantiate(pol, dot[i].position, Quaternion.identity);

            if (i % 2 == 0)
            {
                GPol[i].transform.localScale = new Vector2(transform.localScale.x * SizeX, transform.localScale.y);
            }
            else
            {
                GPol[i].transform.localScale = new Vector2(transform.localScale.x * SizeY, transform.localScale.y);
            }
            GPol[i].transform.rotation = Quaternion.Euler(new Vector3(0, 0, a));
            a += -90;

        }
    }
    public void gen_fon(ref int SizeX, ref int SizeY) 
    {
        int y;
        int x;
        SizeX *= 5;
        int plusX = SizeX + 1;

        int minusX = plusX * -1;
        SizeY *= 5;
        int plusY = SizeY + 1;
        int minusY = plusY * -1;


        for (y = 0; y < plusY; y += 10)
        {

            for (x = 0; x < plusX; x += 10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            for (x = -10; x > minusX; x += -10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
        }
        for (y = -10; y > minusY; y += -10)
        {
            for (x = 0; x < plusX; x += 10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            for (x = -10; x > minusX; x += -10)
            {
                var cell = Instantiate(fon, lZ);
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
        }
    }
    public void gen_Mpol(ref int SizeX, ref int SizeY) 
    {
        //матиматика

        int gen_T_Y = SizeY ;
        gen_T_Y -= 10;
        gen_T_Y *= -1;
        
        int gen_X = SizeX / 10;
       // gen_X -= 2;

        int gen_RP_X = gen_X ;

        int gen_RM_X = gen_RP_X * -1;
        int x;
        int y = gen_T_Y;
        for (int i =gen_RM_X;i <= gen_RP_X;i++)
        {
            if (i % 2 == 0) 
            {
                x = i;
                x *= 10;
                gol.Add(Instantiate(pol, lZ));
                gol[c++].transform.localPosition = new Vector2(x/*в стороны*/, y/*в верх*/);//расположения 
            }
        }
        //int gen_T_X = Random.Range(1, gen_X);
        //gen_T_X--;
        //gen_T_X *= -10;




    }
}