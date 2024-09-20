using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    [SerializeField] public GameObject targetable;


    // Collider collision;

    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            targetable.GetComponent<open_door>().DoorOpen();
        }

        
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            targetable.GetComponent<open_door>().DoorClose();
        }

    }



    void OnCollisionEnter()
    {

    }


    void Start()
    {
        // collision = GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}