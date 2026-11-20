using System;

// Token: 0x02001FBC RID: 8124
public sealed class by : btm
{
	// Token: 0x0600BEC8 RID: 48840 RVA: 0x0041BD44 File Offset: 0x00419F44
	protected override bool b4(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.amo();
		}
		else
		{
			bcm service2 = bpo.GetService<bcm>();
			if (service2 != null)
			{
				service2.aar(true);
			}
		}
		return true;
	}

	// Token: 0x0600BEC9 RID: 48841 RVA: 0x0041BD7C File Offset: 0x00419F7C
	public by() : base(null)
	{
	}
}
