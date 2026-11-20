using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A50 RID: 6736
[eiz("MMSE")]
[Serializable]
public sealed class i0 : d3e, d7s, ISerializable
{
	// Token: 0x0600922D RID: 37421 RVA: 0x0039EBF4 File Offset: 0x0039CDF4
	private i0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MMSE:A");
		this.b = A_0.GetBoolean("MMSE:DIS");
		this.c = A_0.GetBoolean("MMSE:N");
		if (ell.a() >= 469)
		{
			this.d = A_0.GetBoolean("MMSE:I");
		}
	}

	// Token: 0x0600922E RID: 37422 RVA: 0x0039EC5C File Offset: 0x0039CE5C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MMSE:A", this.a);
		info.AddValue("MMSE:DIS", this.b);
		info.AddValue("MMSE:N", this.c);
		info.AddValue("MMSE:I", this.d);
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x0600922F RID: 37423 RVA: 0x0039ECB8 File Offset: 0x0039CEB8
	// (set) Token: 0x06009230 RID: 37424 RVA: 0x0039ECC0 File Offset: 0x0039CEC0
	[XmlAttribute]
	public float Amount
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

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x06009231 RID: 37425 RVA: 0x0039ECCC File Offset: 0x0039CECC
	// (set) Token: 0x06009232 RID: 37426 RVA: 0x0039ECD4 File Offset: 0x0039CED4
	[XmlAttribute]
	public bool DisableInStealth
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

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x06009233 RID: 37427 RVA: 0x0039ECE0 File Offset: 0x0039CEE0
	// (set) Token: 0x06009234 RID: 37428 RVA: 0x0039ECE8 File Offset: 0x0039CEE8
	public bool NullifyPreviousBonuses
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

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x06009235 RID: 37429 RVA: 0x0039ECF4 File Offset: 0x0039CEF4
	public override bool Negative
	{
		get
		{
			return this.a < 0f;
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x06009236 RID: 37430 RVA: 0x0039ED04 File Offset: 0x0039CF04
	public bool IgnoreImmunity
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x06009237 RID: 37431 RVA: 0x0039ED0C File Offset: 0x0039CF0C
	public i0()
	{
	}

	// Token: 0x06009238 RID: 37432 RVA: 0x0039ED14 File Offset: 0x0039CF14
	public i0(float A_0, bool A_1 = false, bool A_2 = false, bool A_3 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x06009239 RID: 37433 RVA: 0x0039ED3C File Offset: 0x0039CF3C
	protected override void @in(ll A_0)
	{
		if ((!this.b || !A_0.a().SpecialStates.g) && (this.d || this.a > 0f || !A_0.a().d(CharacterImmunities.Slow)))
		{
			if (this.c && A_0.a().MovementSpeed > A_0.a().BaseMovementSpeed)
			{
				A_0.a().MovementSpeed = A_0.a().BaseMovementSpeed;
			}
			if ((A_0.a().MovementSpeed += this.a) < aiy.e)
			{
				A_0.a().MovementSpeed = aiy.e;
			}
		}
	}

	// Token: 0x0600923A RID: 37434 RVA: 0x0039EE0C File Offset: 0x0039D00C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		i0 i = (i0)A_0;
		i.a = this.a;
		i.b = this.b;
		i.c = this.c;
		i.d = this.d;
	}

	// Token: 0x0600923B RID: 37435 RVA: 0x0039EE50 File Offset: 0x0039D050
	public void cn(d3e A_0)
	{
		i0 i = A_0 as i0;
		if (i != null)
		{
			this.a += i.a;
		}
	}

	// Token: 0x0600923C RID: 37436 RVA: 0x0039EE80 File Offset: 0x0039D080
	public bool co(d3e A_0)
	{
		i0 i = A_0 as i0;
		return i != null && i.b == this.b && i.c == this.c && i.d == this.d;
	}

	// Token: 0x0600923D RID: 37437 RVA: 0x0039EECC File Offset: 0x0039D0CC
	public override string b2()
	{
		string text;
		if (this.a >= 0f)
		{
			text = qv.a("StaticEffects/ModifyMovementSpeed_Increased", new object[]
			{
				Convert.ToInt32(this.a * 100f)
			});
		}
		else
		{
			text = qv.a("StaticEffects/ModifyMovementSpeed_Decreased", new object[]
			{
				-Convert.ToInt32(this.a * 100f)
			});
		}
		if (this.b)
		{
			text += qv.b("StaticEffects/ModifyMovementSpeed_whenNotInStealth");
		}
		return text;
	}

	// Token: 0x0600923E RID: 37438 RVA: 0x0039EF60 File Offset: 0x0039D160
	public override d3e b3()
	{
		i0 i = new i0();
		this.xx(i);
		return i;
	}

	// Token: 0x04003847 RID: 14407
	private new float a;

	// Token: 0x04003848 RID: 14408
	private bool b;

	// Token: 0x04003849 RID: 14409
	private bool c;

	// Token: 0x0400384A RID: 14410
	private bool d;
}
