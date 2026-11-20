using System;
using System.Runtime.Serialization;

// Token: 0x02001A21 RID: 6689
[eiz("C22")]
[Serializable]
public sealed class dvq : d91, d7s, ISerializable
{
	// Token: 0x060090D7 RID: 37079 RVA: 0x0039B90C File Offset: 0x00399B0C
	private dvq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 165)
		{
			this.a = (cs5)A_0.GetValue("C22:F", typeof(cs5));
		}
	}

	// Token: 0x060090D8 RID: 37080 RVA: 0x0039B948 File Offset: 0x00399B48
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C22:F", this.a);
	}

	// Token: 0x060090D9 RID: 37081 RVA: 0x0039B968 File Offset: 0x00399B68
	public cs5 a()
	{
		return this.a;
	}

	// Token: 0x060090DA RID: 37082 RVA: 0x0039B970 File Offset: 0x00399B70
	public void a(cs5 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060090DB RID: 37083 RVA: 0x0039B97C File Offset: 0x00399B7C
	public dvq()
	{
	}

	// Token: 0x060090DC RID: 37084 RVA: 0x0039B984 File Offset: 0x00399B84
	public dvq(double A_0, cs5 A_1 = cs5.a) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x060090DD RID: 37085 RVA: 0x0039B994 File Offset: 0x00399B94
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dvq)A_0).a = this.a;
	}

	// Token: 0x060090DE RID: 37086 RVA: 0x0039B9B0 File Offset: 0x00399BB0
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && euf.a(A_0.a().Offense.u(), this.a))
		{
			dcu dcu = A_0.a().Offense;
			dcu.c(dcu.a0() + base.b());
		}
	}

	// Token: 0x060090DF RID: 37087 RVA: 0x0039BA10 File Offset: 0x00399C10
	public override d3e b3()
	{
		dvq dvq = new dvq();
		this.xx(dvq);
		return dvq;
	}

	// Token: 0x060090E0 RID: 37088 RVA: 0x0039BA2C File Offset: 0x00399C2C
	public override string b2()
	{
		string arg = bsr.a(this.a);
		if (base.b() >= 0.0)
		{
			return string.Format("Шанс критического удара от атак {0} увеличен на {1}%.", arg, Math.Round(base.b(), 2) * 100.0);
		}
		return string.Format("Шанс критического удара от атак {0} уменьшен на {1}%.", arg, Math.Abs(Math.Round(base.b(), 2)) * 100.0);
	}

	// Token: 0x060090E1 RID: 37089 RVA: 0x0039BAAC File Offset: 0x00399CAC
	public void cn(d3e A_0)
	{
		dvq dvq = A_0 as dvq;
		if (dvq != null)
		{
			base.a(base.b() + dvq.b());
		}
	}

	// Token: 0x060090E2 RID: 37090 RVA: 0x0039BADC File Offset: 0x00399CDC
	public bool co(d3e A_0)
	{
		dvq dvq = A_0 as dvq;
		return dvq != null && dvq.a == this.a;
	}

	// Token: 0x04003817 RID: 14359
	private new cs5 a;
}
