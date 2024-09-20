using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Camera : MonoBehaviour
{
    Vector3 GetAverage(Vector3 a, Vector3 b)
    {
        return (a + b) / 2.0f; 
    }

    public void UpdatePosition(Vector3 pos_a, Vector3 pos_b)
    {
        transform.position = GetAverage(pos_a, pos_b) + RectOffset; 
    }

    //start, upadte...

}
*/


public class Player : MonoBehaviour
{
    [SerializeField] public float speed = 1.0f;
    [SerializeField] private Vector3 velocity = Vector3.zero;
    [SerializeField] private uint pid = 0; //Player ID
    bool isFiring = false; 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire_1") > 0.0f)
        {
            Debug.Log("Hello!\n"); 
        }
        //Rigidbody rb = GetComponent<Rigidbody>();

        switch (pid)
        {
            case 1:
                velocity = new Vector3(Input.GetAxis("Horizontal_1"), 0.0f, Input.GetAxis("Vertical_1"));
                //float axisVal = ; 
                isFiring = Input.GetButtonDown("Fire_1");//xisVal > 0.0f) ? true : false; 
                break;
            case 2:
                velocity = new Vector3(Input.GetAxis("Horizontal_2"), 0.0f, Input.GetAxis("Vertical_2"));
                isFiring = (Input.GetAxis("Fire_2") > 0.0f) ? true : false;
                break;
            case 3:
                velocity = new Vector3(Input.GetAxis("Horizontal_3"), 0.0f, Input.GetAxis("Vertical_3"));
                isFiring = (Input.GetAxis("Fire_3") > 0.0f) ? true : false;
                break;
            case 4:
                velocity = new Vector3(Input.GetAxis("Horizontal_4"), 0.0f, Input.GetAxis("Vertical_4"));
                isFiring = (Input.GetAxis("Fire_4") > 0.0f) ? true : false;
                break;
            case 0: 
                Debug.LogWarning("Player ID was not set!");
                break; 
            default:
                Debug.LogWarning("Player ID was invalid");
                break; 
        }


        transform.Translate(velocity  * speed * Time.deltaTime);

        if (isFiring)
        {
            Debug.Log("I'm Firing!\n"); 
        }
    }
}
