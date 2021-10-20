using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttt : MonoBehaviour
{
    public GameObject bot_way;
    public Transform[] lZ;
    List<int> gol = new List<int>();

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int gen = Random.Range(0, 2);
            print(gen);
        }
           
        //int l = 8;
        //int j;
        //int c;
        //int n;
        //int m;
        //int gen;
        //n = l - 2;
        //j = n / 2;
        //c = j * -1;
        //j++;
        //for (int i =0; i < 10; i++) 
        //{
        //    gen = Random.Range(c, j);
        //    print(gen);
        //}
        //gol.Add(Instantiate(bot_way, lZ[0]));
        //gol.Add(Instantiate(bot_way, lZ[1]));
        //gol.Add(Instantiate(bot_way, lZ[2]));
        //print(gol[0]);
        //print(gol[1]);
        //print(gol[2]);
    }
    //void Start()
    //{
    //    bot_way.transform.position = new Vector2(9.4f, 0);

    //}
    void Update()
    {
        
    }
}

/*
bot.transform.position = new Vector2(9.4f, 0);
int x = gn();
}
public int put()
{
int v =
return
}
*/
