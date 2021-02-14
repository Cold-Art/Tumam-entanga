using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int startHP = 100;
    [SerializeField] int damage = 10;
    [SerializeField] ElementType type;

    public ElementType Type { get { return type; } }

    private int currentHP;

    private void Start()
    {
        currentHP = startHP;
    }

    public void Damage(int value)
    {
        currentHP -= value;

        if (currentHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

public enum ElementType { Terrestre, Aereo }