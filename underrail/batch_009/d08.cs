using System;

// Token: 0x020018A6 RID: 6310
public sealed class d08 : btm
{
	// Token: 0x06008617 RID: 34327 RVA: 0x00378A40 File Offset: 0x00376C40
	protected override bool b4(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.aml();
		}
		return true;
	}

	// Token: 0x06008618 RID: 34328 RVA: 0x00378A60 File Offset: 0x00376C60
	public d08() : base(null)
	{
	}
}
