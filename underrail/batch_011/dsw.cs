using System;

// Token: 0x02000892 RID: 2194
public abstract class dsw : el4
{
	// Token: 0x06003672 RID: 13938 RVA: 0x0014B208 File Offset: 0x00149408
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x06003673 RID: 13939 RVA: 0x0014B214 File Offset: 0x00149414
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003674 RID: 13940 RVA: 0x0014B218 File Offset: 0x00149418
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003675 RID: 13941 RVA: 0x0014B21C File Offset: 0x0014941C
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003676 RID: 13942 RVA: 0x0014B220 File Offset: 0x00149420
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003677 RID: 13943 RVA: 0x0014B228 File Offset: 0x00149428
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x06003678 RID: 13944 RVA: 0x0014B240 File Offset: 0x00149440
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value;
	}

	// Token: 0x06003679 RID: 13945 RVA: 0x0014B284 File Offset: 0x00149484
	protected dsw() : base(new string[]
	{
		ega.g,
		ega.h,
		ega.a
	})
	{
	}
}
