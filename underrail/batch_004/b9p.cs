using System;
using System.Runtime.Serialization;

// Token: 0x02001AB1 RID: 6833
[eiz("CFEF")]
[Serializable]
public sealed class b9p : els, ISerializable
{
	// Token: 0x06009434 RID: 37940 RVA: 0x003A5864 File Offset: 0x003A3A64
	private b9p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009435 RID: 37941 RVA: 0x003A5870 File Offset: 0x003A3A70
	public b9p() : base(b9p.a, "Костёр", ci8.b)
	{
		base.Duration = d0u.b * 4;
		base.TickPeriod = d0u.b;
		base.Icon = "Misc.0";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new i0(b9p.c, true, false, false));
		base.StaticEffects.Add(new ba(b9p.b, true, false, false));
	}

	// Token: 0x06009436 RID: 37942 RVA: 0x003A58F0 File Offset: 0x003A3AF0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Campfire", new object[]
		{
			b9p.b,
			b9p.c
		});
	}

	// Token: 0x040038F8 RID: 14584
	public new static readonly string a = "campfire";

	// Token: 0x040038F9 RID: 14585
	public static readonly int b = 5;

	// Token: 0x040038FA RID: 14586
	public new static readonly float c = 0.2f;
}
