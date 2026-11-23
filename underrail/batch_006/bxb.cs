using System;
using System.Runtime.Serialization;

// Token: 0x02001A56 RID: 6742
[eiz("MSPE1")]
[Serializable]
public sealed class bxb : dh6, em0, ISerializable
{
	// Token: 0x0600925B RID: 37467 RVA: 0x0039F2F8 File Offset: 0x0039D4F8
	private bxb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("MSPE1:SN");
			this.b = A_0.GetBoolean("MSPE1:ATMV");
			return;
		}
		if (base.GetType() == typeof(bxb))
		{
			this.a = A_0.GetString("_SkillName");
			this.b = A_0.GetBoolean("_ApplyToModifiedValue");
			return;
		}
		this.a = A_0.GetString("ModifySkillPercentageEffect+_SkillName");
		this.b = A_0.GetBoolean("ModifySkillPercentageEffect+_ApplyToModifiedValue");
	}

	// Token: 0x0600925C RID: 37468 RVA: 0x0039F39C File Offset: 0x0039D59C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSPE1:SN", this.a);
		info.AddValue("MSPE1:ATMV", this.b);
	}

	// Token: 0x0600925D RID: 37469 RVA: 0x0039F3C8 File Offset: 0x0039D5C8
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600925E RID: 37470 RVA: 0x0039F3D0 File Offset: 0x0039D5D0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600925F RID: 37471 RVA: 0x0039F3DC File Offset: 0x0039D5DC
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06009260 RID: 37472 RVA: 0x0039F3E4 File Offset: 0x0039D5E4
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009261 RID: 37473 RVA: 0x0039F3F0 File Offset: 0x0039D5F0
	public bxb()
	{
	}

	// Token: 0x06009262 RID: 37474 RVA: 0x0039F3F8 File Offset: 0x0039D5F8
	public bxb(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009263 RID: 37475 RVA: 0x0039F408 File Offset: 0x0039D608
	public bxb(string A_0, float A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06009264 RID: 37476 RVA: 0x0039F41C File Offset: 0x0039D61C
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && !string.IsNullOrWhiteSpace(this.a))
		{
			csn csn = A_0.a().Skills.a(this.a);
			if (csn != null)
			{
				if (this.b)
				{
					csn csn2 = csn;
					csn2.b(csn2.g() + (int)((float)csn.g() * base.c()));
				}
				else
				{
					csn csn3 = csn;
					csn3.b(csn3.g() + (int)((float)csn.f() * base.c()));
				}
				csn.a();
			}
		}
	}

	// Token: 0x06009265 RID: 37477 RVA: 0x0039F4BC File Offset: 0x0039D6BC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		bxb bxb = (bxb)A_0;
		bxb.b = this.b;
		bxb.a = this.a;
	}

	// Token: 0x06009266 RID: 37478 RVA: 0x0039F4E4 File Offset: 0x0039D6E4
	public override string b2()
	{
		if (string.IsNullOrEmpty(dh9.a("SkillEnum." + this.a)))
		{
			string text = this.a;
		}
		if (this.b)
		{
			if (base.c() >= 0f)
			{
				return qv.a("StaticEffects/ModifySkillPercentage_Modified_Increased", new object[]
				{
					this.a,
					base.c() * 100f
				});
			}
			return qv.a("StaticEffects/ModifySkillPercentage_Modified_Decreased", new object[]
			{
				this.a,
				Math.Abs(base.c() * 100f)
			});
		}
		else
		{
			if (base.c() >= 0f)
			{
				return qv.a("StaticEffects/ModifySkillPercentage_Increased", new object[]
				{
					this.a,
					base.c() * 100f
				});
			}
			return qv.a("StaticEffects/ModifySkillPercentage_Decreased", new object[]
			{
				this.a,
				Math.Abs(base.c() * 100f)
			});
		}
	}

	// Token: 0x06009267 RID: 37479 RVA: 0x0039F604 File Offset: 0x0039D804
	public override d3e b3()
	{
		bxb bxb = new bxb();
		this.xx(bxb);
		return bxb;
	}

	// Token: 0x0400384C RID: 14412
	private new string a;

	// Token: 0x0400384D RID: 14413
	private bool b;
}
