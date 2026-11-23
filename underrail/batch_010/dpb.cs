using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000C29 RID: 3113
public sealed class dpb : jn
{
	// Token: 0x0600466D RID: 18029 RVA: 0x001D0B9C File Offset: 0x001CED9C
	public dpb() : base("fo_evelyn", "creature\\characters\\fo_evelyn")
	{
	}

	// Token: 0x0600466E RID: 18030 RVA: 0x001D0BB0 File Offset: 0x001CEDB0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_evelyn_arrested", new bool?(false)).Value)
		{
			return "fo_prison";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("fo_jumpedIntoBunker", new bool?(false)).Value)
		{
			return "fo-bunker";
		}
		return "fo3";
	}

	// Token: 0x0600466F RID: 18031 RVA: 0x001D0C14 File Offset: 0x001CEE14
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "fo3", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_evelyn_seducedYa", new bool?(false)).Value)
		{
			return "bedroom";
		}
		return "home";
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x001D0C64 File Offset: 0x001CEE64
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "fo-bunker", StringComparison.OrdinalIgnoreCase))
			{
				aspect.b("fo_evelyn");
				aspect.y6()[ddq.k] = new List<string>
				{
					"p1",
					"p2",
					"p3",
					"p4",
					"p5",
					"p6",
					"p7",
					"p8",
					"p9"
				};
				aspect.y6()[ddq.l] = 3000;
				aspect.y6()[ddq.n] = true;
				aspect.y6().RemoveProperty(ddq.ay);
				aspect.y6().RemoveProperty(ddq.bs);
				aspect.y6()[ddq.bs] = new exw(d6n.b, 0.0, false, null);
			}
			else if (string.Equals(A_2, "fo_prison", StringComparison.OrdinalIgnoreCase))
			{
				aspect.b("humanSoldier");
				aspect.y6().RemoveProperty(ddq.k);
				aspect.y6().RemoveProperty(ddq.l);
				aspect.y6()[ddq.ay] = new bt4("global:fo_evelyn");
				aspect.y6()[ddq.bs] = new exw(d6n.a, 0.0, false, null);
			}
			else
			{
				aspect.b("humanSoldier");
				aspect.y6().RemoveProperty(ddq.k);
				aspect.y6().RemoveProperty(ddq.l);
				aspect.y6()[ddq.bs] = new exw(d6n.a, 0.0, false, null);
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_evelyn_seducedYa", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:fo_evelyn:bedroom");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:fo_evelyn:home");
				}
			}
		}
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null)
		{
			bool a_;
			if (string.Equals(A_2, "fo-bunker", StringComparison.OrdinalIgnoreCase))
			{
				if (euf.o(aspect2.aa().Offense.u()))
				{
					aspect2.aa().Offense.k();
				}
				a_ = true;
			}
			else if (string.Equals(A_2, "fo_prison", StringComparison.OrdinalIgnoreCase))
			{
				if (aspect2.aa().FactionId != "foundry_inmates")
				{
					aspect2.aa().c(asp.a);
				}
				aspect2.aa().FactionId = "foundry_inmates";
				ItemSlot<coh>[] array = aspect2.aa().Gear.d();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].a(null, true);
				}
				aspect2.aa().Gear.j()[WeaponKey.Primary].a(null, true);
				aspect2.aa().Gear.j()[WeaponKey.Secondary].a(null, true);
				aspect2.aa().Bag.z7();
				a_ = true;
			}
			else
			{
				if (!euf.o(aspect2.aa().Offense.u()))
				{
					aspect2.aa().Offense.k();
				}
				a_ = false;
			}
			foreach (coh coh in aspect2.aa().Bag.z2())
			{
				coh.Stealable = a_;
			}
		}
	}
}
