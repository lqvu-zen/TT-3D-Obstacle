using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float m_spinnerXAngle = 0f;
    [SerializeField] float m_spinnerYAngle = 0f;
    [SerializeField] float m_spinnerZAngle = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(m_spinnerXAngle, m_spinnerYAngle, m_spinnerZAngle);
    }
}
