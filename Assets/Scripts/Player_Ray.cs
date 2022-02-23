using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ray : MonoBehaviour
{
    [SerializeField] private float distanceRay;
    [SerializeField] private LayerMask obejectSelectMask;

    private Transform m_Transform;

    private void Awake()
    {
        m_Transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(m_Transform.position, m_Transform.forward);
        Debug.DrawRay(m_Transform.position, m_Transform.forward * distanceRay);

        if (Physics.Raycast(ray, out RaycastHit hitinfo, distanceRay, obejectSelectMask))
        {
            Debug.Log(hitinfo.collider.name);
        }
    }
}