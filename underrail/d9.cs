using System;
using System.Runtime.Serialization;

// Token: 0x02001A34 RID: 6708
[eiz("MAPE")]
[Serializable]
public sealed class d9 : d3e, ISerializable
{
	// Token: 0x06009160 RID: 37216 RVA: 0x0039CC24 File Offset: 0x0039AE24
	private d9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MAPE:A");
		if (ell.a() >= 144)
		{
			this.b = A_0.GetBoolean("MAPE:P");
		}
		if (ell.a() >= 525)
		{
			this.c = A_0.GetBoolean("MAPE:DIS");
		}
	}

	// Token: 0x06009161 RID: 37217 RVA: 0x0039CC94 File Offset: 0x0039AE94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MAPE:A", this.a);
		info.AddValue("MAPE:P", this.b);
		info.AddValue("MAPE:DIS", this.c);
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x06009162 RID: 37218 RVA: 0x0039CCDC File Offset: 0x0039AEDC
	public override bool Negative
	{
		get
		{
			return this.a < 0;
		}
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06009163 RID: 37219 RVA: 0x0039CCE8 File Offset: 0x0039AEE8
	// (set) Token: 0x06009164 RID: 37220 RVA: 0x0039CCF0 File Offset: 0x0039AEF0
	public bool ApplyPenalties
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

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06009165 RID: 37221 RVA: 0x0039CCFC File Offset: 0x0039AEFC
	// (set) Token: 0x06009166 RID: 37222 RVA: 0x0039CD04 File Offset: 0x0039AF04
	public int Amount
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

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06009167 RID: 37223 RVA: 0x0039CD10 File Offset: 0x0039AF10
	// (set) Token: 0x06009168 RID: 37224 RVA: 0x0039CD18 File Offset: 0x0039AF18
	public bool DisableInStealth
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

	// Token: 0x06009169 RID: 37225 RVA: 0x0039CD24 File Offset: 0x0039AF24
	public d9()
	{
	}

	// Token: 0x0600916A RID: 37226 RVA: 0x0039CD34 File Offset: 0x0039AF34
	public d9(int A_0, bool A_1 = true, bool A_2 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0600916B RID: 37227 RVA: 0x0039CD5C File Offset: 0x0039AF5C
	public override d3e b3()
	{
		d9 d = new d9();
		this.xx(d);
		return d;
	}

	// Token: 0x0600916C RID: 37228 RVA: 0x0039CD78 File Offset: 0x0039AF78
	public override string b2()
	{
		string text = "";
		if (this.c)
		{
			text = " " + qv.b("StaticEffects/ModifyActionPoints_whenNotInStealth");
		}
		if (this.a >= 0)
		{
			return qv.a("StaticEffects/ModifyActionPoints_Positive", new object[]
			{
				this.a,
				text
			});
		}
		return qv.a("StaticEffects/ModifyActionPoints_Negative", new object[]
		{
			-this.a,
			text
		});
	}

	// Token: 0x0600916D RID: 37229 RVA: 0x0039CE00 File Offset: 0x0039B000
	protected override void @in(ll A_0)
	{
		if (!this.c || !A_0.a().SpecialStates.g)
		{
			A_0.a().Offense.a(this.a, this.b);
		}
	}

	// Token: 0x0600916E RID: 37230 RVA: 0x0039CE4C File Offset: 0x0039B04C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		d9 d = (d9)A_0;
		d.b = this.b;
		d.a = this.a;
		d.c = this.c;
	}

	// Token: 0x04003827 RID: 14375
	public new int a;

	// Token: 0x04003828 RID: 14376
	private bool b = true;

	// Token: 0x04003829 RID: 14377
	public bool c;
}
