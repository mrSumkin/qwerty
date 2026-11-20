using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200207A RID: 8314
public sealed class ac9 : amm
{
	// Token: 0x0600C68C RID: 50828 RVA: 0x00457B20 File Offset: 0x00455D20
	public ac9(Vector3 A_0)
	{
		this.b();
		this.h = A_0;
	}

	// Token: 0x0600C68D RID: 50829 RVA: 0x00457B38 File Offset: 0x00455D38
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.g == null)
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.n, null);
			c4o.b(A_1, resource, new esj(resource.Width / 3, resource.Height / 3), Point.Zero, new Rectangle(base.Location.X, base.Location.Y, base.Size.c, base.Size.d), base.Color, true, null);
			Texture2D resource2 = A_1.a.GetResource<Texture2D>(bo1.w, null);
			c4o.b(A_1, resource2, new esj(resource2.Width / 3, resource2.Height / 3), Point.Zero, this.f, base.Color, true, null);
			bef serviceOrThrow = bpo.GetServiceOrThrow<bef>();
			this.d.iv(A_0, A_1);
			A_1.a();
			this.g = serviceOrThrow.lb();
			A_1.a(null);
		}
		A_1.b().xa(this.g, new Rectangle(0, 0, base.Size.c, base.Size.d), Color.White);
		Texture2D resource3 = A_1.a.GetResource<Texture2D>(bo1.aq, null);
		esj esj = a2x.a();
		Point point = this.d.a(this.h.X, this.h.Y, this.h.Z);
		Point point2 = new Point((int)((float)point.X - (float)((esj.c - this.i.c) / 2) * this.d.y), (int)((float)point.Y - (float)((esj.d - this.i.d) / 2) * this.d.y));
		A_1.b().xa(resource3, new Rectangle(point2.X, point2.Y, (int)((float)esj.c * this.d.y), (int)((float)esj.d * this.d.y)), adi.c);
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C68E RID: 50830 RVA: 0x00457D84 File Offset: 0x00455F84
	private void b()
	{
		base.Size = a2x.a();
		this.f = new Rectangle(base.Location.X + -20, base.Location.Y + 20, base.Size.c - -40, base.Size.d - 100);
		this.a();
		this.i = ((av0)this.d.m()).a;
		this.e = new dak();
		this.e.Location = new Point(base.Size.c - 200, base.Size.d - 60);
		this.e.Size = new esj(180, 40);
		this.e.Font = egg.b;
		this.e.d = bo1.z;
		this.e.g = adi.a;
		this.e.j = adi.b;
		this.e.TextLabelOffset = new Point(0, 6);
		this.e.Text = "Закрыть";
		this.e.c(new EventHandler<b25>(this.a));
		this.aox(this.e);
	}

	// Token: 0x0600C68F RID: 50831 RVA: 0x00457ED8 File Offset: 0x004560D8
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		li serviceOrThrow2 = bpo.GetServiceOrThrow<li>();
		this.d = new mv(serviceOrThrow2.ka());
		this.d.b(true);
		this.d.Gravity = axy.b;
		this.d.aoa(new bw7());
		this.d.an9().t9(false);
		this.d.an9().t5(new Vector2(0f, 0f));
		this.d.an9().t7(new Vector2(1f, 1f));
		this.d.an9().ub(0.25f);
		this.d.d.a(false);
		this.d.e.a = false;
		this.d.c = serviceOrThrow.aqu().v().a();
		this.d.h.a = edg.b;
		this.d.g.a(brh.a);
		this.d.g.b = brh.c;
		this.d.ap = cxc.b();
		if (serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
		{
			this.d.an0(serviceOrThrow.aqu().v().b().Area);
			this.d.an9().t7(new Vector2((float)this.d.anz().Size.c, (float)this.d.anz().Size.d));
			this.d.an9().t2(new Vector3((float)this.d.anz().Size.c / 2f, (float)this.d.anz().Size.d / 2f, 0f));
			this.d.Location = new Point(this.f.X, this.f.Y);
			this.d.Size = new esj(this.f.Width, this.f.Height);
		}
		this.d.f();
		this.d.Visible = false;
		this.aox(this.d);
	}

	// Token: 0x0600C690 RID: 50832 RVA: 0x00458160 File Offset: 0x00456360
	private void a(object A_0, b25 A_1)
	{
		base.z();
	}

	// Token: 0x0600C691 RID: 50833 RVA: 0x00458168 File Offset: 0x00456368
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (A_1.b() == eoo.b && this.d != null && A_1.a().Y > 25 && A_1.a().Y < base.Size.d - 85)
		{
			this.h = new Vector3(d05.b(0f, this.d.an3().X, (float)this.d.anz().Size.c), d05.b(0f, this.d.an3().Y, (float)this.d.anz().Size.d), 0f);
			bpo.GetServiceOrThrow<ps>().amt(this.d.anz(), this.h, true, null);
		}
	}

	// Token: 0x04004913 RID: 18707
	private new const int a = -20;

	// Token: 0x04004914 RID: 18708
	private new const int b = 20;

	// Token: 0x04004915 RID: 18709
	private new const int c = 80;

	// Token: 0x04004916 RID: 18710
	private new mv d;

	// Token: 0x04004917 RID: 18711
	private new dak e;

	// Token: 0x04004918 RID: 18712
	private new Rectangle f;

	// Token: 0x04004919 RID: 18713
	private new Texture2D g;

	// Token: 0x0400491A RID: 18714
	private Vector3 h;

	// Token: 0x0400491B RID: 18715
	private esj i;
}
