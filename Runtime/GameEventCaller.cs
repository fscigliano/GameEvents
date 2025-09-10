using UnityEngine;

namespace com.fscigliano.GameEvents
{
    /// <summary>
    /// Product Name:    GameEvents
    /// Developers:      Franco Scigliano
    /// Description:     
    /// Changelog:       
    /// </summary>
    public class GameEventCaller : MonoBehaviour
    {
        [SerializeField] protected bool _runOnEnable = false;
        [SerializeField] protected GameEvent _evt;

        private void OnEnable()
        {
            if (_runOnEnable)
                TriggerEvent();
            
        }

        public void TriggerEvent()
        {
            _evt.TriggerEvent();
        }
    }
}