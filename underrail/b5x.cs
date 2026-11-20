using System;
using System.Runtime.Serialization;

// Token: 0x02001A01 RID: 6657
[eiz("MIFE")]
[Serializable]
public sealed class b5x : dts, ISerializable, d7s
{
	// Token: 0x06008FA6 RID: 36774 RVA: 0x003984F0 File Offset: 0x003966F0
	private b5x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FA7 RID: 36775 RVA: 0x003984FC File Offset: 0x003966FC
	public b5x()
	{
	}

	// Token: 0x06008FA8 RID: 36776 RVA: 0x00398504 File Offset: 0x00396704
	public b5x(int A_0) : base(A_0)
	{
	}

	// Token: 0x06008FA9 RID: 36777 RVA: 0x00398510 File Offset: 0x00396710
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		dcu dcu = A_0.a().Offense;
		dcu.f(dcu.ay() + base.c());
	}

	// Token: 0x06008FAA RID: 36778 RVA: 0x00398548 File Offset: 0x00396748
	public void cn(d3e A_0)
	{
		b5x b5x = A_0 as b5x;
		if (b5x != null)
		{
			base.a(base.c() + b5x.c());
		}
	}

	// Token: 0x06008FAB RID: 36779 RVA: 0x00398578 File Offset: 0x00396778
	public bool co(d3e A_0)
	{
		b5x b5x = A_0 as b5x;
		return b5x != null && b5x.Condition == base.Condition;
	}

	// Token: 0x06008FAC RID: 36780 RVA: 0x003985A4 File Offset: 0x003967A4
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyInitiativeFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyInitiativeFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06008FAD RID: 36781 RVA: 0x00398600 File Offset: 0x00396800
	public override d3e b3()
	{
		b5x b5x = new b5x();
		this.xx(b5x);
		return b5x;
	}
}
