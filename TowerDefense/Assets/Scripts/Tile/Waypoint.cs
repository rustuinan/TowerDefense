using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceable{get{return isPlaceable;}}

  
    void OnMouseDown() 
    {
        if(isPlaceable)
        {
            Instantiate(towerPrefab, transform.position, quaternion.identity);
            isPlaceable = false;
        }
    }
}
