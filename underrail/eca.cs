using System;
using System.Runtime.Serialization;

// Token: 0x020019FB RID: 6651
[eiz("M59")]
[Serializable]
public sealed class eca : d3e, ISerializable
{
	// Token: 0x06008F63 RID: 36707 RVA: 0x00397A7C File Offset: 0x00395C7C
	private eca(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M59:A");
	}

	// Token: 0x06008F64 RID: 36708 RVA: 0x00397A98 File Offset: 0x00395C98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M59:A", this.a);
	}

	// Token: 0x06008F65 RID: 36709 RVA: 0x00397AB4 File Offset: 0x00395CB4
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008F66 RID: 36710 RVA: 0x00397ABC File Offset: 0x00395CBC
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F67 RID: 36711 RVA: 0x00397AC8 File Offset: 0x00395CC8
	public override bool ae5()
	{
		return this.a > 0.0;
	}

	// Token: 0x06008F68 RID: 36712 RVA: 0x00397ADC File Offset: 0x00395CDC
	public eca()
	{
	}

	// Token: 0x06008F69 RID: 36713 RVA: 0x00397AE4 File Offset: 0x00395CE4
	public eca(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F6A RID: 36714 RVA: 0x00397AF4 File Offset: 0x00395CF4
	protected override void @in(ll A_0)
	{
		dcu dcu = A_0.a().Offense;
		dcu.b(dcu.ad() + this.a);
	}

	// Token: 0x06008F6B RID: 36715 RVA: 0x00397B20 File Offset: 0x00395D20
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((eca)A_0).a = this.a;
	}

	// Token: 0x06008F6C RID: 36716 RVA: 0x00397B3C File Offset: 0x00395D3C
	public override string b2()
	{
		if (this.a >= 0.0)
		{
			return qv.a("StaticEffects/ModifyShotgunReloadingSpeed_Increased", new object[]
			{
				(int)(this.a * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyShotgunReloadingSpeed_Decreased", new object[]
		{
			(int)(Math.Abs(this.a) * 100.0)
		});
	}

	// Token: 0x06008F6D RID: 36717 RVA: 0x00397BB8 File Offset: 0x00395DB8
	public override d3e b3()
	{
		eca eca = new eca();
		this.xx(eca);
		return eca;
	}

	// Token: 0x040037F1 RID: 14321
	public new double a;
}
