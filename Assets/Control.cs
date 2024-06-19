using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject[] comidas;
    private int comidasmostradas = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            DeactivateAll();
            comidas[comidasmostradas].SetActive(true);
            if (comidasmostradas != comidas.Length - 1)
            {
                comidasmostradas++;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DeactivateAll();
            comidas[comidasmostradas].SetActive(true);
            if (comidasmostradas != 0)
            {
                comidasmostradas--;
            }
        }
    }

    void DeactivateAll()
    {
        foreach (var objeto in comidas)
        {
            objeto.SetActive(false);
        }
    }
}