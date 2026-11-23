using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200200C RID: 8204
public abstract class ant : cao, amj
{
	// Token: 0x0600C1BF RID: 49599 RVA: 0x00432770 File Offset: 0x00430970
	protected efk c()
	{
		return this.a;
	}

	// Token: 0x0600C1C0 RID: 49600
	protected abstract bool ln();

	// Token: 0x0600C1C1 RID: 49601
	protected abstract coh lo();

	// Token: 0x0600C1C2 RID: 49602 RVA: 0x00432778 File Offset: 0x00430978
	protected virtual ip as1()
	{
		return null;
	}

	// Token: 0x0600C1C3 RID: 49603 RVA: 0x0043277C File Offset: 0x0043097C
	protected virtual bool lp()
	{
		return false;
	}

	// Token: 0x0600C1C4 RID: 49604 RVA: 0x00432780 File Offset: 0x00430980
	protected ant(efk A_0) : this(A_0, eb1.a, bj8.a)
	{
	}

	// Token: 0x0600C1C5 RID: 49605 RVA: 0x00432798 File Offset: 0x00430998
	protected ant(efk A_0, esj A_1, esj A_2)
	{
		czh.a(A_0, "character");
		this.a = A_0;
		base.Size = A_1;
		this.c = A_2;
		this.b = bd1.a(this, this, null);
	}

	// Token: 0x0600C1C6 RID: 49606 RVA: 0x004327EC File Offset: 0x004309EC
	public override void iv(e6d A_0, cp9 A_1)
	{
		cne service = bpo.GetService<cne>();
		if (service != null)
		{
			Texture2D resource = service.GetResource<Texture2D>(this.d, null);
			Vector2 vector = base.at().b();
			Rectangle rectangle = new Rectangle(0, 0, base.Size.c, base.Size.d);
			if (resource != null)
			{
				rectangle.X = rectangle.Width * 2;
				A_1.b().w5(resource, vector, new Rectangle?(rectangle), new Color(0, 0, 0, 100));
				c3i c3i = this.a();
				if (c3i != null)
				{
					Vector2 vector2 = vector + (base.Size.b() - this.c.b()) / 2f;
					Rectangle a_ = new Rectangle((int)vector2.X, (int)vector2.Y, this.c.c, this.c.d);
					c3i.a(A_1, a_, Color.White, 0, null);
					ejh.a(A_1, a_, this.lo(), Color.White);
				}
				ip ip = this.as1();
				double num = 0.0;
				Color red = adi.b;
				if (base.Pressed)
				{
					rectangle.X = rectangle.Width * 2;
					num = 1.0;
					if (ip != null || this.lp())
					{
						red = Color.Red;
					}
				}
				else if (ip != null)
				{
					num = ip.a / (double)d7f.e;
				}
				if (num != 0.0)
				{
					int num2 = (int)((double)rectangle.Height * num);
					Rectangle a_2 = new Rectangle((int)vector.X, (int)vector.Y + (rectangle.Height - num2), rectangle.Width, num2);
					A_1.b().w6(resource, a_2, new Rectangle?(rectangle), red * 0.4f);
				}
				if (this.ln())
				{
					rectangle.X = rectangle.Width;
					A_1.b().w5(resource, vector, new Rectangle?(rectangle), adi.a);
				}
			}
		}
		this.b.a(A_0);
	}

	// Token: 0x0600C1C7 RID: 49607 RVA: 0x00432A30 File Offset: 0x00430C30
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		this.b();
	}

	// Token: 0x0600C1C8 RID: 49608 RVA: 0x00432A44 File Offset: 0x00430C44
	public ecs yf(euz A_0)
	{
		if (this.lo() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
			return cq4.a(this.lo(), (serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null, false, true, serviceOrThrow2.ak7(), serviceOrThrow2.ak8(), null, null, false);
		}
		return null;
	}

	// Token: 0x0600C1C9 RID: 49609 RVA: 0x00432AB0 File Offset: 0x00430CB0
	private void b()
	{
		if (this.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			int a_;
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				a_ = (int)((double)djp.b * 2.5);
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				a_ = djp.b * 2;
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				a_ = (int)((double)djp.b * 1.5);
			}
			else
			{
				a_ = djp.b;
			}
			this.b.a(a_);
		}
	}

	// Token: 0x0600C1CA RID: 49610 RVA: 0x00432B60 File Offset: 0x00430D60
	private c3i a()
	{
		if (this.lo() != null)
		{
			cne service = bpo.GetService<cne>();
			if (service != null)
			{
				return ejh.a(this.lo(), service);
			}
		}
		return null;
	}

	// Token: 0x0600C1CB RID: 49611 RVA: 0x00432B94 File Offset: 0x00430D94
	protected override void rd(object A_0, b25 A_1)
	{
		base.rd(A_0, A_1);
		this.b.b();
	}

	// Token: 0x0600C1CC RID: 49612 RVA: 0x00432BAC File Offset: 0x00430DAC
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.b.b();
	}

	// Token: 0x0600C1CD RID: 49613 RVA: 0x00432BC4 File Offset: 0x00430DC4
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.b.b();
	}

	// Token: 0x0400462D RID: 17965
	private new efk a;

	// Token: 0x0400462E RID: 17966
	private new dsy b;

	// Token: 0x0400462F RID: 17967
	private new esj c;

	// Token: 0x04004630 RID: 17968
	public new string d = bo1.ad;
}
