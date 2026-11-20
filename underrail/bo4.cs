using System;
using System.Runtime.Serialization;

// Token: 0x02001AFE RID: 6910
[eiz("IMB")]
[Serializable]
public sealed class bo4 : els, ISerializable
{
	// Token: 0x060095A8 RID: 38312 RVA: 0x003AADC0 File Offset: 0x003A8FC0
	private bo4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095A9 RID: 38313 RVA: 0x003AADCC File Offset: 0x003A8FCC
	public bo4(int A_0) : base(bo4.a, "Обездвиженность", ci8.c)
	{
		base.Icon = "Status.Immobilized";
		base.VisualEffects.Add(new ud(this, "Immobilized"));
		base.Duration = A_0;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x060095AA RID: 38314 RVA: 0x003AAE24 File Offset: 0x003A9024
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Immobilized");
	}

	// Token: 0x0400399C RID: 14748
	public new static readonly string a = "immobilized";
}
