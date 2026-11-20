using System;
using System.Runtime.Serialization;

// Token: 0x02001B08 RID: 6920
[eiz("FBSE")]
[Serializable]
public sealed class j3 : els, ISerializable
{
	// Token: 0x060095D4 RID: 38356 RVA: 0x003AB7D4 File Offset: 0x003A99D4
	private j3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095D5 RID: 38357 RVA: 0x003AB7E4 File Offset: 0x003A99E4
	public j3(int A_0) : base("focusBoost", "Сосредоточенность", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.48";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new dvq(j3.a, cs5.a));
		base.StaticEffects.Add(new bi0(null, (float)j3.a));
	}

	// Token: 0x060095D6 RID: 38358 RVA: 0x003AB850 File Offset: 0x003A9A50
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/FocusBoost", new object[]
		{
			(int)(j3.a * 100.0)
		});
	}

	// Token: 0x040039AB RID: 14763
	public new static readonly double a = 0.15;
}
