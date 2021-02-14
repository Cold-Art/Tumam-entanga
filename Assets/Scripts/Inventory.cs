using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] int startGold = 100;

    public int Gold { get; private set; }

    private void Awake()
    {
        Gold = startGold;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
    }

    [ContextMenu("Add 100 Gold")]

    private void Add100Gold()
    {
        AddGold(100);
    }
}
