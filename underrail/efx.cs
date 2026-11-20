using System;
using System.Runtime.Serialization;

// Token: 0x02001A19 RID: 6681
[eiz("C68")]
[Serializable]
public sealed class efx : d91, ISerializable
{
	// Token: 0x06009089 RID: 37001 RVA: 0x0039A9F0 File Offset: 0x00398BF0
	private efx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (cs5)A_0.GetValue("C68:F", typeof(cs5));
	}

	// Token: 0x0600908A RID: 37002 RVA: 0x0039AA1C File Offset: 0x00398C1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C68:F", this.a);
	}

	// Token: 0x0600908B RID: 37003 RVA: 0x0039AA3C File Offset: 0x00398C3C
	public cs5 a()
	{
		return this.a;
	}

	// Token: 0x0600908C RID: 37004 RVA: 0x0039AA44 File Offset: 0x00398C44
	public void a(cs5 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600908D RID: 37005 RVA: 0x0039AA50 File Offset: 0x00398C50
	public efx()
	{
	}

	// Token: 0x0600908E RID: 37006 RVA: 0x0039AA58 File Offset: 0x00398C58
	public efx(double A_0, cs5 A_1 = cs5.a) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x0600908F RID: 37007 RVA: 0x0039AA6C File Offset: 0x00398C6C
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && euf.a(A_0.a().Offense.u(), this.a))
		{
			dcu dcu = A_0.a().Offense;
			dcu.e(dcu.an() + base.b());
		}
	}

	// Token: 0x06009090 RID: 37008 RVA: 0x0039AACC File Offset: 0x00398CCC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((efx)A_0).a = this.a;
	}

	// Token: 0x06009091 RID: 37009 RVA: 0x0039AAE8 File Offset: 0x00398CE8
	public override d3e b3()
	{
		efx efx = new efx();
		this.xx(efx);
		return efx;
	}

	// Token: 0x06009092 RID: 37010 RVA: 0x0039AB04 File Offset: 0x00398D04
	public override string b2()
	{
		string arg = bsr.b(this.a);
		if (base.b() >= 0.0)
		{
			return string.Format("Урон от специальных атак {0} увеличен на {1}% (это не влияет на неограниченные специальные атаки).", arg, Math.Round(base.b(), 2) * 100.0);
		}
		return string.Format("Урон от специальных атак {0} уменьшен на {1}% (это не влияет на неограниченные специальные атаки).", arg, Math.Abs(Math.Round(base.b(), 2)) * 100.0);
	}

	// Token: 0x04003811 RID: 14353
	private new cs5 a;
}
