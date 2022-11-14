using System.Collections.Generic;
using UnityEngine;

// A generic entity that can react to magnetic forces and provides an anchor point for tethering

public abstract class MagneticEntity : MonoBehaviour
{
	public abstract Anchor GetAnchor(Vector3 targetPosition);

	protected void Update()
	{
		UpdateAnchorage();
		ApplyImpulses();
	}

	// Updates self anchor(s)
	protected abstract void UpdateAnchorage();

	// Applies force to self based on attached tethers
	protected abstract void ApplyImpulses();

	protected void OnDisable()
	{
		DetachAnchorage();
	}

	// Tells self anchor(s) to detach any attached tethers
	protected abstract void DetachAnchorage();
}
