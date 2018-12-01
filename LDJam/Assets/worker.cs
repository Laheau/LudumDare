using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public static int population;
    static int valeur = 5;
    static int delay = 4;
    static int addCouldown = delay;

    public static void Add()
    {
        if (addCouldown == 0)
        {
            Debug.Log("Nb of worker: " + population);
            population += Maison.workerHouse;
            addCouldown = delay;
        }
        else
        {
            addCouldown--;
        }
    }
    public void Sacrifie()
    {
        if (population > 0)
        {
            Debug.Log(population);
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

    public static void Production()
    {

    }
}
