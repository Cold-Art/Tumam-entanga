using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerStats", menuName = "Game/TowerStats", order = 1)]
public class TowerStats : ScriptableObject
{
    public string towerName = "Tower";
    public float timeBetweenShoots = 0.5f;
    public float range = 5f;
    public int damage = 10;
    public ElementType type = ElementType.Terrestre;

    public GameObject towerPrefab = default;
    public GameObject bulletPrefab = default;
    public TowerStats[] evolutions = default;
}