using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleExtraForce : MonoBehaviour
{
    public static event Action<bool> OnToggle;
    //triggered through Animation Events
    public void EnableExtraForce() {
        OnToggle?.Invoke(true);
    }
    public void DisableExtraForce()
    {
        OnToggle?.Invoke(false);
    }
}
