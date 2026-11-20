using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x02002040 RID: 8256
public sealed class em2 : amm
{
	// Token: 0x0600C3B5 RID: 50101 RVA: 0x0043DBB4 File Offset: 0x0043BDB4
	public override void iv(e6d A_0, cp9 A_1)
	{
		Texture2D a_ = A_1.a.us(bo1.m, null);
		Point point = base.at();
		Rectangle a_2 = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
		c4o.b(A_1, a_, em2.a, Point.Zero, a_2, Color.White * 0.75f, true, null);
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C3B6 RID: 50102 RVA: 0x0043DC40 File Offset: 0x0043BE40
	protected override void h8(object A_0, ane A_1)
	{
		base.h8(A_0, A_1);
		if (A_1.a == Keys.Escape)
		{
			base.z();
		}
	}

	// Token: 0x04004735 RID: 18229
	private new static readonly esj a = new esj(48, 48);
}
