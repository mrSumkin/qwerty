using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000BE4 RID: 3044
public sealed class e16 : jn
{
	// Token: 0x0600457E RID: 17790 RVA: 0x001C3CC4 File Offset: 0x001C1EC4
	public e16() : base("fo_olivia", "creature\\characters\\fo_olivia")
	{
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x001C3CD8 File Offset: 0x001C1ED8
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_arrested", new bool?(false)).Value)
		{
			return "fo_prison";
		}
		return "fom1";
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x001C3D14 File Offset: 0x001C1F14
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "fom1", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.k] = new List<string>
				{
					"olivia_patrol1",
					"olivia_patrol2"
				};
				aspect.y6()[ddq.l] = 45000;
				aspect.y6()[ddq.n] = true;
				aspect.y6()[ddq.o] = CharacterState.Operating;
				aspect.y6()[ddq.s] = 45;
				aspect.y6().RemoveProperty(ddq.ay);
				return;
			}
			aspect.b("humanSoldier");
			aspect.y6().RemoveProperty(ddq.k);
			aspect.y6().RemoveProperty(ddq.l);
			aspect.y6().RemoveProperty(ddq.o);
			aspect.y6().RemoveProperty(ddq.s);
			aspect.y6().RemoveProperty(ddq.n);
			aspect.y6().RemoveProperty(ddq.v);
			aspect.y6()[ddq.ay] = new bt4("global:fo_olivia");
			if (string.Equals(A_2, "fo_prison", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.bs] = new exw(d6n.a, 0.0, false, null);
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "foundry_inmates";
					ItemSlot<coh>[] array = aspect2.aa().Gear.d();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].a(null, true);
					}
					aspect2.aa().Gear.j()[WeaponKey.Primary].a(null, true);
					aspect2.aa().Gear.j()[WeaponKey.Secondary].a(null, true);
					aspect2.aa().Bag.z7();
				}
			}
		}
	}
}
