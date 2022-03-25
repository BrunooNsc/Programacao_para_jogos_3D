using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    [SerializeField]
    public GameObject canoDaArma;
    [SerializeField]
    public GameObject bala;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var b = Instantiate(bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
            Destroy(bala, 5);
        }
    }
}
