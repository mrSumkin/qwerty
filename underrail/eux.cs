using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x020001A3 RID: 419
public class eux : z6
{
	// Token: 0x06000C16 RID: 3094 RVA: 0x00030494 File Offset: 0x0002E694
	public eux(bso A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x000304C4 File Offset: 0x0002E6C4
	public void d1(e6d A_0)
	{
		bbp service = bpo.GetService<bbp>();
		bool flag = service == null || service.get_IsActive() || service.ku();
		if (flag)
		{
			bef service2 = bpo.GetService<bef>();
			if (service2 != null && service2.k2() && this.a.aa2())
			{
				esj esj = service2.k0();
				if (A_0.b().X < 0 || A_0.b().Y < 0 || A_0.b().X >= esj.c || A_0.b().Y >= esj.d)
				{
					Point a_ = new Point(d05.a(0, A_0.b().X, esj.c - 1), d05.a(0, A_0.b().Y, esj.d));
					this.a.abb(a_);
				}
			}
		}
		if (!this.a.aaq())
		{
			return;
		}
		this.a.a(A_0.b());
		this.a.b(A_0.b());
		d1a d1a = this.a;
		if (d1a.aa7() == null && this.a.aaw() != null)
		{
			d1a.aa6();
		}
		if (this.a.aau() != null)
		{
			if (this.a.aam() != null)
			{
				euz euz = this.a.aam().ajs() as euz;
				if (euz != null && !euz.Activated)
				{
					this.a.abc();
				}
			}
			if (this.a.aa7() != null && !this.a.aa7().Activated && this.a.aaw() != null)
			{
				this.a.aa6();
			}
			if (flag)
			{
				this.a.aau().ag5(A_0);
			}
		}
		if (this.a.a() != null && this.a.a().aw() && A_0.b().LeftButton == ButtonState.Released)
		{
			e08 e = this.a.a().ay();
			euz euz2 = e.a() as euz;
			if (e != null && euz2 != null)
			{
				etu a_2 = new etu(e, new Point(A_0.b().X, A_0.b().Y));
				euz2.a(null, a_2);
			}
		}
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x0003077C File Offset: 0x0002E97C
	public Guid qe()
	{
		return this.b;
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00030784 File Offset: 0x0002E984
	public string y8()
	{
		return this.c;
	}

	// Token: 0x0400072A RID: 1834
	private bso a;

	// Token: 0x0400072B RID: 1835
	private Guid b = new Guid("{96F5B0FF-A7AB-4462-8756-7BD85E08F2A9}");

	// Token: 0x0400072C RID: 1836
	private string c = "OuroborosGUILogicProvider";
}
