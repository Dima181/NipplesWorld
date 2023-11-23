using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperBot : MonoBehaviour
{

    [SerializeField] private Transform playerPoint = null;
    [SerializeField] private Transform playerPointLook = null;
    [SerializeField] private float speed = 0;

    [SerializeField] private float range;
    [SerializeField] private LayerMask enemyLayerMask;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        Collider[] enemisc = Physics.OverlapSphere(gameObject.transform.position, range, enemyLayerMask);
        for (int i = 0; i < enemisc.Length; i++)
        {
            transform.LookAt(enemisc[i].transform);
        }
        if(enemisc.Length == 0)
        {
           transform.LookAt(playerPointLook);
        }  
        transform.position = Vector3.Lerp(transform.position, playerPoint.position,  Time.deltaTime);
    }
}
