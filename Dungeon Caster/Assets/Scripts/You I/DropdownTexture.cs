using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownTexture : MonoBehaviour {

    public GameObject mapTexture;
    public Dropdown textureDropdown;
    public Material stoneMat;
    public Material woodMat;
    public Material grassMat;


    void Thing()
    {
        mapTexture = GameObject.Find("Map");
    }

    // Update is called once per frame
    void Update () {
        switch (textureDropdown.value)
        {
            case 1:
                mapTexture.GetComponent<Renderer>().material = stoneMat;
                break;
            case 2:
                mapTexture.GetComponent<Renderer>().material = woodMat;
                break;
            case 3:
                mapTexture.GetComponent<Renderer>().material = grassMat;
                break;
        }
	}
}
