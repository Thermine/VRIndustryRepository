using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OVRInput;

public class InteractionsScript : MonoBehaviour
{
    [SerializeField]
    private float _indexRangeLeftTrigger;
    [SerializeField]
    private float _indexRangeRightTrigger;
    [SerializeField]
    private float _indexRangeLeftHand;
    [SerializeField]
    private float _indexRangeRightHand;
    [SerializeField]
    private ParticleSystem _water;

    void FixedUpdate()
    {
        _indexRangeLeftTrigger = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
        _indexRangeRightTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
        _indexRangeLeftHand = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
        _indexRangeRightHand = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);

        if(_indexRangeRightHand > 0f)
        {
            if (_indexRangeRightTrigger > 0f)
            {
                _water.Play();
            }
            else
            {
                _water.Stop();
            }
        }

        if (_indexRangeLeftHand > 0f)
        {
            if (_indexRangeLeftTrigger > 0f)
            {
                _water.Play();
            }
            else
            {
                _water.Stop();
            }
        }
    }
}
