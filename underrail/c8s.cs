using System;

// Token: 0x02001891 RID: 6289
public sealed class c8s : bpy
{
	// Token: 0x06008572 RID: 34162 RVA: 0x00376674 File Offset: 0x00374874
	protected override byte aju()
	{
		return byte.MaxValue;
	}

	// Token: 0x06008573 RID: 34163 RVA: 0x0037667C File Offset: 0x0037487C
	protected override int ajv(int A_0, int A_1)
	{
		return Math.Max(0, A_0 - A_1);
	}

	// Token: 0x06008574 RID: 34164 RVA: 0x00376688 File Offset: 0x00374888
	protected override bool ajw(int A_0)
	{
		return A_0 <= 0;
	}
}
