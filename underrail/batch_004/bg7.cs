using System;

// Token: 0x020007FB RID: 2043
public sealed class bg7 : el4
{
	// Token: 0x0600337A RID: 13178 RVA: 0x00140A54 File Offset: 0x0013EC54
	protected override esj a3()
	{
		return new esj(5, 10);
	}

	// Token: 0x0600337B RID: 13179 RVA: 0x00140A60 File Offset: 0x0013EC60
	public override string a4()
	{
		return "CVW_HG_CH_VS_RH1Y";
	}

	// Token: 0x0600337C RID: 13180 RVA: 0x00140A68 File Offset: 0x0013EC68
	public override string a5()
	{
		return "Hunting Grounds Hunter-Rathound Fight";
	}

	// Token: 0x0600337D RID: 13181 RVA: 0x00140A70 File Offset: 0x0013EC70
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (!A_0.r().GetPrimitivePropertyValue<bool>("HathorKingSituationResolved", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("loc_cvw47_allHathoriansKilled", new bool?(false)).Value) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x0600337E RID: 13182 RVA: 0x00140AD0 File Offset: 0x0013ECD0
	public override double ke()
	{
		return 0.07;
	}

	// Token: 0x0600337F RID: 13183 RVA: 0x00140ADC File Offset: 0x0013ECDC
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003380 RID: 13184 RVA: 0x00140AE0 File Offset: 0x0013ECE0
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(20.0));
	}

	// Token: 0x06003381 RID: 13185 RVA: 0x00140AF8 File Offset: 0x0013ECF8
	public bg7() : base(new string[]
	{
		ega.bd
	})
	{
	}

	// Token: 0x06003382 RID: 13186 RVA: 0x00140B10 File Offset: 0x0013ED10
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
	}
}
