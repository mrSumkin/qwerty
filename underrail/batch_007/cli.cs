using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C79 RID: 7289
[d29("TemperedCold", "Tempered: Cold")]
public sealed class cli : bl0
{
	// Token: 0x06009FC1 RID: 40897 RVA: 0x003E4504 File Offset: 0x003E2704
	protected override DamageType sl()
	{
		return DamageType.Cold;
	}

	// Token: 0x06009FC2 RID: 40898 RVA: 0x003E4508 File Offset: 0x003E2708
	public cli() : base("肼Закалка холодом")
	{
	}
}
