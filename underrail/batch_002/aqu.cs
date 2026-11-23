using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002076 RID: 8310
public sealed class aqu : amm
{
	// Token: 0x0600C678 RID: 50808 RVA: 0x00456D88 File Offset: 0x00454F88
	public override bool hh()
	{
		return true;
	}

	// Token: 0x0600C679 RID: 50809 RVA: 0x00456D8C File Offset: 0x00454F8C
	public aqu(c5x A_0, b14 A_1, Point? A_2, string A_3)
	{
		this.b = A_0;
		this.c = A_1;
		this.d = A_2;
		this.e = A_3;
		this.a();
	}

	// Token: 0x0600C67A RID: 50810 RVA: 0x00456DB8 File Offset: 0x00454FB8
	public override void iv(e6d A_0, cp9 A_1)
	{
		Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.ay, null);
		Vector2 vector = base.at().b();
		if (resource != null)
		{
			A_1.b().w5(resource, vector, new Rectangle?(new Rectangle(0, 0, 600, 450)), Color.White);
		}
		base.iv(A_0, A_1);
		if (resource != null)
		{
			A_1.b().w5(resource, vector, new Rectangle?(new Rectangle(0, 450, 600, 450)), Color.White);
			if (this.c == b14.a)
			{
				A_1.b().w5(resource, vector, new Rectangle?(new Rectangle(600, 0, 600, 450)), Color.White * 0.5f);
				A_1.b().w5(resource, vector, new Rectangle?(new Rectangle(600, 450, 600, 450)), Color.White * 0.85f);
			}
			if (this.e != null)
			{
				SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(egg.a, null);
				if (resource2 != null)
				{
					Vector2 vector2 = resource2.MeasureString(this.e);
					A_1.b().xb(resource2, this.e, new Vector2(vector.X + (float)base.Size.c - 50f - vector2.X, vector.Y + (float)base.Size.d - 40f - vector2.Y), ((this.c == b14.a) ? aqu.a : Color.White) * 0.85f);
				}
			}
		}
	}

	// Token: 0x0600C67B RID: 50811 RVA: 0x00456F84 File Offset: 0x00455184
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		li serviceOrThrow2 = bpo.GetServiceOrThrow<li>();
		base.Size = new esj(600, 450);
		this.f = new mv(serviceOrThrow2.ka());
		this.f.Size = new esj(580, 430);
		this.f.Location = new Point(10, 10);
		this.f.an0(this.b.Area);
		this.f.aoa(new bw7());
		this.f.an9().t9(true);
		this.f.an9().t5(new Vector2(0f, 0f));
		this.f.an9().t7(new Vector2((float)this.b.Area.Size.c, (float)this.b.Area.Size.d));
		if (this.d != null)
		{
			this.f.an9().t2(new Vector3((float)this.d.Value.X, (float)this.d.Value.Y, 0f));
		}
		else
		{
			this.f.an9().t2(new Vector3(this.b.Location.X, this.b.Location.Y, 0f));
		}
		this.f.d.a(false);
		this.f.d.c(false);
		this.f.c = serviceOrThrow.aqu().v().a();
		this.f.h.a = edg.b;
		this.f.e.a = false;
		if (this.c == b14.a)
		{
			if (serviceOrThrow != null && serviceOrThrow.aq1() != null && serviceOrThrow.aq1().g().f == TimelapseShader.Advanced)
			{
				this.f.h = true;
			}
			else
			{
				this.f.i = new Color?(new Color(100, 255, 100));
			}
		}
		if (this.c == b14.c)
		{
			this.f.g = true;
		}
		this.f.p(new EventHandler<b25>(this.a));
		this.aox(this.f);
	}

	// Token: 0x0600C67C RID: 50812 RVA: 0x00457210 File Offset: 0x00455410
	private void a(object A_0, b25 A_1)
	{
		base.z();
	}

	// Token: 0x0600C67D RID: 50813 RVA: 0x00457218 File Offset: 0x00455418
	protected override void i0()
	{
		this.f.f();
	}

	// Token: 0x0600C67E RID: 50814 RVA: 0x00457228 File Offset: 0x00455428
	protected override Rectangle rv()
	{
		Point point = base.at();
		return new Rectangle(point.X + 10, point.Y + 10, base.Size.c - 20, base.Size.d - 20);
	}

	// Token: 0x040048F3 RID: 18675
	private new static readonly Color a = new Color(75, 255, 75);

	// Token: 0x040048F4 RID: 18676
	private new c5x b;

	// Token: 0x040048F5 RID: 18677
	private new b14 c;

	// Token: 0x040048F6 RID: 18678
	private new Point? d;

	// Token: 0x040048F7 RID: 18679
	private new string e;

	// Token: 0x040048F8 RID: 18680
	private new mv f;
}
