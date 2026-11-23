using System;

// Token: 0x02000807 RID: 2055
public sealed class adq : el4
{
	// Token: 0x060033E3 RID: 13283 RVA: 0x00142494 File Offset: 0x00140694
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x001424A0 File Offset: 0x001406A0
	public override string a4()
	{
		return "GC_FSH";
	}

	// Token: 0x060033E5 RID: 13285 RVA: 0x001424A8 File Offset: 0x001406A8
	public override string a5()
	{
		return "Mute Fisherman";
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x001424B0 File Offset: 0x001406B0
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("npc_rnd_fisherman_wontRespawn", new bool?(false)).Value;
	}

	// Token: 0x060033E7 RID: 13287 RVA: 0x001424F4 File Offset: 0x001406F4
	public override bool fl()
	{
		return true;
	}

	// Token: 0x060033E8 RID: 13288 RVA: 0x001424F8 File Offset: 0x001406F8
	public override double ke()
	{
		return 0.07;
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x00142504 File Offset: 0x00140704
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(90.0));
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x0014251C File Offset: 0x0014071C
	protected override bool oe()
	{
		return true;
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x00142520 File Offset: 0x00140720
	public adq() : base(new string[]
	{
		ega.a0
	})
	{
	}
}
