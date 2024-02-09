using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float maxTime = 2.0f;

    float tiempoPasado = 2.0f;
    bool ejecutado = false;

    
    [SerializeField]
    GameObject prefab;
    
    // Update is called once per frame
    void Update()
    {
        tiempoPasado -= Time.deltaTime;
       
        if (tiempoPasado > maxTime)
        {
            Debug.Log("Han pasado " + maxTime  + " segundos");            
            GameObject nuevoCubo = Instantiate(prefab, new Vector3(1.5f, 0.5f, 0f), Quaternion.identity);
            nuevoCubo.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10f, ForceMode.Impulse);
            tiempoPasado = maxTime;
        }
    }
}
