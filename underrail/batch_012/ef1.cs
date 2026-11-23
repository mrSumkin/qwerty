using System;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001783 RID: 6019
[z1("slampipe")]
internal sealed class ef1 : c1f
{
	// Token: 0x06008129 RID: 33065 RVA: 0x00367784 File Offset: 0x00365984
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new ax6(BaseAbilityEnum.Strength.ToString(), 1),
			new ax6(BaseAbilityEnum.Agility.ToString(), -1),
			new cuv(0.15, WeaponAggregateSubtype.BluntMelee),
			new cuv(0.15, WeaponAggregateSubtype.Gloves),
			new cuv(0.15, WeaponAggregateSubtype.Unarmed)
		};
		A_1 = null;
		A_2 = null;
	}

	// Token: 0x0600812A RID: 33066 RVA: 0x00367808 File Offset: 0x00365A08
	public override string o6()
	{
		return "DrinkPotion";
	}

	// Token: 0x0600812B RID: 33067 RVA: 0x00367810 File Offset: 0x00365A10
	public override void pw(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			string path = "components\\Containers\\bottle";
			if (ez2.GetItemDefinition<a1k>(path, true) != null)
			{
				fv a_ = new fv(ez2.CreateDefinitonProvider<a1k>(path));
				mk mk = new mk();
				mk.StaticItems.z3(a_, true);
				mk.ym(null, A_0, null);
			}
		}
	}
}
