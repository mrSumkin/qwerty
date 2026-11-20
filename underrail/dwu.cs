using System;

// Token: 0x02001A5C RID: 6748
[eiz("eaSEEA")]
[Serializable]
public class dwu : EventArgs
{
	// Token: 0x06009284 RID: 37508 RVA: 0x0039FAE0 File Offset: 0x0039DCE0
	public els b()
	{
		return this.a;
	}

	// Token: 0x06009285 RID: 37509 RVA: 0x0039FAE8 File Offset: 0x0039DCE8
	public ll c()
	{
		return this.b;
	}

	// Token: 0x06009286 RID: 37510 RVA: 0x0039FAF0 File Offset: 0x0039DCF0
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06009287 RID: 37511 RVA: 0x0039FAFC File Offset: 0x0039DCFC
	public dwu(els A_0, ll A_1, bool A_2 = false)
	{
		this.a = A_0;
		this.b = A_1;
		bool flag;
		if (!A_2)
		{
			els els = this.a;
			flag = (els != null && !els.Visible);
		}
		else
		{
			flag = true;
		}
		this.c = flag;
	}

	// Token: 0x04003856 RID: 14422
	private els a;

	// Token: 0x04003857 RID: 14423
	private ll b;

	// Token: 0x04003858 RID: 14424
	private bool c;
}
