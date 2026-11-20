using System;

// Token: 0x0200217F RID: 8575
[dp2("1.0.3.3_ChemicalPistolUnloading", "1.0.3.3")]
public sealed class dy : dnv
{
	// Token: 0x0600C94B RID: 51531 RVA: 0x00471E88 File Offset: 0x00470088
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && eub.d(bke.ak()) && (bke.a2().Count < 1 || bke.a2()[0].CapabilityFullTypeName != "uwep"))
		{
			bke.a2().Insert(0, new aia("uwep"));
		}
		return true;
	}

	// Token: 0x0600C94C RID: 51532 RVA: 0x00471EFC File Offset: 0x004700FC
	public bool er(coh A_0)
	{
		return true;
	}
}
