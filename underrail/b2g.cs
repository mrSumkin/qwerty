using System;
using System.Runtime.Serialization;

// Token: 0x02001A1E RID: 6686
[eiz("2AC")]
[Serializable]
public sealed class b2g : d3e, d7s, ISerializable
{
	// Token: 0x060090BD RID: 37053 RVA: 0x0039B524 File Offset: 0x00399724
	private b2g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("2AC:V");
	}

	// Token: 0x060090BE RID: 37054 RVA: 0x0039B540 File Offset: 0x00399740
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("2AC:V", this.a);
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x060090BF RID: 37055 RVA: 0x0039B55C File Offset: 0x0039975C
	// (set) Token: 0x060090C0 RID: 37056 RVA: 0x0039B564 File Offset: 0x00399764
	public double Value
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

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x060090C1 RID: 37057 RVA: 0x0039B570 File Offset: 0x00399770
	public override bool Negative
	{
		get
		{
			return this.a < 0.0;
		}
	}

	// Token: 0x060090C2 RID: 37058 RVA: 0x0039B588 File Offset: 0x00399788
	protected override void @in(ll A_0)
	{
		nw nw = A_0.a().Defense;
		nw.h(nw.aa() + this.a);
	}

	// Token: 0x060090C3 RID: 37059 RVA: 0x0039B5B4 File Offset: 0x003997B4
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((b2g)A_0).a = this.a;
	}

	// Token: 0x060090C4 RID: 37060 RVA: 0x0039B5D0 File Offset: 0x003997D0
	public void cn(d3e A_0)
	{
		b2g b2g = A_0 as b2g;
		if (b2g != null)
		{
			this.a += b2g.a;
		}
	}

	// Token: 0x060090C5 RID: 37061 RVA: 0x0039B600 File Offset: 0x00399800
	public bool co(d3e A_0)
	{
		return A_0 is b2g;
	}

	// Token: 0x060090C6 RID: 37062 RVA: 0x0039B60C File Offset: 0x0039980C
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return qv.a("StaticEffects/ModifyHealingEffectiveness_Decreased", new object[]
			{
				(int)Math.Abs(this.a * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyHealingEffectiveness_Increased", new object[]
		{
			(int)(this.a * 100.0)
		});
	}

	// Token: 0x060090C7 RID: 37063 RVA: 0x0039B688 File Offset: 0x00399888
	public override d3e b3()
	{
		b2g b2g = new b2g();
		this.xx(b2g);
		return b2g;
	}

	// Token: 0x060090C8 RID: 37064 RVA: 0x0039B6A4 File Offset: 0x003998A4
	public b2g()
	{
	}

	// Token: 0x060090C9 RID: 37065 RVA: 0x0039B6AC File Offset: 0x003998AC
	public b2g(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04003816 RID: 14358
	private new double a;
}
