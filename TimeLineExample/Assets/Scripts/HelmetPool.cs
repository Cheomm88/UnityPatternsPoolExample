using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetPool : MonoBehaviour
{
    [SerializeField] int maximoElementos = 100;
    [SerializeField] GameObject objectoACrear;

    private Stack<GameObject> pool;

    public static HelmetPool instance;
    private void Awake()
    {
        if (HelmetPool.instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

    }
    void Start()
    {
        SetupPool();
    }

    void SetupPool()
    {
        pool = new Stack<GameObject>();
        GameObject cascoCreado = null;

        //Crear un for hasta el máximo de elementos
        for(int i = 0; i < maximoElementos;i++)
        {
            cascoCreado = Instantiate(objectoACrear);
            cascoCreado.SetActive(false);
            pool.Push(cascoCreado);
        }        
    }

    public GameObject ObtenerObjeto()
    {
        GameObject casco = null;
        if (pool.Count == 0)
        {
            casco = Instantiate(objectoACrear);
        }
        else
        {
            casco = pool.Pop();
            casco.SetActive(true);

        }
        return casco;
    }

    public void DevolverObjeto(GameObject cascoDevuelto)
    {
        pool.Push(cascoDevuelto);
        cascoDevuelto.SetActive(false);
    }
}
