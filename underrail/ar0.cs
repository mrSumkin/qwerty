using System;

// Token: 0x02001FB8 RID: 8120
public sealed class ar0 : btm
{
	// Token: 0x0600BEC0 RID: 48832 RVA: 0x0041BC54 File Offset: 0x00419E54
	protected override bool b4(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.anh();
		}
		return true;
	}

	// Token: 0x0600BEC1 RID: 48833 RVA: 0x0041BC74 File Offset: 0x00419E74
	public ar0() : base(null)
	{
	}
}
