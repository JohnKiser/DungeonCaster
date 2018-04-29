using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownTexture : MonoBehaviour {

    public GameObject mapTexture;
    public Dropdown textureDropdown;
    public Material StoneMat;
    public Material WoodMat;
    public Material GrassMat;


    void Thing()
    {
        mapTexture = GameObject.Find("Map");
    }

    // Update is called once per frame
    void Update () {
        switch (textureDropdown.value)
        {
            case 0:
                mapTexture.GetComponent<Renderer>().material = GrassMat;
                break;
            case 1:
                mapTexture.GetComponent<Renderer>().material = WoodMat;
                break;
            case 2:
                mapTexture.GetComponent<Renderer>().material = StoneMat;
                break;
        }
	}
}
