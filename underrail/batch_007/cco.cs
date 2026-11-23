using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200204D RID: 8269
public sealed class cco : amm
{
	// Token: 0x0600C41E RID: 50206 RVA: 0x004410FC File Offset: 0x0043F2FC
	public cco()
	{
		esj a_ = a2x.a();
		base.Size = a_;
		this.Focusable = true;
		this.aox(new d0p(false)
		{
			Color = Color.Black
		});
	}

	// Token: 0x0600C41F RID: 50207 RVA: 0x00441140 File Offset: 0x0043F340
	protected override void g6(object A_0, ane A_1)
	{
		base.g6(A_0, A_1);
		base.z();
	}

	// Token: 0x0600C420 RID: 50208 RVA: 0x00441154 File Offset: 0x0043F354
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		Texture2D texture2D = A_1.a.us(bo1.b1, null);
		if (texture2D != null)
		{
			esj esj = a2x.a();
			float num = (float)esj.d * 0.85f / (float)texture2D.Height;
			num = Math.Max(1f, num);
			Rectangle rectangle = default(Rectangle);
			rectangle.Width = Convert.ToInt32(num * (float)texture2D.Width);
			rectangle.Height = Convert.ToInt32(num * (float)texture2D.Height);
			rectangle.X = (esj.c - rectangle.Width) / 2;
			rectangle.Y = (esj.d - rectangle.Height) / 2;
			A_1.b().xa(texture2D, rectangle, Color.White);
		}
	}
}
