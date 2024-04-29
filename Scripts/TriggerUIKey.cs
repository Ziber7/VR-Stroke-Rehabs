using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUIKey : MonoBehaviour
{
    public GameObject UIKey;

    // Start is called before the first frame update
    void Start()
    {
        UIKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            UIKey.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            UIKey.SetActive(false);
        }
    }
}
