using Verse;
using AnimalBehaviours;

namespace ESCP_Sload
{
    /* Basically the same as the comp in Vanilla Expanded Framework, but only adds the draftable gizmo if the animal is a thrall.
     * Everything else is handled by VE Framework.
     */

    class CompDraftableThrall : ThingComp
    {
        public override void PostSpawnSetup(bool respawningAfterLoad)
        {
            if (SloadUtility.ThingIsThrall(this.parent) && !AnimalCollectionClass.draftable_animals.Contains(this.parent))
            {
                AnimalCollectionClass.AddDraftableAnimalToList(this.parent);
            }
        }

        public override void PostDeSpawn(Map map)
        {
            if (SloadUtility.ThingIsThrall(this.parent) && AnimalCollectionClass.draftable_animals.Contains(this.parent))
            {
                AnimalCollectionClass.RemoveDraftableAnimalFromList(this.parent);
            }
        }

        public override void PostDestroy(DestroyMode mode, Map previousMap)
        {
            if (SloadUtility.ThingIsThrall(this.parent) && AnimalCollectionClass.draftable_animals.Contains(this.parent))
            {
                AnimalCollectionClass.RemoveDraftableAnimalFromList(this.parent);
            }
        }
    }
}
