using System;
using System.Runtime.Serialization;

// Token: 0x02001467 RID: 5223
[eiz("ACACA")]
[Serializable]
public sealed class dea : a6k, ISerializable
{
	// Token: 0x060075C1 RID: 30145 RVA: 0x0031D710 File Offset: 0x0031B910
	private dea(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dea);
		}
	}

	// Token: 0x060075C2 RID: 30146 RVA: 0x0031D73C File Offset: 0x0031B93C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060075C3 RID: 30147 RVA: 0x0031D748 File Offset: 0x0031B948
	public dea(ad5 A_0) : base(A_0)
	{
	}

	// Token: 0x060075C4 RID: 30148 RVA: 0x0031D754 File Offset: 0x0031B954
	public dea()
	{
	}

	// Token: 0x060075C5 RID: 30149 RVA: 0x0031D760 File Offset: 0x0031B960
	protected override dc4 dt()
	{
		cp.a(base.vg().q(), base.vg().e());
		base.vg().op();
		return dc4.c;
	}

	// Token: 0x060075C6 RID: 30150 RVA: 0x0031D794 File Offset: 0x0031B994
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		throw new NotImplementedException();
	}
}
