using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{
    Material m_Material;
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        int color = Random.Range(0, 2);
        if(color == 0) //red
            m_Material.color = Color.red;
        else m_Material.color = Color.blue;
    }

    void OnDestroy()
    {
        Destroy(m_Material);
    }
}
