using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A35 RID: 6709
[eiz("MMPE")]
[Serializable]
public sealed class ba : d3e, d7s, ISerializable
{
	// Token: 0x0600916F RID: 37231 RVA: 0x0039CE80 File Offset: 0x0039B080
	private ba(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MMPE:A");
		this.b = A_0.GetBoolean("MMPE:DIS");
		if (ell.a() >= 144)
		{
			this.c = A_0.GetBoolean("MMPE:P");
		}
		if (ell.a() >= 469)
		{
			this.d = A_0.GetBoolean("MMPE:I");
		}
	}

	// Token: 0x06009170 RID: 37232 RVA: 0x0039CF00 File Offset: 0x0039B100
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MMPE:A", this.a);
		info.AddValue("MMPE:DIS", this.b);
		info.AddValue("MMPE:P", this.c);
		info.AddValue("MMPE:I", this.d);
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x06009171 RID: 37233 RVA: 0x0039CF5C File Offset: 0x0039B15C
	public override bool Negative
	{
		get
		{
			return this.a < 0;
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x06009172 RID: 37234 RVA: 0x0039CF68 File Offset: 0x0039B168
	// (set) Token: 0x06009173 RID: 37235 RVA: 0x0039CF70 File Offset: 0x0039B170
	public bool ApplyPenalties
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

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06009174 RID: 37236 RVA: 0x0039CF7C File Offset: 0x0039B17C
	// (set) Token: 0x06009175 RID: 37237 RVA: 0x0039CF84 File Offset: 0x0039B184
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

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06009176 RID: 37238 RVA: 0x0039CF90 File Offset: 0x0039B190
	// (set) Token: 0x06009177 RID: 37239 RVA: 0x0039CF98 File Offset: 0x0039B198
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

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x06009178 RID: 37240 RVA: 0x0039CFA4 File Offset: 0x0039B1A4
	public bool IgnoreImmunity
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x06009179 RID: 37241 RVA: 0x0039CFAC File Offset: 0x0039B1AC
	public ba()
	{
	}

	// Token: 0x0600917A RID: 37242 RVA: 0x0039CFBC File Offset: 0x0039B1BC
	public ba(int A_0, bool A_1 = false, bool A_2 = true, bool A_3 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x0600917B RID: 37243 RVA: 0x0039CFEC File Offset: 0x0039B1EC
	protected override void @in(ll A_0)
	{
		if ((!this.b || !A_0.a().SpecialStates.g) && (this.d || this.a > 0 || !A_0.a().d(CharacterImmunities.Slow)))
		{
			A_0.a().Offense.c(this.a, this.c);
		}
	}

	// Token: 0x0600917C RID: 37244 RVA: 0x0039D064 File Offset: 0x0039B264
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		ba ba = (ba)A_0;
		ba.a = this.a;
		ba.c = this.c;
		ba.b = this.b;
		ba.d = this.d;
	}

	// Token: 0x0600917D RID: 37245 RVA: 0x0039D0A4 File Offset: 0x0039B2A4
	public void cn(d3e A_0)
	{
		ba ba = A_0 as ba;
		if (ba != null)
		{
			this.a += ba.a;
		}
	}

	// Token: 0x0600917E RID: 37246 RVA: 0x0039D0D4 File Offset: 0x0039B2D4
	public bool co(d3e A_0)
	{
		ba ba = A_0 as ba;
		return ba != null && ba.b == this.b && ba.c == this.c && ba.d == this.d;
	}

	// Token: 0x0600917F RID: 37247 RVA: 0x0039D120 File Offset: 0x0039B320
	public override string b2()
	{
		string text = "";
		if (this.b)
		{
			text = " " + qv.b("StaticEffects/ModifyMovementPoints_whenNotInStealth");
		}
		if (this.a >= 0)
		{
			return qv.a("StaticEffects/ModifyMovementPoints_Increased", new object[]
			{
				this.a,
				text
			});
		}
		return qv.a("StaticEffects/ModifyMovementPoints_Decreased", new object[]
		{
			-this.a,
			text
		});
	}

	// Token: 0x06009180 RID: 37248 RVA: 0x0039D1A8 File Offset: 0x0039B3A8
	public override d3e b3()
	{
		ba ba = new ba();
		this.xx(ba);
		return ba;
	}

	// Token: 0x0400382A RID: 14378
	public new int a;

	// Token: 0x0400382B RID: 14379
	public bool b;

	// Token: 0x0400382C RID: 14380
	private bool c = true;

	// Token: 0x0400382D RID: 14381
	private bool d;
}
