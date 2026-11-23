using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C7A RID: 7290
[d29("TemperedHeat", "Tempered: Heat")]
public sealed class dwl : bl0
{
	// Token: 0x06009FC3 RID: 40899 RVA: 0x003E4518 File Offset: 0x003E2718
	protected override DamageType sl()
	{
		return DamageType.Heat;
	}

	// Token: 0x06009FC4 RID: 40900 RVA: 0x003E451C File Offset: 0x003E271C
	public dwl() : base("肻Закалка огнём")
	{
	}
}
