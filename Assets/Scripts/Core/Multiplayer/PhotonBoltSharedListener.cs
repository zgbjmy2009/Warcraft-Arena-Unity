﻿using Bolt;
using UnityEngine;

namespace Core
{
    public class PhotonBoltSharedListener : GlobalEventListener
    {
        public override void Connected(BoltConnection boltConnection)
        {
            Debug.Log($"Player with ConnectionId: {boltConnection.ConnectionId} joined the game!");
        }

        public override void Disconnected(BoltConnection boltConnection)
        {
            Debug.Log($"Player with ConnectionId: {boltConnection.ConnectionId} left the game!");
        }
    }
}