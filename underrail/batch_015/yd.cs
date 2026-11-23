using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020019E9 RID: 6633
[eiz("MMSCE")]
[Serializable]
public sealed class yd : d3e, d7s, ISerializable
{
	// Token: 0x06008EA6 RID: 36518 RVA: 0x00395E94 File Offset: 0x00394094
	private yd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MMSCE:A");
		this.b = A_0.GetInt32("MMSCE:P");
		this.c = A_0.GetBoolean("MMSCE:D");
		this.d = A_0.GetBoolean("MMSCE:N");
		this.e = A_0.GetBoolean("MMSCE:I");
	}

	// Token: 0x06008EA7 RID: 36519 RVA: 0x00395F00 File Offset: 0x00394100
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MMSCE:A", this.a);
		info.AddValue("MMSCE:P", this.b);
		info.AddValue("MMSCE:D", this.c);
		info.AddValue("MMSCE:N", this.d);
		info.AddValue("MMSCE:I", this.e);
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x06008EA8 RID: 36520 RVA: 0x00395F6C File Offset: 0x0039416C
	// (set) Token: 0x06008EA9 RID: 36521 RVA: 0x00395F74 File Offset: 0x00394174
	public float MovementSpeed
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

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06008EAA RID: 36522 RVA: 0x00395F80 File Offset: 0x00394180
	// (set) Token: 0x06008EAB RID: 36523 RVA: 0x00395F88 File Offset: 0x00394188
	public int MovementPoints
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

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06008EAC RID: 36524 RVA: 0x00395F94 File Offset: 0x00394194
	// (set) Token: 0x06008EAD RID: 36525 RVA: 0x00395F9C File Offset: 0x0039419C
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

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06008EAE RID: 36526 RVA: 0x00395FA8 File Offset: 0x003941A8
	// (set) Token: 0x06008EAF RID: 36527 RVA: 0x00395FB0 File Offset: 0x003941B0
	public bool NullifyPreviousBonuses
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

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06008EB0 RID: 36528 RVA: 0x00395FBC File Offset: 0x003941BC
	public override bool Negative
	{
		get
		{
			if (this.a == 0f)
			{
				return this.b < 0;
			}
			return this.a < 0f;
		}
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06008EB1 RID: 36529 RVA: 0x00395FE8 File Offset: 0x003941E8
	public bool IgnoreImmunity
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x06008EB2 RID: 36530 RVA: 0x00395FF0 File Offset: 0x003941F0
	public yd()
	{
	}

	// Token: 0x06008EB3 RID: 36531 RVA: 0x00395FF8 File Offset: 0x003941F8
	public yd(float A_0, int A_1, bool A_2 = false, bool A_3 = false, bool A_4 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x06008EB4 RID: 36532 RVA: 0x00396028 File Offset: 0x00394228
	protected override void @in(ll A_0)
	{
		if ((!this.c || !A_0.a().SpecialStates.g) && (this.e || this.a > 0f || !A_0.a().d(CharacterImmunities.Slow)))
		{
			if (this.d && A_0.a().MovementSpeed > A_0.a().BaseMovementSpeed)
			{
				A_0.a().MovementSpeed = A_0.a().BaseMovementSpeed;
			}
			if ((A_0.a().MovementSpeed += this.a) < aiy.e)
			{
				A_0.a().MovementSpeed = aiy.e;
			}
			A_0.a().Offense.c(this.b, false);
		}
	}

	// Token: 0x06008EB5 RID: 36533 RVA: 0x00396110 File Offset: 0x00394310
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		yd yd = (yd)A_0;
		yd.a = this.a;
		yd.b = this.b;
		yd.c = this.c;
		yd.d = this.d;
		yd.e = this.e;
	}

	// Token: 0x06008EB6 RID: 36534 RVA: 0x00396168 File Offset: 0x00394368
	public void cn(d3e A_0)
	{
		yd yd = A_0 as yd;
		if (yd != null)
		{
			this.a += yd.a;
			this.b += yd.b;
		}
	}

	// Token: 0x06008EB7 RID: 36535 RVA: 0x003961A8 File Offset: 0x003943A8
	public bool co(d3e A_0)
	{
		yd yd = A_0 as yd;
		return yd != null && yd.c == this.c && yd.d == this.d && yd.e == this.e;
	}

	// Token: 0x06008EB8 RID: 36536 RVA: 0x003961F4 File Offset: 0x003943F4
	public override string b2()
	{
		string text = "";
		string text2 = Convert.ToInt32(Math.Abs(this.a * 100f)).ToString() + "%";
		string text3 = Math.Abs(this.b).ToString();
		int num = Math.Sign(this.a);
		int num2 = Math.Sign(this.b);
		if (num == 0 && num2 == 0)
		{
			return qv.b("StaticEffects/ModifyMovementSpeedCombined_noSpeedChanges");
		}
		if (num != 0)
		{
			if (num >= 0)
			{
				text = qv.a("StaticEffects/ModifyMovementSpeedCombined_Speed_Increased", new object[]
				{
					text2
				});
			}
			else
			{
				text = qv.a("StaticEffects/ModifyMovementSpeedCombined_Speed_Decreased", new object[]
				{
					text2
				});
			}
			if (num2 != 0)
			{
				if (num2 == num)
				{
					text += qv.a("StaticEffects/ModifyMovementSpeedCombined_andMovementPoints", new object[]
					{
						text3
					});
				}
				else if (num2 > 0)
				{
					text += qv.a("StaticEffects/ModifyMovementSpeedCombined_ButMovementPoints_Increased", new object[]
					{
						text3
					});
				}
				else
				{
					text += qv.a("StaticEffects/ModifyMovementSpeedCombined_ButMovementPoints_Decreased", new object[]
					{
						text3
					});
				}
			}
		}
		else if (num2 != 0)
		{
			if (num2 > 0)
			{
				text = qv.a("StaticEffects/ModifyMovementSpeedCombined_MovementPoints_Increased", new object[]
				{
					text3
				});
			}
			else
			{
				text = qv.a("StaticEffects/ModifyMovementSpeedCombined_MovementPoints_Decreased", new object[]
				{
					text3
				});
			}
		}
		if (this.c)
		{
			text += qv.b("StaticEffects/ModifyMovementSpeedCombined_whenNotInStealth");
		}
		return text;
	}

	// Token: 0x06008EB9 RID: 36537 RVA: 0x00396388 File Offset: 0x00394588
	public override d3e b3()
	{
		yd yd = new yd();
		this.xx(yd);
		return yd;
	}

	// Token: 0x040037DC RID: 14300
	private new float a;

	// Token: 0x040037DD RID: 14301
	private int b;

	// Token: 0x040037DE RID: 14302
	private bool c;

	// Token: 0x040037DF RID: 14303
	private bool d;

	// Token: 0x040037E0 RID: 14304
	private bool e;
}
