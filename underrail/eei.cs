using System;

// Token: 0x020018B7 RID: 6327
public sealed class eei
{
	// Token: 0x170001FD RID: 509
	// (get) Token: 0x0600864A RID: 34378 RVA: 0x0037B1AC File Offset: 0x003793AC
	public string Name
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x0600864B RID: 34379 RVA: 0x0037B1B4 File Offset: 0x003793B4
	public string Group
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x0600864C RID: 34380 RVA: 0x0037B1BC File Offset: 0x003793BC
	public string DisplayText
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x0600864D RID: 34381 RVA: 0x0037B1C4 File Offset: 0x003793C4
	public int ClassicExperience
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x0600864E RID: 34382 RVA: 0x0037B1CC File Offset: 0x003793CC
	public int OddityExperience
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x0600864F RID: 34383 RVA: 0x0037B1D4 File Offset: 0x003793D4
	public eei(string A_0, string A_1, int A_2, int A_3, string A_4)
	{
		this.a = A_1;
		this.b = A_0;
		this.d = A_2;
		this.e = A_3;
		this.c = A_4;
	}

	// Token: 0x0400337C RID: 13180
	private string a;

	// Token: 0x0400337D RID: 13181
	private string b;

	// Token: 0x0400337E RID: 13182
	private string c;

	// Token: 0x0400337F RID: 13183
	private int d;

	// Token: 0x04003380 RID: 13184
	private int e;
}
