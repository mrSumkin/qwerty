using System;
using System.Runtime.Serialization;

// Token: 0x02001AE8 RID: 6888
[eiz("TDSE")]
[Serializable]
public sealed class bha : els, ISerializable
{
	// Token: 0x06009537 RID: 38199 RVA: 0x003A920C File Offset: 0x003A740C
	private bha(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("TDSE:A", typeof(ap9)) as ap9);
		this.c = (a1q)A_0.GetValue("TDSE:M", typeof(a1q));
		this.d = (a1q)A_0.GetValue("TDSE:E", typeof(a1q));
		this.e = A_0.GetDouble("TDSE:X");
		this.f = A_0.GetBoolean("TDSE:J");
		if (ell.a() >= 398)
		{
			this.g = A_0.GetDouble("TDSE:C");
			return;
		}
		this.g = d3w.a;
	}

	// Token: 0x06009538 RID: 38200 RVA: 0x003A92E0 File Offset: 0x003A74E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TDSE:A", this.b);
		info.AddValue("TDSE:M", this.c);
		info.AddValue("TDSE:E", this.d);
		info.AddValue("TDSE:X", this.e);
		info.AddValue("TDSE:J", this.f);
		info.AddValue("TDSE:C", this.g);
	}

	// Token: 0x06009539 RID: 38201 RVA: 0x003A9368 File Offset: 0x003A7568
	public ap9 e()
	{
		return this.b;
	}

	// Token: 0x0600953A RID: 38202 RVA: 0x003A9370 File Offset: 0x003A7570
	public double b()
	{
		return this.e;
	}

	// Token: 0x0600953B RID: 38203 RVA: 0x003A9378 File Offset: 0x003A7578
	public void a(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600953C RID: 38204 RVA: 0x003A9384 File Offset: 0x003A7584
	public a1q a()
	{
		return this.c;
	}

	// Token: 0x0600953D RID: 38205 RVA: 0x003A938C File Offset: 0x003A758C
	public a1q c()
	{
		return this.d;
	}

	// Token: 0x0600953E RID: 38206 RVA: 0x003A9394 File Offset: 0x003A7594
	public bool f()
	{
		return this.f;
	}

	// Token: 0x0600953F RID: 38207 RVA: 0x003A939C File Offset: 0x003A759C
	public double d()
	{
		return this.g;
	}

	// Token: 0x06009540 RID: 38208 RVA: 0x003A93A8 File Offset: 0x003A75A8
	public bha(int A_0, ap9 A_1, a1q A_2, a1q A_3, double A_4, bool A_5 = false, double A_6 = 0.0) : base(bha.a, "Временное искажение", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.TemporalDistorsion";
		base.ExpiredAction = "TemporalDistorsionExpiresAction";
		base.VisualEffects.Add(new ud(this, "TemporalDistortion"));
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		this.b = A_1.b();
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
		this.f = A_5;
		this.g = A_6;
	}

	// Token: 0x06009541 RID: 38209 RVA: 0x003A9454 File Offset: 0x003A7654
	public override string cb(ll A_0)
	{
		a1q a1q = a1q.a(this.c, this.e);
		a1q a1q2 = a1q.a(this.d, this.e);
		return qv.a("StatusEffects/TemporalDistorsion", new object[]
		{
			a1q.a(true),
			a1q2.a(true),
			(int)(ed3.i * 100.0)
		});
	}

	// Token: 0x0400396E RID: 14702
	public new static readonly string a = "temporalDistorsion";

	// Token: 0x0400396F RID: 14703
	private ap9 b;

	// Token: 0x04003970 RID: 14704
	private new a1q c;

	// Token: 0x04003971 RID: 14705
	private new a1q d;

	// Token: 0x04003972 RID: 14706
	private new double e = 1.0;

	// Token: 0x04003973 RID: 14707
	private bool f;

	// Token: 0x04003974 RID: 14708
	private double g;
}
