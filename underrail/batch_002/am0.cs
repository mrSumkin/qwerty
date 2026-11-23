using System;
using System.Runtime.Serialization;

// Token: 0x02001B1A RID: 6938
[eiz("M78")]
[Serializable]
public sealed class am0 : els, ISerializable
{
	// Token: 0x06009621 RID: 38433 RVA: 0x003AC8E4 File Offset: 0x003AAAE4
	private am0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009622 RID: 38434 RVA: 0x003AC8F0 File Offset: 0x003AAAF0
	public am0(int A_0) : base(am0.a, "Ментальное разложение", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Psi.MentalBreakdown";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "Incapacitated"));
		cly item = new cly((float)(-(float)be7.d))
		{
			Priority = int.MaxValue
		};
		ax2 item2 = new ax2();
		base.StaticEffects.Add(item);
		base.StaticEffects.Add(item2);
	}

	// Token: 0x06009623 RID: 38435 RVA: 0x003AC974 File Offset: 0x003AAB74
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/MentalBreakdown", new object[]
		{
			(int)(be7.d * 100.0)
		});
	}

	// Token: 0x040039C5 RID: 14789
	public new static readonly string a = "mentalBreakdown";
}
