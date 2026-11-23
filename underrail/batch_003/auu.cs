using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A7B RID: 6779
[eiz("XM4")]
[Serializable]
public sealed class auu : els, ISerializable
{
	// Token: 0x06009337 RID: 37687 RVA: 0x003A18FC File Offset: 0x0039FAFC
	private auu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009338 RID: 37688 RVA: 0x003A1908 File Offset: 0x0039FB08
	public auu(int A_0) : base(auu.a, "Нервосомнифер", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.116";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.ExpiredAction = "MorphineExpiresAction";
		base.RemovedAction = "MorphineExpiresAction";
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType a_ = (DamageType)obj;
			base.StaticEffects.Add(new e3r(a_, -bfr.b));
		}
	}

	// Token: 0x06009339 RID: 37689 RVA: 0x003A19D8 File Offset: 0x0039FBD8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Nervosomnifer", new object[]
		{
			Convert.ToInt32(bfr.b * 100.0),
			Convert.ToInt32(bfr.c * 100.0)
		});
	}

	// Token: 0x04003880 RID: 14464
	public new static readonly string a = "nervosomnifer";
}
