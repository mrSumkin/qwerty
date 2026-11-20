using System;
using System.Runtime.Serialization;

// Token: 0x02001A15 RID: 6677
[eiz("MHF")]
[Serializable]
public sealed class dxd : dts, d7s, bdr, ISerializable
{
	// Token: 0x0600905D RID: 36957 RVA: 0x0039A2D0 File Offset: 0x003984D0
	private dxd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600905E RID: 36958 RVA: 0x0039A2DC File Offset: 0x003984DC
	public dxd()
	{
	}

	// Token: 0x0600905F RID: 36959 RVA: 0x0039A2E4 File Offset: 0x003984E4
	public dxd(int A_0) : base(A_0)
	{
	}

	// Token: 0x06009060 RID: 36960 RVA: 0x0039A2F0 File Offset: 0x003984F0
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			nw nw = A_0.a().Defense;
			nw.f(nw.ai() + base.c());
		}
	}

	// Token: 0x06009061 RID: 36961 RVA: 0x0039A32C File Offset: 0x0039852C
	public void cn(d3e A_0)
	{
		dxd dxd = A_0 as dxd;
		if (dxd != null)
		{
			base.a(base.c() + dxd.c());
		}
	}

	// Token: 0x06009062 RID: 36962 RVA: 0x0039A35C File Offset: 0x0039855C
	public bool co(d3e A_0)
	{
		return A_0 is dxd;
	}

	// Token: 0x06009063 RID: 36963 RVA: 0x0039A368 File Offset: 0x00398568
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyHealthFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyHealthFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06009064 RID: 36964 RVA: 0x0039A3C4 File Offset: 0x003985C4
	public override d3e b3()
	{
		dxd dxd = new dxd();
		this.xx(dxd);
		return dxd;
	}
}
