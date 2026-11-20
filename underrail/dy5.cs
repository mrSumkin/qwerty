using System;

// Token: 0x020008CE RID: 2254
public abstract class dy5 : el4
{
	// Token: 0x06003817 RID: 14359 RVA: 0x0014DC50 File Offset: 0x0014BE50
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003818 RID: 14360 RVA: 0x0014DC5C File Offset: 0x0014BE5C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003819 RID: 14361 RVA: 0x0014DC64 File Offset: 0x0014BE64
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_mutagenPlaced", new bool?(false)).Value;
	}

	// Token: 0x0600381A RID: 14362 RVA: 0x0014DCA8 File Offset: 0x0014BEA8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(30.0));
	}

	// Token: 0x0600381B RID: 14363 RVA: 0x0014DCC0 File Offset: 0x0014BEC0
	public override double ke()
	{
		return 0.06;
	}

	// Token: 0x0600381C RID: 14364 RVA: 0x0014DCCC File Offset: 0x0014BECC
	protected dy5() : base(new string[]
	{
		ega.f
	})
	{
	}
}
