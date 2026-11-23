using System;

// Token: 0x02000144 RID: 324
public class aof
{
	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000801 RID: 2049 RVA: 0x00022118 File Offset: 0x00020318
	public atr Answer
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000802 RID: 2050 RVA: 0x00022120 File Offset: 0x00020320
	public string Text
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00022128 File Offset: 0x00020328
	public aof(atr A_0, string A_1, bq8 A_2, bq8 A_3)
	{
		this.a = A_0;
		this.b = A_0.a(A_1, A_2, A_3);
	}

	// Token: 0x0400058C RID: 1420
	private atr a;

	// Token: 0x0400058D RID: 1421
	private string b;
}
