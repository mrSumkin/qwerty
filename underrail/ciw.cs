using System;
using System.Runtime.Serialization;

// Token: 0x020019FA RID: 6650
[eiz("MRFE")]
[Serializable]
public sealed class ciw : dts, ISerializable, d7s
{
	// Token: 0x06008F5B RID: 36699 RVA: 0x00397950 File Offset: 0x00395B50
	private ciw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008F5C RID: 36700 RVA: 0x0039795C File Offset: 0x00395B5C
	public ciw()
	{
	}

	// Token: 0x06008F5D RID: 36701 RVA: 0x00397964 File Offset: 0x00395B64
	public ciw(int A_0) : base(A_0)
	{
	}

	// Token: 0x06008F5E RID: 36702 RVA: 0x00397970 File Offset: 0x00395B70
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		nw nw = A_0.a().Defense;
		nw.b(nw.ae() + base.c());
	}

	// Token: 0x06008F5F RID: 36703 RVA: 0x003979A8 File Offset: 0x00395BA8
	public void cn(d3e A_0)
	{
		ciw ciw = A_0 as ciw;
		if (ciw != null)
		{
			base.a(base.c() + ciw.c());
		}
	}

	// Token: 0x06008F60 RID: 36704 RVA: 0x003979D8 File Offset: 0x00395BD8
	public bool co(d3e A_0)
	{
		ciw ciw = A_0 as ciw;
		return ciw != null && ciw.Condition == base.Condition;
	}

	// Token: 0x06008F61 RID: 36705 RVA: 0x00397A04 File Offset: 0x00395C04
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyResolveFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyResolveFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06008F62 RID: 36706 RVA: 0x00397A60 File Offset: 0x00395C60
	public override d3e b3()
	{
		ciw ciw = new ciw();
		this.xx(ciw);
		return ciw;
	}
}
