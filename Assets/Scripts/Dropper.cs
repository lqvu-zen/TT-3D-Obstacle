using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer m_meshRenderer;
    Rigidbody m_rigidBody;
    [SerializeField]
    float m_timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        m_meshRenderer = GetComponent<MeshRenderer>();
        m_rigidBody = GetComponent<Rigidbody>();

        m_meshRenderer.enabled = false;
        m_rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > m_timeToWait)
        {
            m_meshRenderer.enabled = true;
            m_rigidBody.useGravity = true;
        }    
    }
}
