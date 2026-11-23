using System;
using System.Runtime.Serialization;

// Token: 0x02001A0E RID: 6670
[eiz("M42")]
[Serializable]
public sealed class dcp : d3e, ISerializable
{
	// Token: 0x06009014 RID: 36884 RVA: 0x0039970C File Offset: 0x0039790C
	private dcp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M42:A");
	}

	// Token: 0x06009015 RID: 36885 RVA: 0x00399728 File Offset: 0x00397928
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M42:A", this.a);
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x06009016 RID: 36886 RVA: 0x00399744 File Offset: 0x00397944
	// (set) Token: 0x06009017 RID: 36887 RVA: 0x0039974C File Offset: 0x0039794C
	public double Modifier
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x06009018 RID: 36888 RVA: 0x00399758 File Offset: 0x00397958
	public override bool Negative
	{
		get
		{
			return this.a > 0.0;
		}
	}

	// Token: 0x06009019 RID: 36889 RVA: 0x0039976C File Offset: 0x0039796C
	public dcp()
	{
	}

	// Token: 0x0600901A RID: 36890 RVA: 0x00399774 File Offset: 0x00397974
	public dcp(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600901B RID: 36891 RVA: 0x00399784 File Offset: 0x00397984
	protected override void @in(ll A_0)
	{
		nw nw = A_0.a().Defense;
		nw.i(nw.l() + this.a);
	}

	// Token: 0x0600901C RID: 36892 RVA: 0x003997B0 File Offset: 0x003979B0
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dcp)A_0).a = this.a;
	}

	// Token: 0x0600901D RID: 36893 RVA: 0x003997CC File Offset: 0x003979CC
	public override string b2()
	{
		if (this.a > 0.0)
		{
			return qv.a("StaticEffects/ModifyExplosionDamageTaken_Increased", new object[]
			{
				(int)(this.a * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyExplosionDamageTaken_Decreased", new object[]
		{
			(int)(Math.Abs(this.a) * 100.0)
		});
	}

	// Token: 0x0600901E RID: 36894 RVA: 0x00399848 File Offset: 0x00397A48
	public override d3e b3()
	{
		dcp dcp = new dcp();
		this.xx(dcp);
		return dcp;
	}

	// Token: 0x04003802 RID: 14338
	public new double a;
}
