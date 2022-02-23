using Verse;
using AnimalBehaviours;

namespace ESCP_Sload
{
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
