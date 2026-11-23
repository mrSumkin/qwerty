using System;
using System.Runtime.Serialization;

// Token: 0x02001B29 RID: 6953
[eiz("L10")]
[Serializable]
public sealed class f9 : els, ISerializable
{
	// Token: 0x06009662 RID: 38498 RVA: 0x003AD73C File Offset: 0x003AB93C
	private f9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009663 RID: 38499 RVA: 0x003AD748 File Offset: 0x003AB948
	public f9(int A_0) : base(f9.a, "Премедитация", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Premeditation";
	}

	// Token: 0x06009664 RID: 38500 RVA: 0x003AD770 File Offset: 0x003AB970
	public override string cb(ll A_0)
	{
		double num;
		if (A_0 != null && A_0.a() != null)
		{
			num = e9.a(new eoj(A_0.a(), null, null));
		}
		else
		{
			num = pv.d;
		}
		return qv.a("StatusEffects/Premeditation", new object[]
		{
			(int)(num * 100.0),
			(int)(pv.e * 100.0),
			pv.a
		});
	}

	// Token: 0x040039E1 RID: 14817
	public new static readonly string a = "premeditation";
}
