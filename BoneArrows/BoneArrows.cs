using System;
using BepInEx;
using JotunnLib.Managers;
using JotunnLib.Entities;

namespace BoneArrows
{
    [BepInPlugin("com.bepinex.plugins.bonearrows", "BoneArrows", "0.1.0")]
    [BepInDependency("com.bepinex.plugins.jotunnlib")]
    public class BoneArrows : BaseUnityPlugin
    {
        private void Awake()
        {
            ObjectManager.Instance.ObjectRegister += registerObjects;
            PrefabManager.Instance.PrefabRegister += registerPrefabs;
        }

        private void registerPrefabs(object sender, EventArgs e)
        {
            PrefabManager.Instance.RegisterPrefab(new BoneArrowPrefab());
        }

        private void registerObjects(object sender, EventArgs e)
        {
            ObjectManager.Instance.RegisterItem("ArrowBone");

            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_BoneArrows",
                Item = "ArrowBone",
                Amount = 20,
                CraftingStation = "piece_workbench",

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "Wood",
                        Amount = 8
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Feathers",
                        Amount = 2
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "BoneFragments",
                        Amount = 5
                    },
                }
            });
        }
    }
}