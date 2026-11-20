using System;
using System.Runtime.Serialization;

// Token: 0x02001ADC RID: 6876
[eiz("TESE")]
[Serializable]
public sealed class d62 : els, ISerializable
{
	// Token: 0x06009502 RID: 38146 RVA: 0x003A8600 File Offset: 0x003A6800
	private d62(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009503 RID: 38147 RVA: 0x003A8610 File Offset: 0x003A6810
	public d62(int A_0) : base(d62.a, "Третий глаз", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.ThirdEye";
		base.ExpiredAction = "BlueExpirationAction";
		base.RemovedAction = "BlueExpirationAction";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new d0d((float)dfk.c));
	}

	// Token: 0x06009504 RID: 38148 RVA: 0x003A8674 File Offset: 0x003A6874
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ThirdEye", new object[]
		{
			(int)(dfk.c * 100.0),
			dfk.d
		});
	}

	// Token: 0x04003960 RID: 14688
	public new static readonly string a = "thirdEye";
}
