using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ResetPosition : MonoBehaviour
{
    [SerializeField] Transform originPosition;
    [SerializeField] Transform obj;
    // Start is called before the first frame update
    
    public void Update()
    {
        obj = gameObject.GetComponent<Transform>();
    }
    public void ResetPos()
    {
        obj.transform.position = originPosition.position;
        obj.transform.rotation = originPosition.rotation;
    }

    void Start()
    {
        ResetPos();
    }
}
