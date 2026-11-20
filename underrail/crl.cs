using System;
using System.Runtime.Serialization;

// Token: 0x020019F3 RID: 6643
[eiz("M43")]
[Serializable]
public sealed class crl : d3e, ISerializable
{
	// Token: 0x06008F09 RID: 36617 RVA: 0x00396FA0 File Offset: 0x003951A0
	private crl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M43:A");
	}

	// Token: 0x06008F0A RID: 36618 RVA: 0x00396FBC File Offset: 0x003951BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M43:A", this.a);
	}

	// Token: 0x06008F0B RID: 36619 RVA: 0x00396FD8 File Offset: 0x003951D8
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008F0C RID: 36620 RVA: 0x00396FE0 File Offset: 0x003951E0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F0D RID: 36621 RVA: 0x00396FEC File Offset: 0x003951EC
	public override bool ae5()
	{
		return this.a > 0.0;
	}

	// Token: 0x06008F0E RID: 36622 RVA: 0x00397000 File Offset: 0x00395200
	public crl()
	{
	}

	// Token: 0x06008F0F RID: 36623 RVA: 0x00397008 File Offset: 0x00395208
	public crl(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F10 RID: 36624 RVA: 0x00397018 File Offset: 0x00395218
	protected override void @in(ll A_0)
	{
		nw nw = A_0.a().Defense;
		nw.j(nw.o() + this.a);
	}

	// Token: 0x06008F11 RID: 36625 RVA: 0x00397044 File Offset: 0x00395244
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((crl)A_0).a = this.a;
	}

	// Token: 0x06008F12 RID: 36626 RVA: 0x00397060 File Offset: 0x00395260
	public override string b2()
	{
		if (this.a >= 0.0)
		{
			return qv.a("StaticEffects/ModifyPoisonDamageTaken_Increased", new object[]
			{
				Convert.ToInt32(this.a * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyPoisonDamageTaken_Decreased", new object[]
		{
			Convert.ToInt32(Math.Abs(this.a) * 100.0)
		});
	}

	// Token: 0x06008F13 RID: 36627 RVA: 0x003970E4 File Offset: 0x003952E4
	public override d3e b3()
	{
		crl crl = new crl();
		this.xx(crl);
		return crl;
	}

	// Token: 0x040037E8 RID: 14312
	public new double a;
}
