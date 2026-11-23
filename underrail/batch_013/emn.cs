using System;
using System.Runtime.Serialization;

// Token: 0x02001A02 RID: 6658
[eiz("MPRFE")]
[Serializable]
public sealed class emn : dts, d7s, bdr, ISerializable
{
	// Token: 0x06008FAE RID: 36782 RVA: 0x0039861C File Offset: 0x0039681C
	private emn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FAF RID: 36783 RVA: 0x00398628 File Offset: 0x00396828
	public emn()
	{
	}

	// Token: 0x06008FB0 RID: 36784 RVA: 0x00398630 File Offset: 0x00396830
	public emn(int A_0) : base(A_0)
	{
	}

	// Token: 0x06008FB1 RID: 36785 RVA: 0x0039863C File Offset: 0x0039683C
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			dcu dcu = A_0.a().Offense;
			dcu.j(dcu.ai() + base.c());
		}
	}

	// Token: 0x06008FB2 RID: 36786 RVA: 0x00398678 File Offset: 0x00396878
	public void cn(d3e A_0)
	{
		dxd dxd = A_0 as dxd;
		if (dxd != null)
		{
			base.a(base.c() + dxd.c());
		}
	}

	// Token: 0x06008FB3 RID: 36787 RVA: 0x003986A8 File Offset: 0x003968A8
	public bool co(d3e A_0)
	{
		return A_0 is dxd;
	}

	// Token: 0x06008FB4 RID: 36788 RVA: 0x003986B4 File Offset: 0x003968B4
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyPsiRegenFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyPsiRegenFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06008FB5 RID: 36789 RVA: 0x00398710 File Offset: 0x00396910
	public override d3e b3()
	{
		emn emn = new emn();
		this.xx(emn);
		return emn;
	}
}
