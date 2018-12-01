using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maison : MonoBehaviour {

    public static int workerHouse = 0;
    public static int intellectHouse;

    public void AddWorkerHouse()
    {
        workerHouse++;
    }

    public void AddIntellectHouse()
    {
        intellectHouse++;
    }
}
