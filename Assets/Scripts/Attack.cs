using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public void Fire(float amount)
    {
        Debug.Log($"Герой использовал атаку, сила атаки: {amount}");
    }
}
