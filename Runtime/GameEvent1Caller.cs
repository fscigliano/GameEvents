using UnityEngine;

namespace com.fscigliano.GameEvents
{
    /// <summary>
    /// Product Name:    GameEvents
    /// Developers:      Franco Scigliano
    /// Description:     
    /// Changelog:       
    /// </summary>
    public abstract class GameEvent1Caller<T> : MonoBehaviour
    {
        [SerializeField] protected bool _runOnEnable = false;
        [SerializeField] protected GameEvent1<T> _evt;
        [SerializeField] protected T _arg0;
        private void OnEnable()
        {
            if (_runOnEnable)
                TriggerEvent();
            
        }

        public void TriggerEvent()
        {
            _evt.TriggerEvent(_arg0);
        }
    }
}