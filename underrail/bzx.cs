using System;
using Microsoft.Xna.Framework;

// Token: 0x02000FEC RID: 4076
public sealed class bzx
{
	// Token: 0x060053F5 RID: 21493 RVA: 0x00251D00 File Offset: 0x0024FF00
	public bzx()
	{
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x00251D08 File Offset: 0x0024FF08
	public bzx(byte A_0, byte A_1, Point A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x00251D28 File Offset: 0x0024FF28
	public override bool Equals(object obj)
	{
		bzx bzx = obj as bzx;
		return bzx != null && this.c == bzx.c;
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x00251D58 File Offset: 0x0024FF58
	public override int GetHashCode()
	{
		return this.c.GetHashCode();
	}

	// Token: 0x04002248 RID: 8776
	public byte a;

	// Token: 0x04002249 RID: 8777
	public byte b;

	// Token: 0x0400224A RID: 8778
	public Point c;
}
