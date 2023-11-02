using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    
    public float damage = 20f; 
    public float range = 100f;

    public Camera shootpoint; 

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hitinfo; 
        if (Physics.Raycast(shootpoint.transform.position, shootpoint.transform.forward, out hitinfo,range))
        {
            Enemy target  = hitinfo.transform.GetComponent<Enemy>();
            if (target != null)
            {
                    target.takeDamage(damage * 2);
            }
        }
    }
}
