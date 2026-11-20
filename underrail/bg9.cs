using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C78 RID: 7288
[d29("TemperedAcid", "Tempered: Acid")]
public sealed class bg9 : bl0
{
	// Token: 0x06009FBF RID: 40895 RVA: 0x003E44F0 File Offset: 0x003E26F0
	protected override DamageType sl()
	{
		return DamageType.Acid;
	}

	// Token: 0x06009FC0 RID: 40896 RVA: 0x003E44F4 File Offset: 0x003E26F4
	public bg9() : base("肺Закалка кислотой")
	{
	}
}
