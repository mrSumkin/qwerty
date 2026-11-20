using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A12 RID: 6674
[eiz("MRFX")]
[Serializable]
public sealed class ah : d3e, ISerializable
{
	// Token: 0x06009038 RID: 36920 RVA: 0x00399B38 File Offset: 0x00397D38
	private ah(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MDTM:V");
		this.b = (DamageType)A_0.GetValue("MDTM:DT", typeof(DamageType));
		this.c = A_0.GetBoolean("MDTM:R");
		this.d = A_0.GetBoolean("MDTM:T");
		if (ell.a() >= 416)
		{
			this.e = A_0.GetBoolean("MDTM:I");
		}
	}

	// Token: 0x06009039 RID: 36921 RVA: 0x00399BD0 File Offset: 0x00397DD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MDTM:V", this.a);
		info.AddValue("MDTM:DT", this.b);
		info.AddValue("MDTM:R", this.c);
		info.AddValue("MDTM:T", this.d);
		info.AddValue("MDTM:I", this.e);
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x0600903A RID: 36922 RVA: 0x00399C40 File Offset: 0x00397E40
	// (set) Token: 0x0600903B RID: 36923 RVA: 0x00399C48 File Offset: 0x00397E48
	public DamageType DamageType
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

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x0600903C RID: 36924 RVA: 0x00399C54 File Offset: 0x00397E54
	public override bool Negative
	{
		get
		{
			return this.a < 1.0;
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x0600903D RID: 36925 RVA: 0x00399C68 File Offset: 0x00397E68
	// (set) Token: 0x0600903E RID: 36926 RVA: 0x00399C70 File Offset: 0x00397E70
	public bool ModifyResistance
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

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x0600903F RID: 36927 RVA: 0x00399C7C File Offset: 0x00397E7C
	// (set) Token: 0x06009040 RID: 36928 RVA: 0x00399C84 File Offset: 0x00397E84
	public bool ModifyThreshold
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06009041 RID: 36929 RVA: 0x00399C90 File Offset: 0x00397E90
	// (set) Token: 0x06009042 RID: 36930 RVA: 0x00399C98 File Offset: 0x00397E98
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

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06009043 RID: 36931 RVA: 0x00399CA4 File Offset: 0x00397EA4
	// (set) Token: 0x06009044 RID: 36932 RVA: 0x00399CAC File Offset: 0x00397EAC
	public bool BreakImmunities
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x06009045 RID: 36933 RVA: 0x00399CB8 File Offset: 0x00397EB8
	public ah()
	{
	}

	// Token: 0x06009046 RID: 36934 RVA: 0x00399CD0 File Offset: 0x00397ED0
	public ah(DamageType A_0, double A_1, bool A_2 = true, bool A_3 = true, bool A_4 = false)
	{
		this.b = A_0;
		this.a = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x06009047 RID: 36935 RVA: 0x00399D0C File Offset: 0x00397F0C
	public override string b2()
	{
		if (!this.c && !this.d)
		{
			return string.Empty;
		}
		string text = dh9.a(this.b).ToLowerInvariant();
		if (this.c && this.d)
		{
			if (this.a >= 1.0)
			{
				return qv.a("StaticEffects/ModifyResistances_ResistanceThreshold_Increased", new object[]
				{
					text,
					Convert.ToInt32((this.a - 1.0) * 100.0)
				});
			}
			return qv.a("StaticEffects/ModifyResistances_ResistanceThreshold_Decreased", new object[]
			{
				text,
				Convert.ToInt32((1.0 - this.a) * 100.0)
			});
		}
		else if (this.c)
		{
			if (this.a >= 1.0)
			{
				return qv.a("StaticEffects/ModifyResistances_Resistance_Increased", new object[]
				{
					text,
					Convert.ToInt32((this.a - 1.0) * 100.0)
				});
			}
			return qv.a("StaticEffects/ModifyResistances_Resistance_Decreased", new object[]
			{
				text,
				Convert.ToInt32((1.0 - this.a) * 100.0)
			});
		}
		else
		{
			if (this.a >= 1.0)
			{
				return qv.a("StaticEffects/ModifyResistances_Threshold_Increased", new object[]
				{
					text,
					Convert.ToInt32((this.a - 1.0) * 100.0)
				});
			}
			return qv.a("StaticEffects/ModifyResistances_Threshold_Decreased", new object[]
			{
				text,
				Convert.ToInt32((1.0 - this.a) * 100.0)
			});
		}
	}

	// Token: 0x06009048 RID: 36936 RVA: 0x00399F10 File Offset: 0x00398110
	public override d3e b3()
	{
		ah ah = new ah();
		this.xx(ah);
		return ah;
	}

	// Token: 0x06009049 RID: 36937 RVA: 0x00399F2C File Offset: 0x0039812C
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			if (this.c)
			{
				du2 du = A_0.a().Defense.af()[this.b];
				if (du.c() < 1.0 || this.a >= 1.0 || this.e)
				{
					A_0.a().Defense.af()[this.b] = new du2(this.b, du.a(), du.c() * this.a);
				}
			}
			if (this.d)
			{
				du2 du2 = A_0.a().Defense.af()[this.b];
				A_0.a().Defense.af()[this.b] = new du2(this.b, (int)((double)du2.a() * this.a), du2.c());
			}
		}
	}

	// Token: 0x0600904A RID: 36938 RVA: 0x0039A044 File Offset: 0x00398244
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		ah ah = (ah)A_0;
		ah.b = this.b;
		ah.c = this.c;
		ah.d = this.d;
		ah.a = this.a;
		ah.e = this.e;
	}

	// Token: 0x04003804 RID: 14340
	private new double a;

	// Token: 0x04003805 RID: 14341
	private DamageType b;

	// Token: 0x04003806 RID: 14342
	private bool c = true;

	// Token: 0x04003807 RID: 14343
	private bool d = true;

	// Token: 0x04003808 RID: 14344
	private bool e;
}
