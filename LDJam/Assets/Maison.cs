using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maison : MonoBehaviour {

    public static int workerHouse = 0;
    public static int intellectHouse;

    public void AddWorkerHouse()
    {
        if(main.bois >= 100)
        {
            workerHouse++;
            main.bois -= 100;
        }

    }

    public void AddIntellectHouse()
    {
        if (main.bois >= 200)
        {
            intellectHouse++;
            main.bois -= 200;
        }
    }
}
