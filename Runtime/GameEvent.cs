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
    [CreateAssetMenu(menuName = GameEvent.k_menuName + nameof(GameEvent), fileName = nameof(GameEvent))]
    public class GameEvent : ScriptableObject
    {
        public const string k_menuName = "VerticalShootEmUp/Events/";
            
        [SerializeField] protected bool _debug;

        private Action listeners = null;

        public void ResetValues()
        {
            listeners = null;
        }

        public void AddListener(Action callback)
        {
            if (_debug)
            {
                Debug.Log($"<color=yellow>AddListener</color> <color=cyan>{name}</color>", this);
            }


            listeners += callback;
        }

        public void RemoveListener(Action callback)
        {
            if (_debug)
            {
                Debug.Log($"<color=green>RemoveListener</color> <color=cyan>{name}</color>", this);
            }

            listeners -= callback;
        }

        public void TriggerEvent()
        {
            if (_debug)
            {
                Debug.Log($"<color=red>TriggerEvent</color> <color=cyan>{name}</color>", this);
            }
            listeners?.Invoke();
        }
    }
}