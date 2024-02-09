using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploIntance : MonoBehaviour
{
    [SerializeField]
    GameObject gameObjectPrefab;
    
    [SerializeField]
    float height = 0.77f;
    [SerializeField]
    float minX = 0.0f;
    [SerializeField]
    float maxX = 3.6f;

    [SerializeField]
    Vector2 rangeZ = new Vector2(-1.75f, 1.8f);

    [System.Serializable]
    public class Range {
        [Tooltip("Minimo del rango")]
        public float min;
        [Tooltip("Maximo del rango")]
        public float max;
        public Range(float minimo, float max)
        {
            this.min = minimo;
            this.max = max;
        }

        public Range()
        {
            min = Random.Range(-999f, 999f);
            max = Random.Range(-999f, 999f);
        }
    }

    [SerializeField]
    Range rangeX = new Range(0.0f,3.6f);
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 7;i++)
        {
            CreateHelmet();
        }

    }

    void CreateHelmet()
    {
        GameObject clone = Instantiate(gameObjectPrefab);
        clone.name = "MiCasco";
        clone.transform.position = new Vector3(Random.Range(rangeX.min, rangeX.max), height, Random.Range(rangeZ.x, rangeZ.y));
        clone.transform.localScale *= 2f;
    }

    // Update is called once per frame

    
    void Update()
    {
        bool parar = false;
        int unNumero = 0;
        while (parar == false)
        {

            unNumero++;

            if(unNumero > 100)
            {
                parar = true;
            }
        }
    }
}
