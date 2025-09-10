using UnityEngine;
using UnityEngine.Events;

namespace com.fscigliano.GameEvents
{
    /// <summary>
    /// Product Name:    GameEvents
    /// Developers:      Franco Scigliano
    /// Description:     
    /// Changelog:       
    /// </summary>
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] protected GameEvent _evt;
        [SerializeField] protected UnityEvent _uEvt;
        private void OnEnable()
        {
            _evt.AddListener(HandleEvt);
        }

        private void HandleEvt()
        {
            _uEvt.Invoke();
        }

        private void OnDisable()
        {
            _evt.RemoveListener(HandleEvt);
        }
    }
}