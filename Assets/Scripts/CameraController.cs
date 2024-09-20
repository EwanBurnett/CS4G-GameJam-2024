using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Camera : MonoBehaviour
{
    [SerializeField] public GameObject Player1;
    [SerializeField] public GameObject Player2;

    [SerializeField] private Vector3 offset = new Vector3(0.0f, 0.0f, -7.0f);

    public Vector3 posAverage(Vector3 a, Vector3 b)
    {
        return (a + b) / 2;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = posAverage(Player1.transform.position, Player2.transform.position) + offset;
    }
}