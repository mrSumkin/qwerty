using System;

// Token: 0x020018A9 RID: 6313
public sealed class b1d : btm
{
	// Token: 0x0600861D RID: 34333 RVA: 0x00378AC4 File Offset: 0x00376CC4
	protected override bool b4(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.amm();
		}
		return true;
	}

	// Token: 0x0600861E RID: 34334 RVA: 0x00378AE4 File Offset: 0x00376CE4
	public b1d() : base(null)
	{
	}
}
