﻿using UnityEngine;

namespace DEVN
{

/// <summary>
/// a node which dictates the start of a scene. Is instantiated
/// upon the creation of a DEVN Scene
/// </summary>
[System.Serializable]
public class StartNode : BaseNode
{
#if UNITY_EDITOR

	public override void Init(Vector2 position)
    {
        base.Init(position);
        
        m_title = "Start";

        m_rectangle.width = 100;
        m_rectangle.height = 50;

        AddOutputPoint(); // linear
    }

    /// <summary>
    /// no context menu allowed for start node
    /// </summary>
    protected override void ProcessContextMenu()
    {
        return;
    }

#endif
}

}