using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesEs : MonoBehaviour
{
    public GameObject[] esferas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int index = Random.Range(0, esferas.Length);
            Vector3 generador = new Vector3(Random.Range(-10f, 10f), 0, 0);
            //Instantiate(esferas[index],generador);
        }
        
        
    }
}
