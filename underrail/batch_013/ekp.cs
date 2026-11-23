using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000BEE RID: 3054
public sealed class ekp : jn
{
	// Token: 0x0600459F RID: 17823 RVA: 0x001C4FC4 File Offset: 0x001C31C4
	public ekp() : base("fd_kokoschka", "creature\\characters\\fd_kokoschka")
	{
	}

	// Token: 0x060045A0 RID: 17824 RVA: 0x001C4FDC File Offset: 0x001C31DC
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROStarted", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value)
		{
			return "lup_freeDroneBase";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROStarted_moveNextStage", new bool?(false)).Value)
		{
			return "lu-b31";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROStarted_startAttack", new bool?(false)).Value)
		{
			return "lu-b30";
		}
		return "lu-b6";
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x001C508C File Offset: 0x001C328C
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "lu-b30", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_b30_clearedProtectorate", new bool?(false)).Value || (!A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROSpyRevealed", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSRO_entered_lu-b30", new bool?(false)).Value))
			{
				return "end";
			}
			return "start";
		}
		else
		{
			if (!string.Equals(A_1, "lu-b31", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_b31_clearedProtectorate", new bool?(false)).Value)
			{
				return "end";
			}
			return "start";
		}
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x001C5160 File Offset: 0x001C3360
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null && (aspect2.am().StartsWith("mutated_human") || aspect2.am().StartsWith("mhun")))
		{
			return;
		}
		if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_fd_kokoschka_weaponRegulated", new bool?(false)).Value)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("lo_lu-b29_trainFound", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_lu-b29_entered", new bool?(false)).Value)
			{
				if (aspect2.aa().Gear.j()[WeaponKey.Primary] != null)
				{
					goto IL_1BE;
				}
				b2d b2d = new b2d();
				b2d.na(14);
				b2d.nc(20);
				b2d.d(150);
				using (List<coh>.Enumerator enumerator = b2d.np().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						coh coh = enumerator.Current;
						if (coh is cd1)
						{
							euf.a(coh, null);
							aspect2.aa().Gear.j()[WeaponKey.Secondary].a(coh as cd1, true);
						}
						else
						{
							aspect2.aa().Bag.z3(coh, true);
						}
					}
					goto IL_1BE;
				}
			}
			aspect2.aa().Gear.j()[WeaponKey.Primary].b(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\ak")));
			aspect2.aa().Bag.z3(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_762_Std"))
			{
				Stacks = 150
			}, true);
			IL_1BE:
			A_1.r()["npc_fd_kokoschka_weaponRegulated"] = true;
		}
		if (A_1.r().GetPrimitivePropertyValue<bool>("npc_fd_kokoschka_returnedRifle", new bool?(false)).Value && aspect2.aa().Gear.j()[WeaponKey.Primary] == null)
		{
			cd1 cd = Enumerable.FirstOrDefault<coh>(aspect2.aa().Bag.b("wep.ak")) as cd1;
			if (cd == null)
			{
				cd = (Enumerable.FirstOrDefault<coh>(aspect2.aa().Bag.b("wep.ak_refurbished")) as cd1);
			}
			if (cd != null)
			{
				aspect2.aa().Gear.j()[WeaponKey.Primary].b(cd);
			}
		}
		if (aspect != null)
		{
			if (string.Equals(A_2, "lu-b6", StringComparison.OrdinalIgnoreCase))
			{
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drone_squad";
				}
			}
			else if (string.Equals(A_2, "lu-b30", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6().RemoveProperty(ddq.bg);
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drone_squad";
					if (aspect2.aa().Gear.h().Item != null)
					{
						aspect2.aa().Defense.a(true);
					}
				}
				aspect.y6()[ddq.ay] = new bt4("global:fd_kokoschka:end");
			}
			else if (string.Equals(A_2, "lu-b31", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6().RemoveProperty(ddq.bg);
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drone_squad";
				}
				aspect.y6()[ddq.k] = new List<string>
				{
					"global:fd_kokoschka:end",
					"global:fd_kokoschka:clear"
				};
			}
			else
			{
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drones";
				}
				aspect.y6()[ddq.ay] = new bt4("global:fd_kokoschka");
			}
		}
		if (A_1.r().GetPrimitivePropertyValue<bool>("npc_fd_kokoschka_gaveCzernina", new bool?(false)).Value)
		{
			aspect2.aa().AttributesBase |= d8o.o;
		}
	}
}
