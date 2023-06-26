using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using LightType = NomadsPlanet.Utils.LightType;

namespace NomadsPlanet
{
    public class LightController : MonoBehaviour
    {
        private LightType _lightType;
        private List<GameObject> _trafficSigns;

        [Button]
        private void Awake()
        {
            _trafficSigns = new List<GameObject>();
            for (int i = 0; i < 3; i++)
            {
                _trafficSigns.Add(transform.GetChild(i).gameObject);
            }
        }

        [ShowInInspector]
        public void SetTrafficSign(LightType seLightType)
        {
            _lightType = seLightType;

            for (int i = 0; i < 3; i++)
            {
                _trafficSigns[i].SetActive(i == (int)seLightType);
            }
        }
    }
}