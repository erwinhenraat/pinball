using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetForceModifier : MonoBehaviour
{
    public static event Action<float> OnChangeModifier;
    //triggered through Animation Events
    public void SetModifier(float modifier) {
        OnChangeModifier?.Invoke(modifier);
    }
    
}
