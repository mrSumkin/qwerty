using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001AC4 RID: 6852
[eiz("SWTSE")]
[Serializable]
public sealed class cw0 : els, ISerializable
{
	// Token: 0x0600948F RID: 38031 RVA: 0x003A6AA0 File Offset: 0x003A4CA0
	private cw0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009490 RID: 38032 RVA: 0x003A6AAC File Offset: 0x003A4CAC
	public cw0(int A_0) : base(cw0.a, "Болотный транс", ci8.b)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.122";
		base.Stacking = axm.b;
		this.w = "SWTAJ";
		this.x = "SWTRJ";
		this.ab = "SWTAJ";
		this.y = "SWTRJ";
		this.aa = "SWTRJ";
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Perception.ToString(), cw0.c));
		base.StaticEffects.Add(new dpw("Stealth", -cw0.d)
		{
			Priority = int.MaxValue
		});
		base.DynamicEffects.Add(new a7i(cw0.b, 0f));
	}

	// Token: 0x06009491 RID: 38033 RVA: 0x003A6B8C File Offset: 0x003A4D8C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SwampTrance", new object[]
		{
			cw0.c,
			cw0.b
		});
	}

	// Token: 0x04003928 RID: 14632
	public new static readonly string a = "swampTrance";

	// Token: 0x04003929 RID: 14633
	public static readonly int b = 2;

	// Token: 0x0400392A RID: 14634
	public new static readonly int c = 2;

	// Token: 0x0400392B RID: 14635
	public new static readonly int d = 10000;
}
