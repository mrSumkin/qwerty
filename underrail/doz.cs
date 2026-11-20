using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002022 RID: 8226
public sealed class doz : cao
{
	// Token: 0x0600C2B8 RID: 49848 RVA: 0x004366D8 File Offset: 0x004348D8
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600C2B9 RID: 49849 RVA: 0x004366E0 File Offset: 0x004348E0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C2BA RID: 49850 RVA: 0x004366EC File Offset: 0x004348EC
	public Point c()
	{
		return this.b;
	}

	// Token: 0x0600C2BB RID: 49851 RVA: 0x004366F4 File Offset: 0x004348F4
	public void a(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600C2BC RID: 49852 RVA: 0x00436700 File Offset: 0x00434900
	public c9j d()
	{
		return this.c;
	}

	// Token: 0x0600C2BD RID: 49853 RVA: 0x00436708 File Offset: 0x00434908
	public void a(c9j A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C2BE RID: 49854 RVA: 0x00436714 File Offset: 0x00434914
	public Color a()
	{
		return this.d;
	}

	// Token: 0x0600C2BF RID: 49855 RVA: 0x0043671C File Offset: 0x0043491C
	public void a(Color A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600C2C0 RID: 49856 RVA: 0x00436728 File Offset: 0x00434928
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cne service = bpo.GetService<cne>();
			if (service != null)
			{
				Texture2D resource = service.GetResource<Texture2D>(this.a, null);
				if (resource != null)
				{
					Point point = base.at();
					int num = 0;
					if (this.Enabled)
					{
						if (base.Checked && (this.d() & c9j.d) == c9j.d)
						{
							num = 1;
						}
						else if (this.IsMousedOver && (this.d() & c9j.c) == c9j.c)
						{
							num = 1;
						}
						else if (base.Pressed && (this.d() & c9j.b) == c9j.b)
						{
							num = 1;
						}
					}
					Rectangle value = new Rectangle(this.b.X, this.b.Y + num * base.Size.d, base.Size.c, base.Size.d);
					A_1.b().w5(resource, new Vector2((float)point.X, (float)point.Y), new Rectangle?(value), this.Enabled ? base.Color : this.a());
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x04004688 RID: 18056
	private new string a;

	// Token: 0x04004689 RID: 18057
	private new Point b;

	// Token: 0x0400468A RID: 18058
	private new c9j c = c9j.b | c9j.d;

	// Token: 0x0400468B RID: 18059
	private new Color d = Color.White;
}
