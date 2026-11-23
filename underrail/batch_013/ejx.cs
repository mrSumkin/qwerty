using System;
using TimelapseVertigo.Game.Fragments;

// Token: 0x02000BD3 RID: 3027
public sealed class ejx : jn
{
	// Token: 0x06004549 RID: 17737 RVA: 0x001C28CC File Offset: 0x001C0ACC
	public ejx() : base("dun_ryl", "creature\\characters\\dun_ryl")
	{
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x001C28E4 File Offset: 0x001C0AE4
	public override string b1(cyt A_0)
	{
		bq8 bq = A_0.e();
		if (bq.GetPrimitivePropertyValue<bool>("npc_dun_llb4_diedRyl_settled", new bool?(false)).Value)
		{
			return null;
		}
		DungeonEntrance? primitivePropertyValue = bq.GetPrimitivePropertyValue<DungeonEntrance>("dungeon_dun_lowLevelBunker4_entrance", null);
		if (primitivePropertyValue == null || primitivePropertyValue.Value == DungeonEntrance.TransitionWest || (A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_dun_llb4_entered", new bool?(false)).Value))
		{
			return null;
		}
		if ((A_0.ac() as bv9).abu(asp.a, asp.g2).a == h.a)
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_dun_llb4_diedRyl_helped", new bool?(false)).Value)
		{
			return "dun_lowLevelBunker4";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_dun_llb4_diedrick_alive", new bool?(false)).Value)
		{
			return "cc-res";
		}
		return "jy2";
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x001C2A30 File Offset: 0x001C0C30
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "cc-res", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.di;
				aspect.aa().HostilityBroadcastMode = c2n.d;
				if (aspect.aa().Level <= 9)
				{
					aspect.aa().Level += 5;
					ct7 ct = aspect.aa().Skills.Get<ct7>();
					ct.a(ct.f() + 45);
					dei dei = aspect.aa().Skills.Get<dei>();
					dei.a(dei.f() + 45);
				}
			}
			if (string.Equals(A_2, "jy2", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.m;
				aspect.aa().HostilityBroadcastMode = c2n.b;
			}
		}
	}
}
