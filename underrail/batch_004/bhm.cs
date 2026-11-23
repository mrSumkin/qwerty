using System;

// Token: 0x020018D9 RID: 6361
public static class bhm
{
	// Token: 0x060086D4 RID: 34516 RVA: 0x0037DAA0 File Offset: 0x0037BCA0
	public static float a(float? A_0, efk A_1)
	{
		float num = (A_0 != null) ? A_0.Value : bhm.a;
		if (A_1 != null)
		{
			e70 e = A_1.Skills.b(typeof(e70)) as e70;
			if (e != null)
			{
				num -= bhm.a(e.g());
			}
		}
		return d05.b(bhm.c, num, bhm.b);
	}

	// Token: 0x060086D5 RID: 34517 RVA: 0x0037DB10 File Offset: 0x0037BD10
	public static float a(int A_0)
	{
		return (float)A_0 * bhm.d;
	}

	// Token: 0x04003443 RID: 13379
	public static readonly float a = 2.5f;

	// Token: 0x04003444 RID: 13380
	public static readonly float b = 3.5f;

	// Token: 0x04003445 RID: 13381
	public static readonly float c = 1.15f;

	// Token: 0x04003446 RID: 13382
	private static readonly float d = 0.01f;
}
