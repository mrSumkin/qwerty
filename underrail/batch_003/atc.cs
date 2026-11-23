using System;
using System.Reflection;

// Token: 0x020001B6 RID: 438
[DefaultMember("Item")]
public class atc
{
	// Token: 0x06000CA8 RID: 3240 RVA: 0x000340A8 File Offset: 0x000322A8
	public atc(int A_0, int A_1, int A_2)
	{
		this.a = A_2;
		this.b = new long[A_0 + 2 * A_2, A_1 + 2 * A_2];
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x000340CC File Offset: 0x000322CC
	public long b(int A_0, int A_1)
	{
		return this.b[A_0 + this.a, A_1 + this.a];
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x000340EC File Offset: 0x000322EC
	public void b(int A_0, int A_1, long A_2)
	{
		this.b[A_0 + this.a, A_1 + this.a] = A_2;
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x0003410C File Offset: 0x0003230C
	public long a(int A_0, int A_1)
	{
		return this.b[A_0 + this.a, A_1 + this.a];
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x0003412C File Offset: 0x0003232C
	public void a(int A_0, int A_1, long A_2)
	{
		this.b[A_0 + this.a, A_1 + this.a] = A_2;
	}

	// Token: 0x04000777 RID: 1911
	private int a;

	// Token: 0x04000778 RID: 1912
	private long[,] b;
}
