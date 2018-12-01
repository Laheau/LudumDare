using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maison : MonoBehaviour {

    public  static int workerHouse = 4;

    public static int intellectHouse;
    static int intellectTime;

    public static void AddWorkerHouse()
    {
        workerHouse++;
    }

    public static void AddIntellectHouse()
    {
        intellectHouse++;
    }
}
