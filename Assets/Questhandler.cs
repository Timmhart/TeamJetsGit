using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questhandler : MonoBehaviour
{

    public GameObject quest1;
    public GameObject quest2;
    // Start is called before the first frame update
    void Start()
    {
        quest1.SetActive(true);
        quest2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            quest1.SetActive(false);
            quest2.SetActive(true);
        }
    }
}
