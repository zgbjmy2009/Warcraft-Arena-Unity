﻿namespace Server
{
    public partial class PhotonBoltServerListener
    {
        public override void OnEvent(TargetSelectionRequestEvent targetingRequest)
        {
            base.OnEvent(targetingRequest);

            if (targetingRequest.FromSelf)
                return;

            World.FindPlayer(targetingRequest.RaisedBy)?.Attributes.UpdateTarget(targetingRequest.TargetId.PackedValue, updateState: true);
        }
    }
}
