using System;

// Token: 0x02000497 RID: 1175
public sealed class bm4
{
	// Token: 0x06001E02 RID: 7682 RVA: 0x000A6808 File Offset: 0x000A4A08
	public bm4(int A_0)
	{
		A_0 = ((A_0 == int.MinValue) ? int.MaxValue : Math.Abs(A_0));
		this.a = A_0 % d9c.b;
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x000A6840 File Offset: 0x000A4A40
	public float a()
	{
		float result = d9c.d[this.a];
		int num = this.a + 1;
		this.a = num;
		if (num >= d9c.b)
		{
			this.a = 0;
		}
		return result;
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x000A687C File Offset: 0x000A4A7C
	public int a(int A_0, int A_1)
	{
		float num = this.a();
		num = (float)A_0 + (float)(A_1 - A_0) * num;
		return (int)num;
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x000A689C File Offset: 0x000A4A9C
	public int a(int A_0)
	{
		return this.a(0, A_0);
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x000A68A8 File Offset: 0x000A4AA8
	public int b()
	{
		int result = d9c.e[this.a];
		int num = this.a + 1;
		this.a = num;
		if (num >= d9c.b)
		{
			this.a = 0;
		}
		return result;
	}

	// Token: 0x0400129C RID: 4764
	private int a;
}
