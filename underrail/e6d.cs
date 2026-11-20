using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x02000116 RID: 278
public sealed class e6d
{
	// Token: 0x060006BB RID: 1723 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
	public GameTime a()
	{
		return this.a;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x0001C5CC File Offset: 0x0001A7CC
	public MouseState b()
	{
		return this.b;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x0001C5D4 File Offset: 0x0001A7D4
	public KeyboardState c()
	{
		return this.c;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x0001C5DC File Offset: 0x0001A7DC
	public e6d(GameTime A_0, MouseState A_1, KeyboardState A_2)
	{
		this.b = A_1;
		this.c = A_2;
		this.a = A_0;
	}

	// Token: 0x0400052A RID: 1322
	private GameTime a;

	// Token: 0x0400052B RID: 1323
	private MouseState b;

	// Token: 0x0400052C RID: 1324
	private KeyboardState c;

	// Token: 0x0400052D RID: 1325
	public bool d = true;
}
