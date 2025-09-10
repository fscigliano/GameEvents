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
    public abstract class GameEvent2<T0, T1> : ScriptableObject
    {
        [SerializeField] protected bool _debug;

        private Action<T0, T1> listeners = null;

        public void ResetValues()
        {
            listeners = null;
        }

        public void AddListener(Action<T0, T1> callback)
        {
            if (_debug)
            {
                Debug.Log($"<color=yellow>AddListener</color> <color=cyan>{name}</color>", this);
            }

            listeners += callback;
        }

        public void RemoveListener(Action<T0, T1> callback)
        {
            if (_debug)
            {
                Debug.Log($"<color=green>RemoveListener</color> <color=cyan>{name}</color>", this);
            }

            listeners -= callback;
        }

        public void TriggerEvent(T0 arg0, T1 arg1)
        {
            if (_debug)
            {
                Debug.Log($"<color=red>TriggerEvent</color> <color=cyan>{name}</color> with arg0 {arg0} , arg1 {arg1}",
                    this);
            }

            listeners?.Invoke(arg0, arg1);
        }
    }
}