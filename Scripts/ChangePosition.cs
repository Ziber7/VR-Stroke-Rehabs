using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangePosition : MonoBehaviour
{
    [SerializeField] Transform movePosition;
    [SerializeField] Transform objToChange;
    // Start is called before the first frame update
    
    public GameObject tes1;

    public void Update()
    {
        objToChange = gameObject.GetComponent<Transform>();
    }

    public void ChangePos()
    {
        tes1.SetActive(false);
        //objToChange = gameObject.GetComponent<Transform>();
        objToChange.transform.position = movePosition.position;
        objToChange.transform.rotation = movePosition.rotation;
        
    }
}
