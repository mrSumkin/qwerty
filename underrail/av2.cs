using System;

// Token: 0x020018AF RID: 6319
public sealed class av2 : btm
{
	// Token: 0x06008629 RID: 34345 RVA: 0x00378BA0 File Offset: 0x00376DA0
	protected override bool b4(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.alp();
		}
		return true;
	}

	// Token: 0x0600862A RID: 34346 RVA: 0x00378BC0 File Offset: 0x00376DC0
	public av2() : base(null)
	{
	}
}
