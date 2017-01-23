using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalSwarm : MonoBehaviour {

    public GameObject dronePrefab;
    public static int arenaSize = 5;

    static int numDrone = 10;
    public static GameObject[] allDrone = new GameObject[numDrone];
    public static Vector2 goalPos = Vector2.zero;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < numDrone; i++)
        {
            Vector2 pos = new Vector2(Random.Range(-arenaSize, arenaSize),Random.Range(-arenaSize, arenaSize));
            allDrone[i] = (GameObject)Instantiate(dronePrefab, pos, Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update () {
        if (Random.Range(0, 10000) < 50)
        {
            goalPos = new Vector2(Random.Range(-arenaSize, arenaSize),
                                  Random.Range(-arenaSize, arenaSize));
        }
    }
}
