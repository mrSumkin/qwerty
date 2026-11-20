using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A04 RID: 6660
[eiz("MDRE")]
[Serializable]
public sealed class cgv : d3e, d7s, ISerializable
{
	// Token: 0x06008FC3 RID: 36803 RVA: 0x00398960 File Offset: 0x00396B60
	private cgv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MDRE:V");
		this.c = (DamageType)A_0.GetValue("MDRE:DT", typeof(DamageType));
		if (ell.a() >= 632)
		{
			this.b = A_0.GetInt32("MDRE:T");
		}
	}

	// Token: 0x06008FC4 RID: 36804 RVA: 0x003989C8 File Offset: 0x00396BC8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MDRE:V", this.a);
		info.AddValue("MDRE:DT", this.c);
		info.AddValue("MDRE:T", this.b);
	}

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06008FC5 RID: 36805 RVA: 0x00398A18 File Offset: 0x00396C18
	// (set) Token: 0x06008FC6 RID: 36806 RVA: 0x00398A20 File Offset: 0x00396C20
	public double Resistance
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

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x06008FC7 RID: 36807 RVA: 0x00398A2C File Offset: 0x00396C2C
	// (set) Token: 0x06008FC8 RID: 36808 RVA: 0x00398A34 File Offset: 0x00396C34
	public int Threshold
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x00398A40 File Offset: 0x00396C40
	// (set) Token: 0x06008FCA RID: 36810 RVA: 0x00398A48 File Offset: 0x00396C48
	public DamageType DamageType
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x06008FCB RID: 36811 RVA: 0x00398A54 File Offset: 0x00396C54
	public override bool Negative
	{
		get
		{
			return this.a < 0.0 || this.b < 0;
		}
	}

	// Token: 0x06008FCC RID: 36812 RVA: 0x00398A78 File Offset: 0x00396C78
	public cgv()
	{
	}

	// Token: 0x06008FCD RID: 36813 RVA: 0x00398A80 File Offset: 0x00396C80
	public cgv(DamageType A_0, double A_1, int A_2 = 0)
	{
		this.c = A_0;
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06008FCE RID: 36814 RVA: 0x00398AA0 File Offset: 0x00396CA0
	public void cn(d3e A_0)
	{
		cgv cgv = A_0 as cgv;
		if (cgv != null)
		{
			this.a += cgv.a;
			this.b += cgv.b;
		}
	}

	// Token: 0x06008FCF RID: 36815 RVA: 0x00398AE0 File Offset: 0x00396CE0
	public bool co(d3e A_0)
	{
		cgv cgv = A_0 as cgv;
		return cgv != null && cgv.c == this.c;
	}

	// Token: 0x06008FD0 RID: 36816 RVA: 0x00398B0C File Offset: 0x00396D0C
	public override string b2()
	{
		string text = "";
		if (this.a < 0.0)
		{
			text += qv.a("StaticEffects/ModifyDamageResistance_Decreased", new object[]
			{
				dh9.a(this.c),
				(int)Math.Abs(this.a * 100.0)
			});
		}
		else if (this.a > 0.0)
		{
			text += qv.a("StaticEffects/ModifyDamageResistance_Increased", new object[]
			{
				dh9.a(this.c),
				(int)(this.a * 100.0)
			});
		}
		if (this.b < 0)
		{
			if (text != "")
			{
				text += " ";
			}
			text += qv.a("StaticEffects/ModifyDamageResistance_Threshold_Decreased", new object[]
			{
				Math.Abs(this.b)
			});
		}
		else if (this.b > 0)
		{
			if (text != "")
			{
				text += " ";
			}
			text += qv.a("StaticEffects/ModifyDamageResistance_Threshold_Increased", new object[]
			{
				this.b
			});
		}
		return text;
	}

	// Token: 0x06008FD1 RID: 36817 RVA: 0x00398C7C File Offset: 0x00396E7C
	public override d3e b3()
	{
		cgv cgv = new cgv();
		this.xx(cgv);
		return cgv;
	}

	// Token: 0x06008FD2 RID: 36818 RVA: 0x00398C98 File Offset: 0x00396E98
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			A_0.a().Defense.a(new du2(this.c, this.b, this.a));
		}
	}

	// Token: 0x06008FD3 RID: 36819 RVA: 0x00398CE0 File Offset: 0x00396EE0
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		cgv cgv = (cgv)A_0;
		cgv.c = this.c;
		cgv.a = this.a;
		cgv.b = this.b;
	}

	// Token: 0x040037FD RID: 14333
	private new double a;

	// Token: 0x040037FE RID: 14334
	private int b;

	// Token: 0x040037FF RID: 14335
	private DamageType c;
}
