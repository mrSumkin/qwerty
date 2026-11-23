using System;

// Token: 0x02001FBB RID: 8123
public sealed class cqx : btm
{
	// Token: 0x0600BEC6 RID: 48838 RVA: 0x0041BCE0 File Offset: 0x00419EE0
	protected override bool b4(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.amn();
		}
		else
		{
			bcm service2 = bpo.GetService<bcm>();
			if (service2 != null)
			{
				service2.aar(false);
			}
		}
		chr service3 = bpo.GetService<chr>();
		if (service3 != null && service3.aw())
		{
			service3.ay();
		}
		return true;
	}

	// Token: 0x0600BEC7 RID: 48839 RVA: 0x0041BD38 File Offset: 0x00419F38
	public cqx() : base(null)
	{
	}
}
