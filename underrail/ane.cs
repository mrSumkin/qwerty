using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200019A RID: 410
public class ane : EventArgs
{
	// Token: 0x06000BD9 RID: 3033 RVA: 0x00030024 File Offset: 0x0002E224
	public ane()
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x0003002C File Offset: 0x0002E22C
	public ane(Keys A_0, IEnumerable<Keys> A_1, bool A_2 = false) : this()
	{
		this.a = A_0;
		this.c = A_2;
		if (A_1 != null)
		{
			this.b = new List<Keys>(A_1);
			return;
		}
		this.b = new List<Keys>();
	}

	// Token: 0x04000712 RID: 1810
	public Keys a;

	// Token: 0x04000713 RID: 1811
	public List<Keys> b;

	// Token: 0x04000714 RID: 1812
	public bool c;
}
