using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 60f;

    public void takeDamage(float amount){
        health =  health - amount;
        if(health <= 0f) Die();
    }

    void Die(){
        Destroy(gameObject);
    }
}

