using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200201F RID: 8223
public sealed class d0p : euz
{
	// Token: 0x0600C2A6 RID: 49830 RVA: 0x0043630C File Offset: 0x0043450C
	public override bool iz(MouseState A_0)
	{
		return false;
	}

	// Token: 0x0600C2A7 RID: 49831 RVA: 0x00436310 File Offset: 0x00434510
	public d0p(bool A_0 = false)
	{
		base.Size = new esj(100, 100);
		this.Gravity = axy.c;
		this.a = A_0;
	}

	// Token: 0x0600C2A8 RID: 49832 RVA: 0x00436338 File Offset: 0x00434538
	public static void a(cp9 A_0, Color A_1, Rectangle A_2, bool A_3, bool A_4 = false)
	{
		cne cne = dr3.a();
		if (cne != null)
		{
			if (A_3)
			{
				int num;
				int y;
				if (A_4)
				{
					num = 4;
					y = (int)((long)TimeSpan.FromTicks(DateTime.Now.Ticks).TotalMilliseconds / 100L) % num;
				}
				else
				{
					num = 0;
					y = 0;
				}
				Texture2D resource = cne.GetResource<Texture2D>(bo1.l, null);
				if (resource != null)
				{
					esj esj = new esj(resource.Width, resource.Height - num);
					int num2 = 0;
					int num3 = 0;
					for (;;)
					{
						Rectangle rectangle = new Rectangle(A_2.X + num2, A_2.Y + num3, Math.Min(esj.c, A_2.Width - num2), Math.Min(esj.d, A_2.Height - num3));
						Rectangle value = new Rectangle(0, y, rectangle.Width, rectangle.Height);
						A_0.b().w6(resource, rectangle, new Rectangle?(value), A_1);
						num2 += esj.c;
						if (num2 >= A_2.Width)
						{
							num2 = 0;
							num3 += esj.d;
							if (num3 >= A_2.Height)
							{
								break;
							}
						}
					}
					return;
				}
			}
			else
			{
				Texture2D resource2 = cne.GetResource<Texture2D>(bo1.k, null);
				if (resource2 != null)
				{
					A_0.b().xa(resource2, A_2, A_1);
				}
			}
		}
	}

	// Token: 0x0600C2A9 RID: 49833 RVA: 0x004364A0 File Offset: 0x004346A0
	public static void a(cp9 A_0, Color A_1, bool A_2, bool A_3 = false)
	{
		esj esj = bpo.GetServiceOrThrow<bef>().k0();
		Rectangle a_ = new Rectangle(0, 0, esj.c, esj.d);
		d0p.a(A_0, A_1, a_, A_2, A_3);
	}

	// Token: 0x0600C2AA RID: 49834 RVA: 0x004364D8 File Offset: 0x004346D8
	public override void iv(e6d A_0, cp9 A_1)
	{
		d0p.a(A_1, base.Color, this.a, false);
	}

	// Token: 0x04004685 RID: 18053
	public new bool a;
}
