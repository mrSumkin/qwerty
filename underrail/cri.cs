using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x02001FDC RID: 8156
public class cri : t3
{
	// Token: 0x0600BF89 RID: 49033 RVA: 0x00425BA8 File Offset: 0x00423DA8
	public new bool i()
	{
		return this.l;
	}

	// Token: 0x0600BF8A RID: 49034 RVA: 0x00425BB0 File Offset: 0x00423DB0
	public void a(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x0600BF8B RID: 49035 RVA: 0x00425BBC File Offset: 0x00423DBC
	public new string h()
	{
		return this.g;
	}

	// Token: 0x0600BF8C RID: 49036 RVA: 0x00425BC4 File Offset: 0x00423DC4
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600BF8D RID: 49037 RVA: 0x00425BD0 File Offset: 0x00423DD0
	public string k()
	{
		return this.m;
	}

	// Token: 0x0600BF8E RID: 49038 RVA: 0x00425BD8 File Offset: 0x00423DD8
	public void c(string A_0)
	{
		this.m = A_0;
	}

	// Token: 0x0600BF8F RID: 49039 RVA: 0x00425BE4 File Offset: 0x00423DE4
	public string f()
	{
		return this.n;
	}

	// Token: 0x0600BF90 RID: 49040 RVA: 0x00425BEC File Offset: 0x00423DEC
	public void b(string A_0)
	{
		this.n = A_0;
	}

	// Token: 0x0600BF91 RID: 49041 RVA: 0x00425BF8 File Offset: 0x00423DF8
	public Color c()
	{
		return this.b;
	}

	// Token: 0x0600BF92 RID: 49042 RVA: 0x00425C00 File Offset: 0x00423E00
	public void a(Color A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600BF93 RID: 49043 RVA: 0x00425C0C File Offset: 0x00423E0C
	public Color b()
	{
		return this.c;
	}

	// Token: 0x0600BF94 RID: 49044 RVA: 0x00425C14 File Offset: 0x00423E14
	public void b(Color A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600BF95 RID: 49045 RVA: 0x00425C20 File Offset: 0x00423E20
	public Color j()
	{
		return this.d;
	}

	// Token: 0x0600BF96 RID: 49046 RVA: 0x00425C28 File Offset: 0x00423E28
	public new void d(Color A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600BF97 RID: 49047 RVA: 0x00425C34 File Offset: 0x00423E34
	public Color g()
	{
		return this.e;
	}

	// Token: 0x0600BF98 RID: 49048 RVA: 0x00425C3C File Offset: 0x00423E3C
	public void c(Color A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600BF99 RID: 49049 RVA: 0x00425C48 File Offset: 0x00423E48
	public Color? a()
	{
		return this.f;
	}

	// Token: 0x0600BF9A RID: 49050 RVA: 0x00425C50 File Offset: 0x00423E50
	public void a(Color? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600BF9B RID: 49051 RVA: 0x00425C5C File Offset: 0x00423E5C
	public new Point e()
	{
		return this.j;
	}

	// Token: 0x0600BF9C RID: 49052 RVA: 0x00425C64 File Offset: 0x00423E64
	public void a(Point A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600BF9D RID: 49053 RVA: 0x00425C70 File Offset: 0x00423E70
	public new string d()
	{
		return this.k;
	}

	// Token: 0x0600BF9E RID: 49054 RVA: 0x00425C78 File Offset: 0x00423E78
	public new void d(string A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600BF9F RID: 49055 RVA: 0x00425C84 File Offset: 0x00423E84
	public cri()
	{
		e4z.a(this);
	}

	// Token: 0x0600BFA0 RID: 49056 RVA: 0x00425CC4 File Offset: 0x00423EC4
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		Color value;
		if (this.Enabled)
		{
			if (this.IsMousedOver || euz.DesignMode || base.IsFocus)
			{
				value = this.c;
			}
			else
			{
				value = this.b;
			}
		}
		else
		{
			value = this.d;
		}
		cne cne = A_1.a;
		if (cne != null)
		{
			SpriteFont resource = cne.GetResource<SpriteFont>(this.n, null);
			Point point = base.at();
			if (!string.IsNullOrEmpty(this.g))
			{
				Texture2D resource2 = cne.GetResource<Texture2D>(this.g, null);
				if ((this.IsMousedOver || euz.DesignMode || base.IsFocus) && !string.IsNullOrEmpty(this.g) && this.Enabled && resource2 != null)
				{
					as6.a(A_1.b(), resource2, point, base.Size, base.Color, new Point?(this.h), this.i);
				}
			}
			if (resource != null)
			{
				if (this.e != null && this.d != this.e.Value && !string.IsNullOrEmpty(this.m))
				{
					Texture2D resource3 = cne.GetResource<Texture2D>(this.m, null);
					if (resource3 != null)
					{
						int num = Math.Min(this.d, this.e.Value);
						int length = Math.Abs(this.d - this.e.Value);
						string text = base.Text.Substring(0, num);
						string text2 = base.Text.Substring(num, length);
						int num2 = Convert.ToInt32(resource.MeasureString(text).X);
						Point a_ = new Point(point.X + num2, point.Y);
						Vector2 vector = resource.MeasureString(text2);
						esj a_2 = new esj((int)vector.X, (int)vector.Y);
						as6.a(A_1.b(), resource3, a_, a_2, Color.White * 0.5f, null, null);
					}
				}
				string text3;
				if (string.IsNullOrEmpty(base.Text))
				{
					text3 = this.k;
					if (this.f != null)
					{
						value = this.f.Value;
					}
				}
				else
				{
					text3 = base.Text;
				}
				if (!string.IsNullOrEmpty(text3))
				{
					Vector2 a_3 = new Vector2((float)(point.X + this.j.X), (float)(point.Y + this.j.Y));
					A_1.b().xb(resource, text3, a_3, value);
					if (!string.IsNullOrEmpty(this.p) && base.s() == base.Text.Length)
					{
						a_3.X += resource.MeasureString(text3).X;
						A_1.b().xb(resource, this.p, a_3, this.e);
					}
				}
			}
			if (base.IsFocus && this.Enabled && A_0.a().TotalGameTime.Milliseconds % 500 > 250 && resource != null)
			{
				string text4;
				if (!string.IsNullOrEmpty(base.Text))
				{
					text4 = base.Text.Substring(0, base.s());
				}
				else
				{
					text4 = string.Empty;
				}
				string text5;
				if (base.Text == null || base.s() >= base.Text.Length)
				{
					text5 = " ";
				}
				else
				{
					text5 = base.Text.Substring(base.s(), 1);
				}
				Point a_4 = d05.a(point, new Point(this.j.X + (int)resource.MeasureString(text4).X, 2), false);
				esj a_5 = new esj((int)resource.MeasureString(text5).X, base.Size.d - 4);
				if (!string.IsNullOrEmpty(this.m))
				{
					Texture2D resource4 = cne.GetResource<Texture2D>(this.m, null);
					if (resource4 != null)
					{
						as6.a(A_1.b(), resource4, a_4, a_5, Color.White, null, null);
					}
				}
			}
		}
	}

	// Token: 0x0600BFA1 RID: 49057 RVA: 0x00426154 File Offset: 0x00424354
	protected override void h8(object A_0, ane A_1)
	{
		base.h8(A_0, A_1);
		if (A_1 != null && A_1.a >= Keys.NumLock && A_1.a <= Keys.RightAlt)
		{
			return;
		}
		e4z.f();
	}

	// Token: 0x0600BFA2 RID: 49058 RVA: 0x0042618C File Offset: 0x0042438C
	protected override bool ahc()
	{
		if (this.l)
		{
			SpriteFont resource = dr3.a().GetResource<SpriteFont>(this.n, null);
			if (resource != null)
			{
				Vector2 vector = resource.MeasureString(base.Text);
				Vector2 vector2 = resource.MeasureString("W");
				if (vector.X + vector2.X > (float)(base.Size.c - 5 - 2 * this.j.X))
				{
					return true;
				}
			}
			return false;
		}
		return base.ahc();
	}

	// Token: 0x0600BFA3 RID: 49059 RVA: 0x00426218 File Offset: 0x00424418
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		if (this.o != null)
		{
			this.p = this.o(base.Text);
			return;
		}
		this.p = null;
	}

	// Token: 0x040044F4 RID: 17652
	private new const int a = 2;

	// Token: 0x040044F5 RID: 17653
	private new Color b = Color.White;

	// Token: 0x040044F6 RID: 17654
	private new Color c = Color.White;

	// Token: 0x040044F7 RID: 17655
	private new Color d = Color.Gray;

	// Token: 0x040044F8 RID: 17656
	private new Color e = Color.Gray;

	// Token: 0x040044F9 RID: 17657
	private new Color? f;

	// Token: 0x040044FA RID: 17658
	private new string g;

	// Token: 0x040044FB RID: 17659
	public new Point h;

	// Token: 0x040044FC RID: 17660
	public new esj? i;

	// Token: 0x040044FD RID: 17661
	private new Point j;

	// Token: 0x040044FE RID: 17662
	private new string k;

	// Token: 0x040044FF RID: 17663
	private new bool l;

	// Token: 0x04004500 RID: 17664
	private new string m;

	// Token: 0x04004501 RID: 17665
	private string n;

	// Token: 0x04004502 RID: 17666
	public Func<string, string> o;

	// Token: 0x04004503 RID: 17667
	private new string p;
}
