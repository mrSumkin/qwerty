using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020011E0 RID: 4576
[eiz("RTG")]
[Serializable]
public sealed class ddz : b79, ISerializable
{
	// Token: 0x06006232 RID: 25138 RVA: 0x002A8384 File Offset: 0x002A6584
	private ddz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() < 364)
		{
			base.b(A_0.GetValue("RTG:N", typeof(TimeSpan?)) as TimeSpan?);
			base.a((TimeSpan)A_0.GetValue("RTG:R", typeof(TimeSpan)));
		}
		this.a = (Point)A_0.GetValue("RTG:S", typeof(Point));
		this.b = (Point)A_0.GetValue("RTG:D", typeof(Point));
		this.c = A_0.GetInt32("RTG:E");
	}

	// Token: 0x06006233 RID: 25139 RVA: 0x002A8440 File Offset: 0x002A6640
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RTG:S", this.a);
		info.AddValue("RTG:D", this.b);
		info.AddValue("RTG:E", this.c);
	}

	// Token: 0x06006234 RID: 25140 RVA: 0x002A8494 File Offset: 0x002A6694
	public Point b()
	{
		return this.a;
	}

	// Token: 0x06006235 RID: 25141 RVA: 0x002A849C File Offset: 0x002A669C
	public void a(Point A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006236 RID: 25142 RVA: 0x002A84A8 File Offset: 0x002A66A8
	public Point a()
	{
		return this.b;
	}

	// Token: 0x06006237 RID: 25143 RVA: 0x002A84B0 File Offset: 0x002A66B0
	public void b(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006238 RID: 25144 RVA: 0x002A84BC File Offset: 0x002A66BC
	public int c()
	{
		return this.c;
	}

	// Token: 0x06006239 RID: 25145 RVA: 0x002A84C4 File Offset: 0x002A66C4
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600623A RID: 25146 RVA: 0x002A84D0 File Offset: 0x002A66D0
	public ddz()
	{
	}

	// Token: 0x0600623B RID: 25147 RVA: 0x002A84D8 File Offset: 0x002A66D8
	protected override void li()
	{
		dt3.a(base.Area, this.a, this.b, this.c);
	}

	// Token: 0x040029A0 RID: 10656
	private Point a;

	// Token: 0x040029A1 RID: 10657
	private Point b;

	// Token: 0x040029A2 RID: 10658
	private int c;
}
