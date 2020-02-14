using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Mirror;

public class DataDisk : NetworkBehaviour, IClientInteractable<HandActivate>, IClientInteractable<HandApply>
{
	public bool Interact(HandActivate interaction)
	{
		throw new NotImplementedException();
	}

	public bool Interact(HandApply interaction)
	{
		throw new NotImplementedException();
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
