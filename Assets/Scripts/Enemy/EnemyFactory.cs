using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField] public GameObject[] enemyPrefab;

    public GameObject FactoryMethod(int tag, Transform location)
    {
        GameObject enemy = Instantiate(enemyPrefab[tag], location);
        return enemy;
    }
}