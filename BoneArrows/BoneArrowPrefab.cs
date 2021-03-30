using JotunnLib.Entities;

namespace BoneArrows
{
    public class BoneArrowPrefab : PrefabConfig
    {
        public BoneArrowPrefab() : base("ArrowBone", "ArrowFlint")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            item.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.Ammo;
            item.m_itemData.m_shared.m_name = "Bone Arrow";
            item.m_itemData.m_shared.m_description = "Jagged bone tears the flesh.";
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_weight = 0.1f;
            item.m_itemData.m_shared.m_maxStackSize = 100;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_damages.m_pierce = 30;
        }
    }
}