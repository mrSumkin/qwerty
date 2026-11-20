using System;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000C02 RID: 3074
public sealed class drn : jn
{
	// Token: 0x060045D8 RID: 17880 RVA: 0x001C71A8 File Offset: 0x001C53A8
	public drn() : base("fo_saban", "creature\\characters\\fo_saban")
	{
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x001C71BC File Offset: 0x001C53BC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_saban_helpedFinalFight", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_fo1_finalCutsceneEnded", new bool?(false)).Value)
		{
			return "fo1";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value)
		{
			return "crys2";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_saban_helpedFinalFight", new bool?(false)).Value)
		{
			return "fo5";
		}
		return "fom1";
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x001C7290 File Offset: 0x001C5490
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				cd1 cd = aspect.aa().Gear.j()[WeaponKey.Primary].Item;
				if (cd != null && cd.LoadedAmmo.Count > 0 && cd.LoadedAmmo.Contains(AmmoType.Caliber_44_Std))
				{
					AmmoType item = AmmoType.Caliber_44_W2C;
					cd.LoadedAmmo.Clear();
					for (int i = 0; i < cd.TypedDefinition.f(); i++)
					{
						cd.LoadedAmmo.Add(item);
					}
				}
				if (string.Equals(A_2, "fo5", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = "foundry_the_chosen_few";
					if (aspect.aa().a("Ammo.Caliber_44_Std", false) != null)
					{
						aspect.aa().Bag.a("Ammo.Caliber_44_Std", int.MaxValue);
					}
					coh coh = aspect.aa().a("Ammo.Caliber_44_W2C", false);
					if (coh == null || (coh != null && coh.Stacks < 20))
					{
						aspect.aa().Bag.z3(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_44_W2C"))
						{
							Stacks = 60
						}, true);
					}
				}
				if (string.Equals(A_2, "fom1", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = "foundry";
				}
			}
		}
	}
}
