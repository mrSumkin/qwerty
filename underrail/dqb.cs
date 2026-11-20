using System;

// Token: 0x0200069A RID: 1690
public sealed class dqb
{
	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000FD120 File Offset: 0x000FB320
	public string PatchId
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06002BED RID: 11245 RVA: 0x000FD128 File Offset: 0x000FB328
	public Version TargetVersion
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000FD130 File Offset: 0x000FB330
	public dnv Patch
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x06002BEF RID: 11247 RVA: 0x000FD138 File Offset: 0x000FB338
	public dqb(string A_0, Version A_1, dnv A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x04001903 RID: 6403
	private string a;

	// Token: 0x04001904 RID: 6404
	private Version b;

	// Token: 0x04001905 RID: 6405
	private dnv c;
}
