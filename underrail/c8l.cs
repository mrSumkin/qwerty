using System;

// Token: 0x02001FB9 RID: 8121
public sealed class c8l : btm
{
	// Token: 0x0600BEC2 RID: 48834 RVA: 0x0041BC80 File Offset: 0x00419E80
	protected override bool b4(e6d A_0)
	{
		bcm service = bpo.GetService<bcm>();
		if (service != null)
		{
			service.aap(false);
		}
		return true;
	}

	// Token: 0x0600BEC3 RID: 48835 RVA: 0x0041BCA4 File Offset: 0x00419EA4
	public c8l() : base(null)
	{
	}
}
