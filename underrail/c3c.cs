using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001C1C RID: 7196
[d29("Burglar", "Burglar")]
public sealed class c3c : ai8
{
	// Token: 0x06009E09 RID: 40457 RVA: 0x003E1340 File Offset: 0x003DF540
	public c3c() : base("胔Медвежатник")
	{
	}

	// Token: 0x06009E0A RID: 40458 RVA: 0x003E1350 File Offset: 0x003DF550
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E0B RID: 40459 RVA: 0x003E1354 File Offset: 0x003DF554
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E0C RID: 40460 RVA: 0x003E1358 File Offset: 0x003DF558
	public override object[] at()
	{
		return new object[]
		{
			(int)(c3c.a * 100f),
			c3c.b
		};
	}

	// Token: 0x06009E0D RID: 40461 RVA: 0x003E1384 File Offset: 0x003DF584
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		dpw dpw = new dpw("Stealth", c3c.b + A_0.GetSpecializationValue<s7>(true) * s7.a);
		Type type = bpo.GetServiceOrThrow<ei2>().av3("ZSC", "X", false);
		if (type != null)
		{
			dpw.Condition = (Activator.CreateInstance(type, new object[]
			{
				ZoneControlLevel.Controlled
			}) as dth);
		}
		list.Add(dpw);
		return list;
	}

	// Token: 0x06009E0E RID: 40462 RVA: 0x003E1400 File Offset: 0x003DF600
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 6),
			new bap(15, new Type[]
			{
				typeof(dca),
				typeof(adx)
			})
		};
	}

	// Token: 0x04003D4B RID: 15691
	public new static readonly float a = 0.75f;

	// Token: 0x04003D4C RID: 15692
	public new static readonly int b = 10;
}
