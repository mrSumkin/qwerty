using System;

// Token: 0x020000DC RID: 220
public sealed class ca0
{
	// Token: 0x060004C9 RID: 1225 RVA: 0x00015ACC File Offset: 0x00013CCC
	internal ca0(long A_0)
	{
		this.b = A_0;
		this.c = (int)(this.b % eh9.d);
		this.d = (int)(this.b / eh9.d);
	}

	// Token: 0x04000469 RID: 1129
	[ThreadStatic]
	public static ca0 a;

	// Token: 0x0400046A RID: 1130
	public long b;

	// Token: 0x0400046B RID: 1131
	public int c;

	// Token: 0x0400046C RID: 1132
	public int d;
}
