using System;

// Token: 0x020008CA RID: 2250
public sealed class d75 : el4
{
	// Token: 0x060037FE RID: 14334 RVA: 0x0014DAC0 File Offset: 0x0014BCC0
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060037FF RID: 14335 RVA: 0x0014DACC File Offset: 0x0014BCCC
	public override string a4()
	{
		return "CC_PH_DB_U1";
	}

	// Token: 0x06003800 RID: 14336 RVA: 0x0014DAD4 File Offset: 0x0014BCD4
	public override string a5()
	{
		return "Core City Player House Dead Burglar Unique 1";
	}

	// Token: 0x06003801 RID: 14337 RVA: 0x0014DADC File Offset: 0x0014BCDC
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003802 RID: 14338 RVA: 0x0014DAE0 File Offset: 0x0014BCE0
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003803 RID: 14339 RVA: 0x0014DAE4 File Offset: 0x0014BCE4
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003804 RID: 14340 RVA: 0x0014DAEC File Offset: 0x0014BCEC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_security_turrets_gunBalcony", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_security_turrets_plasmaBalcony", new bool?(false)).Value);
	}

	// Token: 0x06003805 RID: 14341 RVA: 0x0014DB54 File Offset: 0x0014BD54
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromSeconds(30.0));
	}

	// Token: 0x06003806 RID: 14342 RVA: 0x0014DB6C File Offset: 0x0014BD6C
	public d75() : base(new string[]
	{
		ega.at
	})
	{
	}
}
