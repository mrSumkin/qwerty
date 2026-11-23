using System;

// Token: 0x02001892 RID: 6290
public sealed class dky : bpy
{
	// Token: 0x06008576 RID: 34166 RVA: 0x0037669C File Offset: 0x0037489C
	protected override byte aju()
	{
		return 0;
	}

	// Token: 0x06008577 RID: 34167 RVA: 0x003766A0 File Offset: 0x003748A0
	protected override int ajv(int A_0, int A_1)
	{
		return Math.Min(255, A_0 + A_1);
	}

	// Token: 0x06008578 RID: 34168 RVA: 0x003766B0 File Offset: 0x003748B0
	protected override bool ajw(int A_0)
	{
		return A_0 >= 255;
	}
}
