using System;
using System.Runtime.Serialization;

// Token: 0x02001B19 RID: 6937
[eiz("TSE")]
[Serializable]
public sealed class dt9 : els, ISerializable
{
	// Token: 0x0600961D RID: 38429 RVA: 0x003AC80C File Offset: 0x003AAA0C
	private dt9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600961E RID: 38430 RVA: 0x003AC818 File Offset: 0x003AAA18
	public dt9(efk A_0, int A_1, bool A_2 = false, string A_3 = null) : base(dt9.a, "Капкан", ci8.c)
	{
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Explosives.90";
		if (!string.IsNullOrEmpty(A_3))
		{
			base.VisualEffects.Add(new ud(this, A_3));
		}
		else if (A_2)
		{
			base.VisualEffects.Add(new ud(this, "PoisonedBearTrap"));
		}
		else
		{
			base.VisualEffects.Add(new ud(this, "BearTrap"));
		}
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x0600961F RID: 38431 RVA: 0x003AC8CC File Offset: 0x003AAACC
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Trapped");
	}

	// Token: 0x040039C4 RID: 14788
	public new static readonly string a = "trapped";
}
