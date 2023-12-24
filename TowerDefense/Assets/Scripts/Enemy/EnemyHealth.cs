using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    [SerializeField] int currentHitPoint = 0;
    void Start()
    {
        currentHitPoint = maxHitPoints;
    }

    void OnParticleCollision(GameObject other) 
    {
        ProccesHit();
    }

    void ProccesHit()
    {
        currentHitPoint--;

        if(currentHitPoint <= 0)
        {
            Destroy(gameObject);
        }
    }
}
