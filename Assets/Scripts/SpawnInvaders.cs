using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;


    void Awake()
    {
        /*
         * pega neste objeto, duplica e coloca-o naquele sitio
         */

        float x = xMin;
        float y = yMin;
        for(int i = 1; i <= nInvasores; i++) /* (i = i + 1) same que (i += 1) e que (i++) */
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x, y, 0f);
            x += xInc;
        }
        y += yInc;

        x = xMin;
        for (int i = 1; i <= nInvasores; i++) 
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x, y, 0f);
            x += xInc;
        }
        y += yInc;


        x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorB, transform);
            newInvader.transform.position = new Vector3(x, y, 0f);
            x += xInc;
        }
        y += yInc;

        x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorB, transform);
            newInvader.transform.position = new Vector3(x, y, 0f);
            x += xInc;
        }
        y += yInc;


        x = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorC, transform);
            newInvader.transform.position = new Vector3(x, y, 0f);
            x += xInc;
        }
        y += yInc;

    }

}
