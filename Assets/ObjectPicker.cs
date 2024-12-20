using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    [SerializeField] private float _takeDistance;
    [SerializeField] private float _holdDistance;
    [SerializeField] private float _throwForce;

    private PickingObject _currentObject;

    public void PickUp()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, _takeDistance) == false)
            return;

        if (hitInfo.transform.TryGetComponent(out PickingObject pickingObject) == false)
            return;

        _currentObject = pickingObject;
        _currentObject.PickUp(transform, _holdDistance);
    }

    public void Drop()
    {
        ThrowObject(Vector3.zero);
    }

    public void Throw()
    {
        ThrowObject(transform.forward * _throwForce);
    }

    private void ThrowObject(Vector3 force)
    {
        _currentObject.Throw(force);
        _currentObject = null;
    }
}
