using System;
using TimelapseVertigo.Game.Fragments;

// Token: 0x02000BD4 RID: 3028
public sealed class dwk : jn
{
	// Token: 0x0600454C RID: 17740 RVA: 0x001C2B08 File Offset: 0x001C0D08
	public dwk() : base("dun_diedrick", "creature\\characters\\dun_diedrick")
	{
	}

	// Token: 0x0600454D RID: 17741 RVA: 0x001C2B1C File Offset: 0x001C0D1C
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
		if (A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_dun_llb4_ryl_alive", new bool?(false)).Value)
		{
			return "cc-res";
		}
		return "jy2";
	}

	// Token: 0x0600454E RID: 17742 RVA: 0x001C2C68 File Offset: 0x001C0E68
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
					fd fd = aspect.aa().Skills.Get<fd>();
					fd.a(fd.f() + 45);
					dql dql = aspect.aa().Skills.Get<dql>();
					dql.a(dql.f() + 45);
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
