using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnZone : MonoBehaviour {

    public GameObject monsterPrefab;

    public Color gizmoColor;

    public int maxMonsterCount = 1;

    private List<GameObject> monsters = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        // only spawn a monster if the current list count does not exceed the limit
        if (monsters.Count < maxMonsterCount && other.GetComponent<Entity>().canTriggerMonsterSpawn)
        {
            // Spawn monster
            GameObject monster = Instantiate(monsterPrefab);
            monster.transform.position = transform.position;
            monster.GetComponent<Entity>().canTriggerMonsterSpawn = false;
            monsters.Add(monster);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Let a monster be able to spawn another one if it exits the zone first
        other.GetComponent<Entity>().canTriggerMonsterSpawn = true;
    }

    private void OnDrawGizmos()
    {
        // Draw the trigger zone bounds
        Gizmos.color = gizmoColor;
        Gizmos.DrawCube(transform.position, transform.localScale);
    }
}
