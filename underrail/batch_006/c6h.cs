using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B1D RID: 6941
[eiz("XM")]
[Serializable]
public sealed class c6h : els, ISerializable
{
	// Token: 0x0600962E RID: 38446 RVA: 0x003ACAF8 File Offset: 0x003AACF8
	private c6h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600962F RID: 38447 RVA: 0x003ACB04 File Offset: 0x003AAD04
	public c6h(int A_0) : base(c6h.a, "Морфин", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.18";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.ExpiredAction = "MorphineExpiresAction";
		base.RemovedAction = "MorphineExpiresAction";
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType a_ = (DamageType)obj;
			base.StaticEffects.Add(new e3r(a_, -ja.b));
		}
	}

	// Token: 0x06009630 RID: 38448 RVA: 0x003ACBD4 File Offset: 0x003AADD4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/MorphineHypo", new object[]
		{
			(int)(ja.b * 100.0),
			(int)(ja.c * 100.0)
		});
	}

	// Token: 0x040039C9 RID: 14793
	public new static readonly string a = "morphine";
}
