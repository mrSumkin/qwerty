using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A41 RID: 6721
[eiz("MDTM")]
[Serializable]
public sealed class e3r : d3e, d7s, ISerializable
{
	// Token: 0x060091CC RID: 37324 RVA: 0x0039DC10 File Offset: 0x0039BE10
	private e3r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MDTM:V");
		this.b = (DamageType)A_0.GetValue("MDTM:DT", typeof(DamageType));
	}

	// Token: 0x060091CD RID: 37325 RVA: 0x0039DC58 File Offset: 0x0039BE58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MDTM:V", this.a);
		info.AddValue("MDTM:DT", this.b);
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x060091CE RID: 37326 RVA: 0x0039DC8C File Offset: 0x0039BE8C
	// (set) Token: 0x060091CF RID: 37327 RVA: 0x0039DC94 File Offset: 0x0039BE94
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

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x060091D0 RID: 37328 RVA: 0x0039DCA0 File Offset: 0x0039BEA0
	// (set) Token: 0x060091D1 RID: 37329 RVA: 0x0039DCA8 File Offset: 0x0039BEA8
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

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x060091D2 RID: 37330 RVA: 0x0039DCB4 File Offset: 0x0039BEB4
	public override bool Negative
	{
		get
		{
			return this.a > 0.0;
		}
	}

	// Token: 0x060091D3 RID: 37331 RVA: 0x0039DCC8 File Offset: 0x0039BEC8
	public e3r()
	{
	}

	// Token: 0x060091D4 RID: 37332 RVA: 0x0039DCD0 File Offset: 0x0039BED0
	public e3r(DamageType A_0, double A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x060091D5 RID: 37333 RVA: 0x0039DCE8 File Offset: 0x0039BEE8
	public void cn(d3e A_0)
	{
		e3r e3r = A_0 as e3r;
		if (e3r != null)
		{
			this.a += e3r.a;
		}
	}

	// Token: 0x060091D6 RID: 37334 RVA: 0x0039DD18 File Offset: 0x0039BF18
	public bool co(d3e A_0)
	{
		e3r e3r = A_0 as e3r;
		return e3r != null && e3r.b == this.b;
	}

	// Token: 0x060091D7 RID: 37335 RVA: 0x0039DD44 File Offset: 0x0039BF44
	public override string b2()
	{
		if (this.a < 0.0)
		{
			string a_ = "StaticEffects/ModifyDamageTakenModifier_Decreased";
			object[] array = new object[2];
			int num = 0;
			string text = dh9.a(this.b);
			array[num] = ((text != null) ? text.ToLowerInvariant() : null);
			array[1] = (int)Math.Abs(this.a * 100.0);
			return qv.a(a_, array);
		}
		string a_2 = "StaticEffects/ModifyDamageTakenModifier_Increased";
		object[] array2 = new object[2];
		int num2 = 0;
		string text2 = dh9.a(this.b);
		array2[num2] = ((text2 != null) ? text2.ToLowerInvariant() : null);
		array2[1] = (int)(this.a * 100.0);
		return qv.a(a_2, array2);
	}

	// Token: 0x060091D8 RID: 37336 RVA: 0x0039DE08 File Offset: 0x0039C008
	public override d3e b3()
	{
		e3r e3r = new e3r();
		this.xx(e3r);
		return e3r;
	}

	// Token: 0x060091D9 RID: 37337 RVA: 0x0039DE24 File Offset: 0x0039C024
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			A_0.a().Defense.a(this.b, this.a);
		}
	}

	// Token: 0x060091DA RID: 37338 RVA: 0x0039DE60 File Offset: 0x0039C060
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		e3r e3r = (e3r)A_0;
		e3r.b = this.b;
		e3r.a = this.a;
	}

	// Token: 0x0400383A RID: 14394
	private new double a;

	// Token: 0x0400383B RID: 14395
	private DamageType b;
}
