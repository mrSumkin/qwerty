using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001DC RID: 476
public sealed class box
{
	// Token: 0x06000E00 RID: 3584 RVA: 0x00039D3C File Offset: 0x00037F3C
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00039D44 File Offset: 0x00037F44
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00039D50 File Offset: 0x00037F50
	public string e()
	{
		return this.c;
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00039D58 File Offset: 0x00037F58
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00039D64 File Offset: 0x00037F64
	public Texture2D d()
	{
		return this.b;
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00039D6C File Offset: 0x00037F6C
	public void a(Texture2D A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00039D78 File Offset: 0x00037F78
	public Color a()
	{
		return this.d;
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00039D80 File Offset: 0x00037F80
	public void b(Color A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00039D8C File Offset: 0x00037F8C
	public Color c()
	{
		return this.e;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00039D94 File Offset: 0x00037F94
	public void a(Color A_0)
	{
		this.e = A_0;
	}

	// Token: 0x04000816 RID: 2070
	private bool a;

	// Token: 0x04000817 RID: 2071
	private Texture2D b;

	// Token: 0x04000818 RID: 2072
	private string c = "grid";

	// Token: 0x04000819 RID: 2073
	private Color d = Color.Black;

	// Token: 0x0400081A RID: 2074
	private Color e = Color.Orange;
}
