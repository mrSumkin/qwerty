using System;
using System.Runtime.Serialization;

// Token: 0x02001AE3 RID: 6883
[eiz("PSG")]
[Serializable]
public sealed class doy : els, ISerializable
{
	// Token: 0x0600951F RID: 38175 RVA: 0x003A8C28 File Offset: 0x003A6E28
	private doy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009520 RID: 38176 RVA: 0x003A8C34 File Offset: 0x003A6E34
	public doy() : base(doy.a, "Сверхчувственное предвидение", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Psi.Precognition";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		this.z = "PrecognitionTick";
		base.DynamicEffects.Add(new aj9());
		base.VisualEffects.Add(new ud(this, "Precognition"));
	}

	// Token: 0x06009521 RID: 38177 RVA: 0x003A8CA8 File Offset: 0x003A6EA8
	public override string cb(ll A_0)
	{
		return qv.a("Psi/Precognition", new object[]
		{
			(A_0 != null) ? (a9y.a(A_0.a()) * 100.0) : 0.0,
			new a9y().a(new eoj(A_0.a(), null, null))
		});
	}

	// Token: 0x04003967 RID: 14695
	public new static readonly string a = "precognition";
}
