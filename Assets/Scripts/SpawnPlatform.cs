using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public static SpawnPlatform Instance {get; private set; }
    [SerializeField] private Transform _spawnPoint = default;
    [SerializeField] private Transform _groundClone = default;
    [SerializeField] private Transform _ground = default;

    public void Spawn()
    {
        _groundClone = Instantiate(_ground, _spawnPoint.position, _spawnPoint.rotation);
    } 

    private void OnTriggerEnter(Collider other) 
    {
        Spawn();
        Destroy(gameObject, 10);
    }
}
