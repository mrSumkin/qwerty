using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200204C RID: 8268
public abstract class ao4 : euz
{
	// Token: 0x0600C410 RID: 50192 RVA: 0x004408E8 File Offset: 0x0043EAE8
	protected euz d()
	{
		return this.j;
	}

	// Token: 0x0600C411 RID: 50193 RVA: 0x004408F4 File Offset: 0x0043EAF4
	protected ao4(Point A_0, Rectangle A_1, euz A_2, euz A_3, bool A_4)
	{
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			this.n = wj.f;
			this.c = new Rectangle(wj.bu.X, wj.bu.Y, 2 * wj.bv, 2 * wj.bv);
			this.d = new Rectangle(wj.bu.X + wj.bv * 2, wj.bu.Y, 2 * wj.bv, 2 * wj.bv);
			this.f = wj.bv;
			this.e = new Point(this.f, this.f);
			this.g = wj.bw;
			this.m = wj.o;
		}
		this.j = A_2;
		this.k = A_3;
		this.l = A_4;
		base.Size = new esj(this.c.Width, this.c.Height);
		Point point = new Point(A_0.X - this.f, A_0.Y - this.f);
		if (point.X + base.Size.c >= A_1.Right)
		{
			point.X = A_1.Right - base.Size.c;
		}
		if (point.Y + base.Size.d >= A_1.Bottom)
		{
			point.Y = A_1.Bottom - base.Size.d;
		}
		if (point.X < A_1.Left)
		{
			point.X = A_1.Left;
		}
		if (point.Y < A_1.Top)
		{
			point.Y = A_1.Top;
		}
		base.Location = point;
		this.h = new Vector2((float)(base.Location.X + this.f), (float)(base.Location.Y + this.f));
	}

	// Token: 0x0600C412 RID: 50194 RVA: 0x00440B6C File Offset: 0x0043ED6C
	public override void iv(e6d A_0, cp9 A_1)
	{
		Texture2D resource = A_1.a.GetResource<Texture2D>(this.n, null);
		if (resource != null)
		{
			Point a_ = base.at();
			Vector2 vector = this.e.b();
			Vector2 a_2 = a_.b() + vector;
			A_1.b().w7(resource, a_2, new Rectangle?(this.c), Color.White * 0.8f, 0f, vector, 1f, SpriteEffects.None, 0f);
			foreach (cao cao in Enumerable.OfType<cao>(base.Controls))
			{
				if (cao.Tag is float)
				{
					float degrees = (float)cao.Tag;
					if (cao.IsMousedOver)
					{
						eqw eqw = cao as eqw;
						Color darkRed;
						if (eqw != null && (eqw.zc() == null || !eqw.zc().yw()))
						{
							darkRed = Color.DarkRed;
						}
						else if (cao.Pressed)
						{
							darkRed = adi.c;
						}
						else
						{
							darkRed = adi.a;
						}
						A_1.b().w7(resource, a_2, new Rectangle?(this.d), darkRed * 0.4f, MathHelper.ToRadians(degrees), vector, 1f, SpriteEffects.None, 0f);
						break;
					}
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C413 RID: 50195 RVA: 0x00440D08 File Offset: 0x0043EF08
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (base.Parent != null)
		{
			if (!this.iz(A_0.b()))
			{
				this.b();
				return;
			}
			if (Vector2.Distance(new Vector2((float)A_0.b().X, (float)A_0.b().Y), this.h) > (float)this.f)
			{
				this.b();
			}
		}
	}

	// Token: 0x0600C414 RID: 50196 RVA: 0x00440D80 File Offset: 0x0043EF80
	public void b()
	{
		base.Parent.g(this);
	}

	// Token: 0x0600C415 RID: 50197 RVA: 0x00440D94 File Offset: 0x0043EF94
	public void c()
	{
		Point point = base.at();
		bpo.GetServiceOrThrow<d1a>().abb(new Point(point.X + this.f, point.Y + this.f));
	}

	// Token: 0x0600C416 RID: 50198
	protected abstract List<cao> acl();

	// Token: 0x0600C417 RID: 50199 RVA: 0x00440DD4 File Offset: 0x0043EFD4
	protected override void i0()
	{
		base.i0();
		if (this.k != null)
		{
			this.k.w(new EventHandler<c1>(this.a));
			amm amm = this.k as amm;
			if (amm != null)
			{
				amm.a(new EventHandler<ddj>(this.a));
			}
		}
		this.a();
	}

	// Token: 0x0600C418 RID: 50200 RVA: 0x00440E34 File Offset: 0x0043F034
	protected override void i1()
	{
		base.i1();
		if (this.k != null)
		{
			this.k.n(new EventHandler<c1>(this.a));
			amm amm = this.j as amm;
			if (amm != null)
			{
				amm.b(new EventHandler<ddj>(this.a));
			}
		}
	}

	// Token: 0x0600C419 RID: 50201 RVA: 0x00440E90 File Offset: 0x0043F090
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			this.b();
			return;
		}
		if (Vector2.Distance(new Vector2((float)A_1.a().X, (float)A_1.a().Y), this.h) < (float)this.g)
		{
			this.b();
		}
	}

	// Token: 0x0600C41A RID: 50202 RVA: 0x00440EF4 File Offset: 0x0043F0F4
	private void a(object A_0, ddj A_1)
	{
		this.b();
	}

	// Token: 0x0600C41B RID: 50203 RVA: 0x00440EFC File Offset: 0x0043F0FC
	private void a(object A_0, c1 A_1)
	{
		this.b();
	}

	// Token: 0x0600C41C RID: 50204 RVA: 0x00440F08 File Offset: 0x0043F108
	private void a(object A_0, b25 A_1)
	{
		eqw eqw = A_0 as eqw;
		if (eqw != null && eqw.Pressed && eqw.zc() != null && eqw.zc().p() != null && eqw.PressedDuration >= wj.b)
		{
			chr service = bpo.GetService<chr>();
			if (service != null && service.ax() == null)
			{
				e08 a_ = new e08(this, new aui(eqw.zc(), eqw.aj9()), TimelapseCursor.ItemDrag.ToString());
				service.az(a_);
				eqw.Pressed = false;
			}
		}
	}

	// Token: 0x0600C41D RID: 50205 RVA: 0x00440FA8 File Offset: 0x0043F1A8
	private void a()
	{
		if (this.i)
		{
			return;
		}
		List<cao> list = this.acl();
		if (list.Count > 0)
		{
			int num = (list.Count % 2 != 0) ? (list.Count + 1) : list.Count;
			float num2 = (float)(-360 / num);
			float num3 = 0f;
			for (int i = 0; i < list.Count; i++)
			{
				Vector2 vector = new Vector2((float)(this.g + (this.f - this.g) / 2), 0f);
				if (num3 != 0f)
				{
					vector = Vector2.Transform(vector, Matrix.CreateRotationZ(MathHelper.ToRadians(num3)));
				}
				cao cao = list[i];
				cao.Location = new Point(this.e.X + (int)vector.X - cao.Size.c / 2, this.e.Y + (int)vector.Y - cao.Size.d / 2);
				cao.Tag = num3;
				if (this.l)
				{
					cao.g(new EventHandler<b25>(this.a));
				}
				this.aox(cao);
				num3 += num2;
			}
		}
		this.i = true;
	}

	// Token: 0x04004766 RID: 18278
	private new const float a = 0.8f;

	// Token: 0x04004767 RID: 18279
	private new const float b = 0.4f;

	// Token: 0x04004768 RID: 18280
	private new Rectangle c = new Rectangle(0, 41, 151, 151);

	// Token: 0x04004769 RID: 18281
	private new Rectangle d = new Rectangle(151, 41, 151, 151);

	// Token: 0x0400476A RID: 18282
	private new Point e = new Point(75, 75);

	// Token: 0x0400476B RID: 18283
	private new int f = 75;

	// Token: 0x0400476C RID: 18284
	private new int g = 25;

	// Token: 0x0400476D RID: 18285
	private Vector2 h;

	// Token: 0x0400476E RID: 18286
	private bool i;

	// Token: 0x0400476F RID: 18287
	private new euz j;

	// Token: 0x04004770 RID: 18288
	private new euz k;

	// Token: 0x04004771 RID: 18289
	private new bool l;

	// Token: 0x04004772 RID: 18290
	protected new esj m;

	// Token: 0x04004773 RID: 18291
	public string n = bo1.ad;
}
