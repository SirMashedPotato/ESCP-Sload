﻿using Verse;
using AnimalBehaviours;

namespace ESCP_Sload
{
    /* Basically the same as the comp in Vanilla Expanded Framework, but only adds the draftable gizmo if the animal is a thrall.
     * Everything else is handled by VE Framework.
     * Should be the only thing that requires VFECore
     */

    class CompDraftableThrall : ThingComp
    {
        public override void PostSpawnSetup(bool respawningAfterLoad)
        {
            if (SloadUtility.ThingIsThrall(parent) && !AnimalCollectionClass.draftable_animals.Contains(parent))
            {
                AnimalCollectionClass.AddDraftableAnimalToList(parent);
            }
        }

        public override void PostDeSpawn(Map map)
        {
            if (SloadUtility.ThingIsThrall(parent) && AnimalCollectionClass.draftable_animals.Contains(parent))
            {
                AnimalCollectionClass.RemoveDraftableAnimalFromList(parent);
            }
        }

        public override void PostDestroy(DestroyMode mode, Map previousMap)
        {
            if (SloadUtility.ThingIsThrall(parent) && AnimalCollectionClass.draftable_animals.Contains(parent))
            {
                AnimalCollectionClass.RemoveDraftableAnimalFromList(parent);
            }
        }
    }
}
