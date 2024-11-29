using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerData : MonoBehaviour
{
    public enum CustomerNeed
    {
        Default,
        Money,
        Health,
        Family
    }
}

[CreateAssetMenu(menuName = "Create Customer", fileName = "NewCustomer")]
public class CustomerObject: ScriptableObject
{
    public string customerName;

    public float trust;

    public Vector2 minMaxPayment;

    public CustomerData.CustomerNeed customerNeed;
}
