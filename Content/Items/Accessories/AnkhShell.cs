using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AutumnRealm.Content.Items.Accessories
{
    class AnkhShell : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 38;
            Item.maxStack = 1;
            Item.value = Item.buyPrice(0, 20, 0, 0);
            Item.rare = ItemRarityID.Red;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // Ankh Shield Effects
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.buffImmune[BuffID.Weak] = true;
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.Silenced] = true;
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.Darkness] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Suffocation] = true;
            player.noKnockback = true;

            // Celestial Shell Effects
            player.accMerman = true; // Allows water movement bonuses
            player.wolfAcc = true; // Increases melee speed at night
            player.lifeRegen += 2;
            player.statDefense += 4;
            player.moveSpeed += 0.1f;

            player.GetDamage(DamageClass.Melee) += 0.1f;
            player.GetCritChance(DamageClass.Melee) += 2;
            player.GetAttackSpeed(DamageClass.Melee) += 0.1f;

            player.GetDamage(DamageClass.Magic) += 0.1f;
            player.GetCritChance(DamageClass.Magic) += 2;

            player.GetDamage(DamageClass.Ranged) += 0.1f;
            player.GetCritChance(DamageClass.Ranged) += 2;

            player.GetDamage(DamageClass.Summon) += 0.1f;

            player.GetDamage(DamageClass.Throwing) += 0.1f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.AnkhShield);
            recipe.AddIngredient(ItemID.CelestialShell);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }

    }
}
