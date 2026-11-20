using System;
using System.Runtime.Serialization;

// Token: 0x020019E5 RID: 6629
[eiz("MDTFE")]
[Serializable]
public sealed class ds1 : dts, ISerializable, d7s
{
	// Token: 0x06008E84 RID: 36484 RVA: 0x00395930 File Offset: 0x00393B30
	private ds1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008E85 RID: 36485 RVA: 0x0039593C File Offset: 0x00393B3C
	public ds1()
	{
	}

	// Token: 0x06008E86 RID: 36486 RVA: 0x00395944 File Offset: 0x00393B44
	public ds1(int A_0) : base(A_0)
	{
	}

	// Token: 0x06008E87 RID: 36487 RVA: 0x00395950 File Offset: 0x00393B50
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		A_0.a().Detection += base.c();
	}

	// Token: 0x06008E88 RID: 36488 RVA: 0x00395980 File Offset: 0x00393B80
	public void cn(d3e A_0)
	{
		ds1 ds = A_0 as ds1;
		if (ds != null)
		{
			base.a(base.c() + ds.c());
		}
	}

	// Token: 0x06008E89 RID: 36489 RVA: 0x003959B0 File Offset: 0x00393BB0
	public bool co(d3e A_0)
	{
		ds1 ds = A_0 as ds1;
		return ds != null && ds.Condition == base.Condition;
	}

	// Token: 0x06008E8A RID: 36490 RVA: 0x003959DC File Offset: 0x00393BDC
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyDetectionFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyDetectionFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06008E8B RID: 36491 RVA: 0x00395A38 File Offset: 0x00393C38
	public override d3e b3()
	{
		ds1 ds = new ds1();
		this.xx(ds);
		return ds;
	}
}
