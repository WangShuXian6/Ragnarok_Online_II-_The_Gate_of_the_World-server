using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Rekard : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1161;
            Name = "Rekard";
            StartX = 14431F;
            StartY = 74144F;
            StartZ = 5094;
            Startyaw = 3399;
            SetScript(3);
        AddButton(Functions.EnterShip,new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
            Warp(pc, 22, -27593F, 8170F, -349);
        }

    }
}