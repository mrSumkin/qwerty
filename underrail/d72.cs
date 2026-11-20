using System;
using System.Runtime.Serialization;

// Token: 0x02001A07 RID: 6663
[eiz("MPF")]
[Serializable]
public sealed class d72 : dts, d7s, em0, ISerializable
{
	// Token: 0x06008FDB RID: 36827 RVA: 0x00398DF0 File Offset: 0x00396FF0
	private d72(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FDC RID: 36828 RVA: 0x00398DFC File Offset: 0x00396FFC
	public d72()
	{
	}

	// Token: 0x06008FDD RID: 36829 RVA: 0x00398E04 File Offset: 0x00397004
	public d72(int A_0) : base(A_0)
	{
	}

	// Token: 0x06008FDE RID: 36830 RVA: 0x00398E10 File Offset: 0x00397010
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			dcu dcu = A_0.a().Offense;
			dcu.c(dcu.t() + base.c());
		}
	}

	// Token: 0x06008FDF RID: 36831 RVA: 0x00398E4C File Offset: 0x0039704C
	public void cn(d3e A_0)
	{
		d72 d = A_0 as d72;
		if (d != null)
		{
			base.a(base.c() + d.c());
		}
	}

	// Token: 0x06008FE0 RID: 36832 RVA: 0x00398E7C File Offset: 0x0039707C
	public bool co(d3e A_0)
	{
		return A_0 is d72;
	}

	// Token: 0x06008FE1 RID: 36833 RVA: 0x00398E88 File Offset: 0x00397088
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyPsiFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyPsiFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06008FE2 RID: 36834 RVA: 0x00398EE4 File Offset: 0x003970E4
	public override d3e b3()
	{
		d72 d = new d72();
		this.xx(d);
		return d;
	}
}
