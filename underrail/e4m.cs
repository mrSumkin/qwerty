using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001E4 RID: 484
public sealed class e4m : chf
{
	// Token: 0x06000E24 RID: 3620 RVA: 0x00039ED8 File Offset: 0x000380D8
	Texture2D chf.a()
	{
		return this.a;
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00039EE0 File Offset: 0x000380E0
	public e4m(Texture2D A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00039EF8 File Offset: 0x000380F8
	public void avv(cp9 A_0, a2f A_1, bkx A_2)
	{
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00039EFC File Offset: 0x000380FC
	public void avw(cp9 A_0, Rectangle A_1, Rectangle A_2, Color A_3, float A_4, Vector2 A_5, SpriteEffects A_6, float A_7, byte A_8, Vector2 A_9)
	{
		if (A_0 != null && this.a != null)
		{
			A_0.b().w8(this.a, A_1, new Rectangle?(A_2), A_3, A_4, A_5, A_6, A_7, A_8, A_9);
		}
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00039F40 File Offset: 0x00038140
	public a2f[] acn()
	{
		return null;
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00039F44 File Offset: 0x00038144
	public void aco(Vector2 A_0, float A_1, esj A_2)
	{
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00039F48 File Offset: 0x00038148
	public chf acm(a2f A_0)
	{
		return new e4m(this.a, this.b);
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00039F5C File Offset: 0x0003815C
	public void acp(Vector2 A_0)
	{
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00039F60 File Offset: 0x00038160
	public void acq()
	{
	}

	// Token: 0x0400082E RID: 2094
	public Texture2D a;

	// Token: 0x0400082F RID: 2095
	public string b;
}
