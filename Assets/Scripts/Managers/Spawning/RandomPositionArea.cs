using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomPositionArea : MonoBehaviour
{
    #region => ===== Components =====

    Collider _col;

    private void Awake()
    {
        _col = GetComponent<Collider>();
    }

    #endregion

    private void OnEnable()
    {
        SpawnManager.ActiveSpawners.Add(this);
    }

    private void OnDisable()
    {
        SpawnManager.ActiveSpawners.Remove(this);
    }

    public Vector3 GetRandomPositionInArea()
    {
        float x = Random.Range(_col.bounds.min.x, _col.bounds.max.x);
        float y = Random.Range(_col.bounds.min.y, _col.bounds.max.y);
        float z = Random.Range(_col.bounds.min.z, _col.bounds.max.z);

        if (NavMesh.SamplePosition(new Vector3(x, y, z), out NavMeshHit hit, 500f, NavMesh.AllAreas))
        {
            return hit.position;
        }
        else
        {
            return Vector3.zero;
        }
    }
}