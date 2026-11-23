using System;
using System.Runtime.Serialization;

// Token: 0x0200196B RID: 6507
[eiz("RV1")]
[Serializable]
public sealed class cq : wq, ISerializable
{
	// Token: 0x06008B4C RID: 35660 RVA: 0x0038EFC8 File Offset: 0x0038D1C8
	private cq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("RV1:C");
		this.c = A_0.GetInt32("RV1:H");
	}

	// Token: 0x06008B4D RID: 35661 RVA: 0x0038EFF4 File Offset: 0x0038D1F4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RV1:C", this.b);
		info.AddValue("RV1:H", this.c);
	}

	// Token: 0x06008B4E RID: 35662 RVA: 0x0038F020 File Offset: 0x0038D220
	public cq()
	{
	}

	// Token: 0x06008B4F RID: 35663 RVA: 0x0038F028 File Offset: 0x0038D228
	public cq(int A_0, double A_1)
	{
		this.c = A_0;
		this.b = A_1;
	}

	// Token: 0x06008B50 RID: 35664 RVA: 0x0038F040 File Offset: 0x0038D240
	public override void dk(ll A_0, int A_1)
	{
		this.dl(A_0, A_1);
	}

	// Token: 0x06008B51 RID: 35665 RVA: 0x0038F04C File Offset: 0x0038D24C
	public override void dl(ll A_0, int A_1)
	{
		if (A_0 != null && A_0.a() != null && !A_0.a().Dead && !A_0.a().SpecialStates.h && (double)(A_0.a().Defense.q().zo() / Math.Max(1f, A_0.a().Defense.q().zm())) < 0.7 && A_0.a().Gear.l().Item != null && A_0.a().Gear.l().Item.Battery >= this.b)
		{
			A_0.a().Gear.l().Item.Battery -= this.b;
			A_0.a().Defense.a(this.c, null, A_0.a().Gear.l().Item, true, false, false, null);
		}
	}

	// Token: 0x06008B52 RID: 35666 RVA: 0x0038F174 File Offset: 0x0038D374
	public override string dm()
	{
		return qv.a("DynamicEffects/RegenerativeVest", new object[]
		{
			this.c,
			this.b,
			70
		});
	}

	// Token: 0x06008B53 RID: 35667 RVA: 0x0038F1B0 File Offset: 0x0038D3B0
	public override wq dn()
	{
		cq cq = new cq();
		this.@do(cq);
		return cq;
	}

	// Token: 0x06008B54 RID: 35668 RVA: 0x0038F1CC File Offset: 0x0038D3CC
	protected override void @do(wq A_0)
	{
		base.@do(A_0);
		cq cq = (cq)A_0;
		cq.b = this.b;
		cq.c = this.c;
	}

	// Token: 0x04003791 RID: 14225
	private const double a = 0.7;

	// Token: 0x04003792 RID: 14226
	private double b;

	// Token: 0x04003793 RID: 14227
	private int c;
}
