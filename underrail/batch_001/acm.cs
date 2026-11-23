using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200016E RID: 366
public class acm : aiu
{
	// Token: 0x06000943 RID: 2371 RVA: 0x00026648 File Offset: 0x00024848
	public acm(string A_0, esj A_1, Vector2 A_2, string A_3) : base(A_0)
	{
		string.IsNullOrEmpty(A_3);
		this.c = A_2;
		this.b = A_1;
		base.a(0);
		cne cne = dr3.a();
		if (cne != null)
		{
			try
			{
				this.a = cne.GetResource<Texture2D>(A_3, new double?((double)-1));
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x000266BC File Offset: 0x000248BC
	public override void ob(e6d A_0, cp9 A_1, bool A_2)
	{
		if (this.a != null)
		{
			try
			{
				Rectangle a_ = new Rectangle(A_0.b().X - (int)this.c.X, A_0.b().Y - (int)this.c.Y, this.b.c, this.b.d);
				Rectangle value = new Rectangle(0, 0, this.b.c, this.b.d);
				if (base.a() is int)
				{
					int num = (int)base.a();
					if (A_0.b().LeftButton == ButtonState.Pressed)
					{
						num++;
					}
					value.X = num * this.b.c;
				}
				A_1.b().w6(this.a, a_, new Rectangle?(value), Color.White);
			}
			catch
			{
				if (!this.d)
				{
					this.d = true;
				}
			}
		}
	}

	// Token: 0x040005F1 RID: 1521
	private Texture2D a;

	// Token: 0x040005F2 RID: 1522
	private esj b;

	// Token: 0x040005F3 RID: 1523
	private Vector2 c;

	// Token: 0x040005F4 RID: 1524
	private bool d;
}
