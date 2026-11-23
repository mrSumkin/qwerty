using System;
using System.Runtime.Serialization;

// Token: 0x02001A14 RID: 6676
[eiz("MDFE")]
[Serializable]
public sealed class bel : dts, ISerializable, d7s, asx
{
	// Token: 0x06009054 RID: 36948 RVA: 0x0039A1A0 File Offset: 0x003983A0
	private bel(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009055 RID: 36949 RVA: 0x0039A1AC File Offset: 0x003983AC
	public ni vj()
	{
		return ni.b;
	}

	// Token: 0x06009056 RID: 36950 RVA: 0x0039A1B0 File Offset: 0x003983B0
	public bel()
	{
	}

	// Token: 0x06009057 RID: 36951 RVA: 0x0039A1B8 File Offset: 0x003983B8
	public bel(int A_0) : base(A_0)
	{
	}

	// Token: 0x06009058 RID: 36952 RVA: 0x0039A1C4 File Offset: 0x003983C4
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		nw nw = A_0.a().Defense;
		nw.c(nw.v() + base.c());
	}

	// Token: 0x06009059 RID: 36953 RVA: 0x0039A1FC File Offset: 0x003983FC
	public void cn(d3e A_0)
	{
		bel bel = A_0 as bel;
		if (bel != null)
		{
			base.a(base.c() + bel.c());
		}
	}

	// Token: 0x0600905A RID: 36954 RVA: 0x0039A22C File Offset: 0x0039842C
	public bool co(d3e A_0)
	{
		bel bel = A_0 as bel;
		return bel != null && bel.Condition == base.Condition;
	}

	// Token: 0x0600905B RID: 36955 RVA: 0x0039A258 File Offset: 0x00398458
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyDodgeFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyDodgeFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x0600905C RID: 36956 RVA: 0x0039A2B4 File Offset: 0x003984B4
	public override d3e b3()
	{
		bel bel = new bel();
		this.xx(bel);
		return bel;
	}
}
