using System;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules;

// Token: 0x02000C7F RID: 3199
[eiz("MRBERDE")]
[Serializable]
public sealed class dp6 : cd2
{
	// Token: 0x06004841 RID: 18497 RVA: 0x001D9A98 File Offset: 0x001D7C98
	private dp6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004842 RID: 18498 RVA: 0x001D9AA4 File Offset: 0x001D7CA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004843 RID: 18499 RVA: 0x001D9AB0 File Offset: 0x001D7CB0
	public override TimeSpan ge()
	{
		return TimeSpan.FromSeconds(25.0);
	}

	// Token: 0x06004844 RID: 18500 RVA: 0x001D9AC0 File Offset: 0x001D7CC0
	public override TimeSpan gf()
	{
		return TimeSpan.FromSeconds(0.0);
	}

	// Token: 0x06004845 RID: 18501 RVA: 0x001D9AD0 File Offset: 0x001D7CD0
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004846 RID: 18502 RVA: 0x001D9AE0 File Offset: 0x001D7CE0
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004847 RID: 18503 RVA: 0x001D9AF0 File Offset: 0x001D7CF0
	public dp6() : base(dp6.a)
	{
	}

	// Token: 0x06004848 RID: 18504 RVA: 0x001D9B00 File Offset: 0x001D7D00
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0) && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_shipCleared", new bool?(false)).Value;
	}

	// Token: 0x06004849 RID: 18505 RVA: 0x001D9B44 File Offset: 0x001D7D44
	protected override void gg(cyt A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = 3;
			int value = 15;
			int num2 = 0;
			if (A_0.ae() >= GameDifficulty.Dominating)
			{
				num = 5;
				value = 20;
			}
			else if (A_0.ae() == GameDifficulty.Hard)
			{
				num = 4;
			}
			else if (A_0.ae() == GameDifficulty.Easy)
			{
				num = 2;
				value = 10;
			}
			foreach (csd csd in Enumerable.ToList<csd>(serviceOrThrow.aqw().Waypoints))
			{
				if (num <= 0)
				{
					break;
				}
				if (csd.Name.StartsWith("blackEelSpawn") && aw1.a(new bt4(csd.Name), A_0.v().b().Area, l9.b))
				{
					c5x c5x = new gx().a(csd, new int?(value), "Generic_Jetski", "Чёрный угорь", asp.gj, "", null, true, null, false);
					if (c5x != null)
					{
						num--;
						c5x.b("Despawn");
						if (c5x.h.b != null)
						{
							coh coh = new d48(ez2.CreateDefinitonProvider<x2>("oddities\\blackEelInsignia"));
							if (coh != null)
							{
								c5x.h.b.aa().Bag.z3(coh, true);
							}
						}
						if (c5x.t.b != null)
						{
							PropertyCollection propertyCollection = c5x.t.b.y6();
							string ay = ddq.ay;
							string str = "blackEelGuard";
							int num3;
							num2 = (num3 = num2 + 1);
							propertyCollection[ay] = new bt4(str + num3.ToString());
						}
					}
				}
			}
			A_0.r()["loc_cvw38_spawnedEelReinforcements"] = true;
		}
	}

	// Token: 0x04001CB1 RID: 7345
	public new static readonly string a = "merchantRaidReinforcements";
}
