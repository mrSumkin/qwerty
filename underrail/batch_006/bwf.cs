using System;

// Token: 0x020006A2 RID: 1698
public sealed class bwf
{
	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06002C02 RID: 11266 RVA: 0x000FD2D0 File Offset: 0x000FB4D0
	public string PatchId
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000FD2D8 File Offset: 0x000FB4D8
	public Version TargetVersion
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06002C04 RID: 11268 RVA: 0x000FD2E0 File Offset: 0x000FB4E0
	public fg Patch
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000FD2E8 File Offset: 0x000FB4E8
	public bool AlwaysApply
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x000FD2F0 File Offset: 0x000FB4F0
	public bwf(string A_0, Version A_1, fg A_2, bool A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x04001913 RID: 6419
	private string a;

	// Token: 0x04001914 RID: 6420
	private Version b;

	// Token: 0x04001915 RID: 6421
	private fg c;

	// Token: 0x04001916 RID: 6422
	private bool d;
}
