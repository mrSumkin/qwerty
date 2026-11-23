using System;
using System.Runtime.Serialization;

// Token: 0x02001A1D RID: 6685
[eiz("MEFE")]
[Serializable]
public sealed class a6z : dts, ISerializable, d7s, asx
{
	// Token: 0x060090B4 RID: 37044 RVA: 0x0039B3F4 File Offset: 0x003995F4
	private a6z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060090B5 RID: 37045 RVA: 0x0039B400 File Offset: 0x00399600
	public ni vj()
	{
		return ni.b;
	}

	// Token: 0x060090B6 RID: 37046 RVA: 0x0039B404 File Offset: 0x00399604
	public a6z()
	{
	}

	// Token: 0x060090B7 RID: 37047 RVA: 0x0039B40C File Offset: 0x0039960C
	public a6z(int A_0) : base(A_0)
	{
	}

	// Token: 0x060090B8 RID: 37048 RVA: 0x0039B418 File Offset: 0x00399618
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		nw nw = A_0.a().Defense;
		nw.a(nw.z() + base.c());
	}

	// Token: 0x060090B9 RID: 37049 RVA: 0x0039B450 File Offset: 0x00399650
	public void cn(d3e A_0)
	{
		a6z a6z = A_0 as a6z;
		if (a6z != null)
		{
			base.a(base.c() + a6z.c());
		}
	}

	// Token: 0x060090BA RID: 37050 RVA: 0x0039B480 File Offset: 0x00399680
	public bool co(d3e A_0)
	{
		a6z a6z = A_0 as a6z;
		return a6z != null && a6z.Condition == base.Condition;
	}

	// Token: 0x060090BB RID: 37051 RVA: 0x0039B4AC File Offset: 0x003996AC
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyEvasionFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyEvasionFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x060090BC RID: 37052 RVA: 0x0039B508 File Offset: 0x00399708
	public override d3e b3()
	{
		a6z a6z = new a6z();
		this.xx(a6z);
		return a6z;
	}
}
