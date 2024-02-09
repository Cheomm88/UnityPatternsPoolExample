using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetBehaviour : MonoBehaviour
{

    float time = 0.0f;
    [SerializeField]
    float lifeTime = 0.5f;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > lifeTime)
        {
            //Desactivar
            time = 0.0f;
            this.gameObject.SetActive(false);
            HelmetPool.instance.DevolverObjeto(this.gameObject);
        }
    }

    void OnEnable()
    {
        time = 0.0f;
    }
}
