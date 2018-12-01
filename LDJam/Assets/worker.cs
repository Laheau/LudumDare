using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public static int population = 4;
    static int valeur = 50;
    static int childDelay = 4;
    static int productionDelay = 10;
    static int time = 0;

    public static void Tick()
    {
        time++;
        if (time % childDelay == 0)
        {
            population += Maison.intellectHouse;
        }
        if (time % productionDelay == 0)
        {
            main.bois += population;
        }
    }
    public void Sacrifie()
    {
        if (population > 0)
        {
            if (main.rage == 100)
            {
            }
            else
            {
                population--;
                main.rage += valeur;
                if (main.rage > 100)
                {
                    main.rage = 100;
                }
            }
        }
    }

}
