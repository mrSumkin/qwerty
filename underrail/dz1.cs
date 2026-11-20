using System;

// Token: 0x02001FBA RID: 8122
public sealed class dz1 : btm
{
	// Token: 0x0600BEC4 RID: 48836 RVA: 0x0041BCB0 File Offset: 0x00419EB0
	protected override bool b4(e6d A_0)
	{
		bcm service = bpo.GetService<bcm>();
		if (service != null)
		{
			service.aap(true);
		}
		return true;
	}

	// Token: 0x0600BEC5 RID: 48837 RVA: 0x0041BCD4 File Offset: 0x00419ED4
	public dz1() : base(null)
	{
	}
}
