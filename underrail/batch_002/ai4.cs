using System;
using System.Runtime.Serialization;

// Token: 0x0200137F RID: 4991
[eiz("CROHEA")]
[bs6("HFX:carriedObjHit")]
[Serializable]
public sealed class ai4 : cpl, ISerializable
{
	// Token: 0x06007105 RID: 28933 RVA: 0x002F7568 File Offset: 0x002F5768
	private ai4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007106 RID: 28934 RVA: 0x002F7574 File Offset: 0x002F5774
	public ai4()
	{
	}

	// Token: 0x06007107 RID: 28935 RVA: 0x002F7580 File Offset: 0x002F5780
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		lh lh = ckw.a(base.a().a8());
		if (lh != null)
		{
			lh.qr(base.a(), base.b(), base.agw(), base.agy());
		}
		return dc4.c;
	}
}
