using System;
using System.Runtime.Serialization;

// Token: 0x02001A09 RID: 6665
[eiz("MHP")]
[Serializable]
public sealed class bh1 : d91, d7s, bdr, ISerializable
{
	// Token: 0x06008FE7 RID: 36839 RVA: 0x00399008 File Offset: 0x00397208
	private bh1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FE8 RID: 36840 RVA: 0x00399014 File Offset: 0x00397214
	public bh1()
	{
	}

	// Token: 0x06008FE9 RID: 36841 RVA: 0x0039901C File Offset: 0x0039721C
	public bh1(double A_0) : base(A_0)
	{
	}

	// Token: 0x06008FEA RID: 36842 RVA: 0x00399028 File Offset: 0x00397228
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			nw nw = A_0.a().Defense;
			nw.g(nw.k() + base.b());
		}
	}

	// Token: 0x06008FEB RID: 36843 RVA: 0x00399064 File Offset: 0x00397264
	public void cn(d3e A_0)
	{
		bh1 bh = A_0 as bh1;
		if (bh != null)
		{
			base.a(base.b() + bh.b());
		}
	}

	// Token: 0x06008FEC RID: 36844 RVA: 0x00399094 File Offset: 0x00397294
	public bool co(d3e A_0)
	{
		return A_0 is bh1;
	}

	// Token: 0x06008FED RID: 36845 RVA: 0x003990A0 File Offset: 0x003972A0
	public override string b2()
	{
		if (base.b() < 0.0)
		{
			return qv.a("StaticEffects/ModifyHealthPercentage_Decreased", new object[]
			{
				(int)Math.Abs(base.b() * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyHealthPercentage_Increased", new object[]
		{
			(int)(base.b() * 100.0)
		});
	}

	// Token: 0x06008FEE RID: 36846 RVA: 0x0039911C File Offset: 0x0039731C
	public override d3e b3()
	{
		bh1 bh = new bh1();
		this.xx(bh);
		return bh;
	}
}
