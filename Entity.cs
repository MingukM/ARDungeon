using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]
public class Entity : MonoBehaviour {

    
    public float health = 100;

    public bool canTriggerMonsterSpawn = false;
	
}
