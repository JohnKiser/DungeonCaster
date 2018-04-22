using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour {

    public GameObject spawnObject;

	public void Spawn()
    {
        GameObject go = Instantiate(spawnObject)as GameObject;
        go.transform.parent = GameObject.Find("Map").transform;
    }
}
