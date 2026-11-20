using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000C28 RID: 3112
public sealed class ej : jn
{
	// Token: 0x06004669 RID: 18025 RVA: 0x001D0774 File Offset: 0x001CE974
	public ej() : base("fo_nicolas", "creature\\characters\\fo_nicolas")
	{
	}

	// Token: 0x0600466A RID: 18026 RVA: 0x001D0788 File Offset: 0x001CE988
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_arrested", new bool?(false)).Value)
		{
			return "fo_prison";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_throw_out", new bool?(false)).Value)
		{
			return "fo4";
		}
		return "fo3";
	}

	// Token: 0x0600466B RID: 18027 RVA: 0x001D07EC File Offset: 0x001CE9EC
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "fo3", StringComparison.OrdinalIgnoreCase))
		{
			A_0.r()["npc_fo_nicolas_drunk"] = true;
		}
		else if (string.Equals(A_1, "fo4", StringComparison.OrdinalIgnoreCase))
		{
			A_0.r()["npc_fo_nicolas_drunk"] = false;
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_follow", new bool?(false)).Value)
			{
				return "corner";
			}
			return "work";
		}
		return null;
	}

	// Token: 0x0600466C RID: 18028 RVA: 0x001D087C File Offset: 0x001CEA7C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "fo4", StringComparison.OrdinalIgnoreCase))
			{
				aspect.b("fo_nicolas");
				aspect.y6()[ddq.k] = new List<string>
				{
					"nicolas_patrol1",
					"nicolas_patrol2",
					"nicolas_patrol3"
				};
				aspect.y6()[ddq.l] = 40000;
				aspect.y6()[ddq.n] = true;
				aspect.y6()[ddq.o] = CharacterState.Operating;
				aspect.y6()[ddq.s] = 100;
				aspect.y6()[ddq.v] = new List<string>
				{
					"nicolas_patrol1"
				};
				aspect.y6().RemoveProperty(ddq.ay);
			}
			else
			{
				aspect.b("humanSoldier");
				aspect.y6().RemoveProperty(ddq.k);
				aspect.y6().RemoveProperty(ddq.l);
				aspect.y6().RemoveProperty(ddq.o);
				aspect.y6().RemoveProperty(ddq.s);
				aspect.y6().RemoveProperty(ddq.n);
				aspect.y6().RemoveProperty(ddq.v);
				aspect.y6()[ddq.ay] = new bt4("global:fo_nicolas");
				aspect.y6().RemoveProperty(ddq.bs);
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
			if (!string.Equals(A_2, "fo3", StringComparison.OrdinalIgnoreCase))
			{
				if (aspect2 != null && !aspect2.aa().StatusEffects.a(c9i.a))
				{
					aspect2.aa().StatusEffects.d(Enumerable.FirstOrDefault<c9i>(aspect2.aa().StatusEffects.Get<c9i>()));
				}
				aspect.y6().RemoveProperty(ddq.b2);
				aspect.y6().RemoveProperty(ddq.b4);
				return;
			}
			aspect.y6()[ddq.b2] = true;
			aspect.y6()[ddq.b4] = 500;
		}
	}
}
