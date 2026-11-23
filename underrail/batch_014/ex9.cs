using System;
using System.Runtime.Serialization;

// Token: 0x020019EB RID: 6635
[eiz("MWCBDE")]
[Serializable]
public sealed class ex9 : d91, d7s, ISerializable
{
	// Token: 0x06008EC2 RID: 36546 RVA: 0x003964B4 File Offset: 0x003946B4
	private ex9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (cs5)A_0.GetValue("MWCBDE:C", typeof(cs5));
	}

	// Token: 0x06008EC3 RID: 36547 RVA: 0x003964E0 File Offset: 0x003946E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MWCBDE:C", this.a);
	}

	// Token: 0x06008EC4 RID: 36548 RVA: 0x00396500 File Offset: 0x00394700
	public cs5 a()
	{
		return this.a;
	}

	// Token: 0x06008EC5 RID: 36549 RVA: 0x00396508 File Offset: 0x00394708
	public void a(cs5 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008EC6 RID: 36550 RVA: 0x00396514 File Offset: 0x00394714
	public ex9()
	{
	}

	// Token: 0x06008EC7 RID: 36551 RVA: 0x0039651C File Offset: 0x0039471C
	public ex9(double A_0, cs5 A_1 = cs5.a) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06008EC8 RID: 36552 RVA: 0x0039652C File Offset: 0x0039472C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ex9)A_0).a = this.a;
	}

	// Token: 0x06008EC9 RID: 36553 RVA: 0x00396548 File Offset: 0x00394748
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && euf.a(A_0.a().Offense.u(), this.a))
		{
			cmn cmn = new cmn();
			cmn.b += base.b();
			A_0.a().Offense.a(as3.a, cmn);
		}
	}

	// Token: 0x06008ECA RID: 36554 RVA: 0x003965C0 File Offset: 0x003947C0
	public override d3e b3()
	{
		bhi bhi = new bhi();
		this.xx(bhi);
		return bhi;
	}

	// Token: 0x06008ECB RID: 36555 RVA: 0x003965DC File Offset: 0x003947DC
	public override string b2()
	{
		string arg = bsr.a(this.a);
		if (base.b() >= 0.0)
		{
			return string.Format("Бонус урона от атак {0} увеличен на {1}%.", arg, Math.Round(base.b(), 2) * 100.0);
		}
		return string.Format("Бонус урона от атак {0} уменьшен на {1}%.", arg, Math.Abs(Math.Round(base.b(), 2)) * 100.0);
	}

	// Token: 0x06008ECC RID: 36556 RVA: 0x0039665C File Offset: 0x0039485C
	public void cn(d3e A_0)
	{
		ex9 ex = A_0 as ex9;
		if (ex != null)
		{
			base.a(base.b() + ex.b());
		}
	}

	// Token: 0x06008ECD RID: 36557 RVA: 0x0039668C File Offset: 0x0039488C
	public bool co(d3e A_0)
	{
		ex9 ex = A_0 as ex9;
		return ex != null && ex.a == this.a;
	}

	// Token: 0x040037E1 RID: 14305
	private new cs5 a;
}
