using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FFC RID: 8188
public abstract class pm : euz
{
	// Token: 0x0600C118 RID: 49432
	public abstract float wf();

	// Token: 0x0600C119 RID: 49433
	public abstract void wg(float A_0);

	// Token: 0x0600C11A RID: 49434
	public abstract float wh();

	// Token: 0x0600C11B RID: 49435
	public abstract void wi(float A_0);

	// Token: 0x0600C11C RID: 49436
	public abstract float wj();

	// Token: 0x0600C11D RID: 49437
	public abstract void wk(float A_0);

	// Token: 0x0600C11E RID: 49438 RVA: 0x0042EA80 File Offset: 0x0042CC80
	public string e()
	{
		return this.a;
	}

	// Token: 0x0600C11F RID: 49439 RVA: 0x0042EA88 File Offset: 0x0042CC88
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C120 RID: 49440 RVA: 0x0042EA94 File Offset: 0x0042CC94
	public virtual float? aah()
	{
		return null;
	}

	// Token: 0x0600C121 RID: 49441 RVA: 0x0042EAAC File Offset: 0x0042CCAC
	public virtual int? aai()
	{
		return null;
	}

	// Token: 0x0600C122 RID: 49442 RVA: 0x0042EAC4 File Offset: 0x0042CCC4
	public Color d()
	{
		return this.b;
	}

	// Token: 0x0600C123 RID: 49443 RVA: 0x0042EACC File Offset: 0x0042CCCC
	public void a(Color A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600C124 RID: 49444 RVA: 0x0042EAD8 File Offset: 0x0042CCD8
	public bool c()
	{
		return this.c;
	}

	// Token: 0x0600C125 RID: 49445 RVA: 0x0042EAE0 File Offset: 0x0042CCE0
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C126 RID: 49446 RVA: 0x0042EAEC File Offset: 0x0042CCEC
	public int b()
	{
		return this.d;
	}

	// Token: 0x0600C127 RID: 49447 RVA: 0x0042EAF4 File Offset: 0x0042CCF4
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600C128 RID: 49448 RVA: 0x0042EB00 File Offset: 0x0042CD00
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
					int num;
					int width;
					if (this.f != null)
					{
						num = this.f.Value.d;
						width = this.f.Value.c;
					}
					else
					{
						num = resource.Height / 3;
						width = resource.Width;
					}
					Point point = base.at();
					if (this.aah() != null && this.aah().Value < this.wh())
					{
						int num2 = (this.aai() != null) ? this.aai().Value : 0;
						int num3 = Convert.ToInt32(this.wh() / this.aah().Value);
						if (this.c)
						{
							num3 /= 2;
						}
						int num4 = Convert.ToInt32((double)base.Size.c / (double)num3) - num2;
						int num5 = num3 * num4 + num2 * (num3 - 1);
						int num6 = (base.Size.c - num5) / 2;
						Rectangle a_ = new Rectangle(point.X + num6, point.Y, num5, num);
						for (int i = 0; i < num3; i++)
						{
							Rectangle a_2 = new Rectangle(point.X + i * (num4 + num2) + num6, point.Y, num4, num);
							if (this.g)
							{
								pm.a(A_1, resource, this.e, 0, width, num, a_2, Color.White);
							}
							if (this.c)
							{
								if (this.wj() >= (float)num3 + (float)(i + 1) * this.aah().Value)
								{
									pm.a(A_1, resource, this.e, 1, width, num, a_2, base.Color);
								}
								else if (this.wj() >= (float)(i + 1) * this.aah().Value)
								{
									pm.a(A_1, resource, this.e, 1, width, num, a_2, this.b);
								}
							}
							else if (this.wj() >= (float)(i + 1) * this.aah().Value)
							{
								pm.a(A_1, resource, this.e, 1, width, num, a_2, base.Color);
							}
							pm.a(A_1, resource, this.e, 2, width, num, a_2, Color.White);
						}
						pm.a(A_1, resource, this.e, 2, width, num, a_, Color.White);
					}
					else
					{
						Rectangle a_3 = new Rectangle(point.X, point.Y, base.Size.c, num);
						if (this.g)
						{
							pm.a(A_1, resource, this.e, 0, width, num, a_3, Color.White);
						}
						float num7 = this.wh() - this.wf();
						float num8 = this.wj() - this.wf();
						if (num7 != 0f && num8 > 0f)
						{
							float num9 = Math.Max(0f, Math.Min(1f, num8 / num7));
							if (num9 > 0f)
							{
								if (!global::wj.a().c())
								{
									int br = global::wj.a().br;
									int num10 = base.Size.c - 2 * br;
									int width2 = Convert.ToInt32(Math.Max(2f, (float)num10 * num9));
									Rectangle a_4 = new Rectangle(point.X + br, point.Y, width2, num);
									Point a_5 = new Point(this.e.X + br, this.e.Y);
									pm.a(A_1, resource, a_5, 1, width - 2 * br, num, a_4, base.Color);
								}
								else
								{
									int width3 = (int)Math.Max((float)this.d, (float)base.Size.c * num9);
									Rectangle a_6 = new Rectangle(point.X, point.Y, width3, num);
									pm.a(A_1, resource, this.e, 1, width, num, a_6, base.Color);
								}
							}
						}
						pm.a(A_1, resource, this.e, 2, width, num, a_3, Color.White);
					}
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C129 RID: 49449 RVA: 0x0042EF78 File Offset: 0x0042D178
	private static void a(cp9 A_0, Texture2D A_1, Point A_2, int A_3, int A_4, int A_5, Rectangle A_6, Color A_7)
	{
		c4o.a(A_0, A_1, new Rectangle(A_2.X, A_2.Y + A_5 * A_3, A_4, A_5), A_6, A_7);
	}

	// Token: 0x040045DA RID: 17882
	private new string a = bo1.f;

	// Token: 0x040045DB RID: 17883
	private new Color b = Color.White;

	// Token: 0x040045DC RID: 17884
	private new bool c;

	// Token: 0x040045DD RID: 17885
	private new int d;

	// Token: 0x040045DE RID: 17886
	public new Point e;

	// Token: 0x040045DF RID: 17887
	public new esj? f;

	// Token: 0x040045E0 RID: 17888
	public new bool g = true;
}
