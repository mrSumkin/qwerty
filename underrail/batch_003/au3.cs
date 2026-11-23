using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C76 RID: 7286
[d29("TemperedElectricity", "Tempered: Electricity")]
public sealed class au3 : bl0
{
	// Token: 0x06009FB7 RID: 40887 RVA: 0x003E43CC File Offset: 0x003E25CC
	protected override DamageType sl()
	{
		return DamageType.Electricity;
	}

	// Token: 0x06009FB8 RID: 40888 RVA: 0x003E43D0 File Offset: 0x003E25D0
	public au3() : base("肽Закалка электричеством")
	{
	}
}
