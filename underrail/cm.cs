using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012A4 RID: 4772
[eiz("EXP0")]
[Serializable]
public sealed class cm : Aspect<c5x>, ISerializable, cmm
{
	// Token: 0x0600685E RID: 26718 RVA: 0x002C2120 File Offset: 0x002C0320
	private cm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (TimeSpan)A_0.GetValue("EXP0:D", typeof(TimeSpan));
		if (ell.a() >= 677)
		{
			this.b = A_0.GetBoolean("EXP0:F");
			this.c = A_0.GetDouble("EXP0:R");
			this.d = (A_0.GetValue("EXP0:Q", typeof(TimeSpan?)) as TimeSpan?);
		}
	}

	// Token: 0x0600685F RID: 26719 RVA: 0x002C21BC File Offset: 0x002C03BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EXP0:D", this.a);
		info.AddValue("EXP0:F", this.b);
		info.AddValue("EXP0:R", this.c);
		info.AddValue("EXP0:Q", this.d);
	}

	// Token: 0x06006860 RID: 26720 RVA: 0x002C2220 File Offset: 0x002C0420
	public double a()
	{
		return this.c;
	}

	// Token: 0x06006861 RID: 26721 RVA: 0x002C2228 File Offset: 0x002C0428
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006862 RID: 26722 RVA: 0x002C2234 File Offset: 0x002C0434
	public cm(c5x A_0, TimeSpan A_1, bool A_2 = false) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06006863 RID: 26723 RVA: 0x002C225C File Offset: 0x002C045C
	public cm(c5x A_0, int A_1, bool A_2 = false) : base(A_0)
	{
		this.a(A_1);
		this.b = A_2;
	}

	// Token: 0x06006864 RID: 26724 RVA: 0x002C2284 File Offset: 0x002C0484
	public void c9(TimeSpan A_0)
	{
		this.a(TimeSpan.Zero);
	}

	// Token: 0x06006865 RID: 26725 RVA: 0x002C2294 File Offset: 0x002C0494
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006866 RID: 26726 RVA: 0x002C2298 File Offset: 0x002C0498
	public void r7(eds A_0)
	{
		this.a(A_0.a);
	}

	// Token: 0x06006867 RID: 26727 RVA: 0x002C22AC File Offset: 0x002C04AC
	public void a(int A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			this.a = serviceOrThrow.aqu().o() + TimeSpan.FromMilliseconds((double)A_0);
		}
	}

	// Token: 0x06006868 RID: 26728 RVA: 0x002C22E8 File Offset: 0x002C04E8
	private void a(TimeSpan A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().o() >= this.a && (this.d == null || this.d.Value + TimeSpan.FromSeconds(5.0) >= A_0))
		{
			this.d = new TimeSpan?(A_0);
			if (this.b)
			{
				c5x c5x = base.a8();
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | m7.b);
				ad6 ad = new ad6(c5x);
				ad.b((double)c5x.ae.GetValueOrDefault(1f));
				ad.c(0.0);
				ad.a(this.c / 1000.0);
				ad6 item = ad;
				awx.ad().Add(item);
				awx.ad().Add(new c7(base.a8(), false, false, false, false));
				base.a8().Zone.ActionManager.g9(awx, atp.a);
				return;
			}
			base.a8().Zone.ActionManager.g9(new c7(base.a8(), false, false, false, false), atp.a);
		}
	}

	// Token: 0x04002B1D RID: 11037
	private TimeSpan a;

	// Token: 0x04002B1E RID: 11038
	private bool b;

	// Token: 0x04002B1F RID: 11039
	private double c = 0.5;

	// Token: 0x04002B20 RID: 11040
	private TimeSpan? d;
}
