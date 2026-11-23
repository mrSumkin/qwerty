using System;
using System.Runtime.Serialization;

// Token: 0x02001AEA RID: 6890
[eiz("SSSE")]
[Serializable]
public sealed class cwy : els, ISerializable
{
	// Token: 0x06009547 RID: 38215 RVA: 0x003A958C File Offset: 0x003A778C
	private cwy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009548 RID: 38216 RVA: 0x003A9598 File Offset: 0x003A7798
	public cwy(int A_0) : base(cwy.a, "Ясновидение", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.SecondSight";
		base.ExpiredAction = "BlueExpirationAction";
		base.RemovedAction = "BlueExpirationAction";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6("Perception", cwy.b));
	}

	// Token: 0x06009549 RID: 38217 RVA: 0x003A9600 File Offset: 0x003A7800
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SecondSight", new object[]
		{
			cwy.b
		});
	}

	// Token: 0x04003976 RID: 14710
	public new static readonly string a = "secondSight";

	// Token: 0x04003977 RID: 14711
	public static readonly int b = 1;
}
