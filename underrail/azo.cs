using System;

// Token: 0x02002101 RID: 8449
[dp2("1.1.3.4_LostVaultkeycardFix", "1.1.3.4")]
public sealed class azo : dnv
{
	// Token: 0x0600C84F RID: 51279 RVA: 0x00469F78 File Offset: 0x00468178
	public bool eq(bk3 A_0)
	{
		return true;
	}

	// Token: 0x0600C850 RID: 51280 RVA: 0x00469F7C File Offset: 0x0046817C
	public bool er(coh A_0)
	{
		d48 d = A_0 as d48;
		if (d != null && d.Definition.a5() == "key.lostVault_securitycard")
		{
			d.CustomProperties["security_access:lostVault"] = 1;
		}
		return true;
	}
}
