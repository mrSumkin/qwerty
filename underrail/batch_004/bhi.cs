using System;
using System.Runtime.Serialization;

// Token: 0x02001A0B RID: 6667
[eiz("W22")]
[Serializable]
public sealed class bhi : d91, d7s, ISerializable
{
	// Token: 0x06008FF3 RID: 36851 RVA: 0x003991EC File Offset: 0x003973EC
	private bhi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 165)
		{
			this.a = (cs5)A_0.GetValue("W22:F", typeof(cs5));
		}
	}

	// Token: 0x06008FF4 RID: 36852 RVA: 0x00399228 File Offset: 0x00397428
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("W22:F", this.a);
	}

	// Token: 0x06008FF5 RID: 36853 RVA: 0x00399248 File Offset: 0x00397448
	public cs5 a()
	{
		return this.a;
	}

	// Token: 0x06008FF6 RID: 36854 RVA: 0x00399250 File Offset: 0x00397450
	public void a(cs5 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008FF7 RID: 36855 RVA: 0x0039925C File Offset: 0x0039745C
	public bhi()
	{
	}

	// Token: 0x06008FF8 RID: 36856 RVA: 0x00399264 File Offset: 0x00397464
	public bhi(double A_0, cs5 A_1 = cs5.a) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06008FF9 RID: 36857 RVA: 0x00399274 File Offset: 0x00397474
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((bhi)A_0).a = this.a;
	}

	// Token: 0x06008FFA RID: 36858 RVA: 0x00399290 File Offset: 0x00397490
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && euf.a(A_0.a().Offense.u(), this.a))
		{
			dcu dcu = A_0.a().Offense;
			dcu.g(dcu.am() + Math.Round(base.b(), 2));
		}
	}

	// Token: 0x06008FFB RID: 36859 RVA: 0x003992F8 File Offset: 0x003974F8
	public override d3e b3()
	{
		bhi bhi = new bhi();
		this.xx(bhi);
		return bhi;
	}

	// Token: 0x06008FFC RID: 36860 RVA: 0x00399314 File Offset: 0x00397514
	public override string b2()
	{
		string arg = bsr.c(this.a);
		if (base.b() >= 0.0)
		{
			return string.Format("Бонус критического урона от атак {0} увеличен на {1}%.", arg, Math.Round(base.b(), 2) * 100.0);
		}
		return string.Format("Бонус критического урона от атак {0} уменьшен на {1}%.", arg, Math.Abs(Math.Round(base.b(), 2)) * 100.0);
	}

	// Token: 0x06008FFD RID: 36861 RVA: 0x00399394 File Offset: 0x00397594
	public void cn(d3e A_0)
	{
		bhi bhi = A_0 as bhi;
		if (bhi != null)
		{
			base.a(base.b() + bhi.b());
		}
	}

	// Token: 0x06008FFE RID: 36862 RVA: 0x003993C4 File Offset: 0x003975C4
	public bool co(d3e A_0)
	{
		bhi bhi = A_0 as bhi;
		return bhi != null && bhi.a == this.a;
	}

	// Token: 0x04003800 RID: 14336
	private new cs5 a;
}
