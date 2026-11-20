using System;
using System.Runtime.Serialization;

// Token: 0x02001897 RID: 6295
[eiz("UEA5")]
[Serializable]
public sealed class a5 : btm, ISerializable
{
	// Token: 0x06008597 RID: 34199 RVA: 0x00376C08 File Offset: 0x00374E08
	private a5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ar7)A_0.GetValue("UEA5:S", typeof(ar7));
		this.b = (bhp)A_0.GetValue("UEA5:B", typeof(bhp));
		this.c = A_0.GetBoolean("UEA5:R");
		this.d = A_0.GetBoolean("UEA5:G");
		if (ell.a() >= 326)
		{
			this.e = A_0.GetBoolean("UEA5:MD");
		}
	}

	// Token: 0x06008598 RID: 34200 RVA: 0x00376CB4 File Offset: 0x00374EB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UEA5:S", this.a);
		info.AddValue("UEA5:B", this.b);
		info.AddValue("UEA5:R", this.c);
		info.AddValue("UEA5:G", this.d);
		info.AddValue("UEA5:MD", this.e);
	}

	// Token: 0x06008599 RID: 34201 RVA: 0x00376D20 File Offset: 0x00374F20
	public bhp a()
	{
		return this.b;
	}

	// Token: 0x0600859A RID: 34202 RVA: 0x00376D28 File Offset: 0x00374F28
	public void a(bhp A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600859B RID: 34203 RVA: 0x00376D34 File Offset: 0x00374F34
	public ar7 e()
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			return this.b.GetValue<ar7>(this);
		}
		return this.a;
	}

	// Token: 0x0600859C RID: 34204 RVA: 0x00376D70 File Offset: 0x00374F70
	public void a(ar7 A_0)
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			this.b.SetValue<ar7>(this, A_0);
		}
		this.a = A_0;
	}

	// Token: 0x0600859D RID: 34205 RVA: 0x00376DAC File Offset: 0x00374FAC
	public bool b()
	{
		return this.c;
	}

	// Token: 0x0600859E RID: 34206 RVA: 0x00376DB4 File Offset: 0x00374FB4
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600859F RID: 34207 RVA: 0x00376DC0 File Offset: 0x00374FC0
	public bool d()
	{
		return this.d;
	}

	// Token: 0x060085A0 RID: 34208 RVA: 0x00376DC8 File Offset: 0x00374FC8
	public void c(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060085A1 RID: 34209 RVA: 0x00376DD4 File Offset: 0x00374FD4
	public bool c()
	{
		return this.e;
	}

	// Token: 0x060085A2 RID: 34210 RVA: 0x00376DDC File Offset: 0x00374FDC
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060085A3 RID: 34211 RVA: 0x00376DE8 File Offset: 0x00374FE8
	public a5() : base(null)
	{
	}

	// Token: 0x060085A4 RID: 34212 RVA: 0x00376E08 File Offset: 0x00375008
	protected override bool b4(e6d A_0)
	{
		if (this.e() != null && this.e().ao() != null && this.e().ao().j == cgy.b)
		{
			aud a_ = this.e().ao().Area;
			if (this.c)
			{
				this.e().ao().w();
			}
			this.e().ao().an();
			if (this.d)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					dqv aspect = this.e().ao().GetAspect<dqv>();
					if (aspect != null)
					{
						if (this.e)
						{
							serviceOrThrow.aqu().b().a(aspect.a()).a(true);
						}
						serviceOrThrow.aru(aspect.a8(), a_);
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0400332A RID: 13098
	private ar7 a;

	// Token: 0x0400332B RID: 13099
	private bhp b = new bhp();

	// Token: 0x0400332C RID: 13100
	private bool c = true;

	// Token: 0x0400332D RID: 13101
	private new bool d;

	// Token: 0x0400332E RID: 13102
	private new bool e;
}
