using System;

// Token: 0x020018A5 RID: 6309
public sealed class bge : btm
{
	// Token: 0x06008615 RID: 34325 RVA: 0x00378A14 File Offset: 0x00376C14
	protected override bool b4(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.alr();
		}
		return true;
	}

	// Token: 0x06008616 RID: 34326 RVA: 0x00378A34 File Offset: 0x00376C34
	public bge() : base(null)
	{
	}
}
