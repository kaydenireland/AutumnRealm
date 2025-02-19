using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AutumnRealm.Content.Items.Weapons
{
    class BejeweledStaff : ModItem
    {

        private static readonly int[] GemProjectiles =
        {
            ProjectileID.AmethystBolt,
            ProjectileID.TopazBolt,
            ProjectileID.SapphireBolt,
            ProjectileID.EmeraldBolt,
            ProjectileID.RubyBolt,
            ProjectileID.DiamondBolt,
            ProjectileID.AmberBolt
        };


        public override void SetDefaults()
        {
            Item.damage = 42;
            Item.DamageType = DamageClass.Magic;
            Item.mana = 8;
            Item.width = 52;
            Item.height = 52;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.noMelee = true;
            Item.knockBack = 4;
            Item.value = Item.buyPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.LightPurple;
            Item.UseSound = SoundID.Item43;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.DiamondBolt; // Default, changed dynamically
            Item.shootSpeed = 8f;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockBack)
        {
            int randomProjectile = Main.rand.Next(GemProjectiles.Length);
            Projectile.NewProjectile(source, position, velocity, GemProjectiles[randomProjectile], damage, knockBack, player.whoAmI);
            return false; // Prevents default projectile spawn since we manually spawn it
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.AmethystStaff);
            recipe.AddIngredient(ItemID.TopazStaff);
            recipe.AddIngredient(ItemID.SapphireStaff);
            recipe.AddIngredient(ItemID.EmeraldStaff);
            recipe.AddIngredient(ItemID.RubyStaff);
            recipe.AddIngredient(ItemID.DiamondStaff);
            recipe.AddIngredient(ItemID.AmberStaff);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

    }
}
