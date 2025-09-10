using System;
using UnityEngine;

namespace com.fscigliano.GameEvents
{
    /// <summary>
    /// Product Name:    GameEvents
    /// Developers:      Franco Scigliano
    /// Description:     
    /// Changelog:       
    /// </summary>
    public abstract class GameEvent1<T0> : ScriptableObject
    {
        [SerializeField] protected bool _debug;

        private Action<T0> listeners = null;

        public void ResetValues()
        {
            listeners = null;
        }

        public void AddListener(Action<T0> callback)
        {
            if (_debug)
            {
                Debug.Log($"<color=yellow>AddListener</color> <color=cyan>{name}</color>", this);
            }

            listeners += callback;
        }

        public void RemoveListener(Action<T0> callback)
        {
            if (_debug)
            {
                Debug.Log($"<color=green>RemoveListener</color> <color=cyan>{name}</color>", this);
            }

            listeners -= callback;
        }

        public void TriggerEvent(T0 arg0)
        {
            if (_debug)
            {
                Debug.Log($"<color=red>TriggerEvent</color> <color=cyan>{name}</color> with arg0 {arg0}", this);
            }

            listeners?.Invoke(arg0);
        }
    }
}