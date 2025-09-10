using UnityEngine;

namespace com.fscigliano.GameEvents
{
    /// <summary>
    /// Product Name:    GameEvents
    /// Developers:      Franco Scigliano
    /// Description:     
    /// Changelog:       
    /// </summary>
    public abstract class GameEvent2Caller<T, T2> : MonoBehaviour
    {
        [SerializeField] protected bool _runOnEnable = false;
        [SerializeField] protected GameEvent2<T, T2> _evt;
        [SerializeField] protected T _arg0;
        [SerializeField] protected T2 _arg1;
        
        private void OnEnable()
        {
            if (_runOnEnable)
                TriggerEvent();
            
        }

        public void TriggerEvent()
        {
            _evt.TriggerEvent(_arg0, _arg1);
        }
    }
}