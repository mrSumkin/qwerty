using System;

// Token: 0x0200016F RID: 367
public sealed class caf
{
	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000945 RID: 2373 RVA: 0x000267D8 File Offset: 0x000249D8
	// (set) Token: 0x06000946 RID: 2374 RVA: 0x000267E0 File Offset: 0x000249E0
	public euz Control
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000947 RID: 2375 RVA: 0x000267EC File Offset: 0x000249EC
	// (set) Token: 0x06000948 RID: 2376 RVA: 0x000267F4 File Offset: 0x000249F4
	public int HeightInUnits
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000949 RID: 2377 RVA: 0x00026800 File Offset: 0x00024A00
	// (set) Token: 0x0600094A RID: 2378 RVA: 0x00026808 File Offset: 0x00024A08
	public int Position
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00026814 File Offset: 0x00024A14
	public caf(euz A_0, int A_1 = 0, int A_2 = -1)
	{
		czh.a(A_0, "control");
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x040005F5 RID: 1525
	private euz a;

	// Token: 0x040005F6 RID: 1526
	private int b;

	// Token: 0x040005F7 RID: 1527
	private int c;
}
