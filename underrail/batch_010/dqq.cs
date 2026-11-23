using System;
using System.Runtime.Serialization;

// Token: 0x02001ACE RID: 6862
[eiz("ONSE")]
[Serializable]
public sealed class dqq : els, ISerializable
{
	// Token: 0x060094C4 RID: 38084 RVA: 0x003A7958 File Offset: 0x003A5B58
	private dqq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094C5 RID: 38085 RVA: 0x003A7964 File Offset: 0x003A5B64
	public dqq() : this(dqq.c)
	{
	}

	// Token: 0x060094C6 RID: 38086 RVA: 0x003A7974 File Offset: 0x003A5B74
	public dqq(int A_0) : base("onslaught", "Натиск", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "xpbl_Abilities.5";
		base.MaxStacks = dqq.a;
		base.Stacking = axm.b;
	}

	// Token: 0x060094C7 RID: 38087 RVA: 0x003A79B8 File Offset: 0x003A5BB8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Onslaught", new object[]
		{
			Math.Round(this.a((A_0 != null) ? A_0.a() : null) * 100.0, 1)
		});
	}

	// Token: 0x060094C8 RID: 38088 RVA: 0x003A7A08 File Offset: 0x003A5C08
	public double a(efk A_0)
	{
		double num = dqq.b;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<dur>(true) * dur.a;
		}
		return num * (double)base.Stacks;
	}

	// Token: 0x0400394D RID: 14669
	public new static readonly int a = 20;

	// Token: 0x0400394E RID: 14670
	public static readonly double b = 0.05;

	// Token: 0x0400394F RID: 14671
	public new static readonly int c = 2 * d0u.b;
}
