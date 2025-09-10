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
    public abstract class GameEvent1Listener<T, TEvt, TUEvt> : MonoBehaviour where TEvt:GameEvent1<T> where TUEvt:UnityEvent<T>
    {
        [SerializeField] protected TEvt _evt;
        [SerializeField] protected TUEvt _uEvt;
        private void OnEnable()
        {
            _evt.AddListener(HandleEvt);
        }

        private void HandleEvt(T arg0)
        {
            _uEvt.Invoke(arg0);
        }

        private void OnDisable()
        {
            _evt.RemoveListener(HandleEvt);
        }
    }
}