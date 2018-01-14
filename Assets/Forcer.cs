using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Forcer : MonoBehaviour
{
    public Vector3 m_forceDirection = Vector3.up;
    public float m_forcePower = 250.0f;
    public ForceMode m_forceMode = ForceMode.Impulse;
    Vector3 m_initialPosition = Vector3.zero;

    void Start()
    {
        m_initialPosition = transform.position;
    }

    public void Attack()
    {
        GetComponent<Rigidbody>().AddForce(m_forcePower * m_forceDirection, m_forceMode);
    }

    public void ResetPosition()
    {
        transform.position = m_initialPosition;
    }
}