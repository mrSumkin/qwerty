using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200204B RID: 8267
public sealed class exj : ao4, amj
{
	// Token: 0x0600C408 RID: 50184 RVA: 0x00440444 File Offset: 0x0043E644
	public exj(Point A_0, Rectangle A_1, euz A_2, euz A_3, bim A_4) : base(A_0, A_1, A_2, A_3, false)
	{
		this.a = new EntityAspectReference<bim, bim>(A_4);
	}

	// Token: 0x0600C409 RID: 50185 RVA: 0x00440478 File Offset: 0x0043E678
	protected override List<cao> acl()
	{
		wj wj = wj.a();
		List<cao> list = new List<cao>();
		if (this.a.ao() != null)
		{
			avd[] array = this.a.ao().jz();
			if (array != null && array.Length != 0)
			{
				this.b = new Dictionary<cao, avd>();
				this.c = new Dictionary<cao, dsy>();
				Point point = base.at();
				Rectangle value = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
				foreach (avd avd in array)
				{
					bi bi;
					if (wj.d == UiSize.Classic)
					{
						bi = new bi(avd.a, avd.a, avd.a, null, null);
					}
					else
					{
						bi = new bi(avd.a, avd.a, avd.a, null, new esj?(wj.o));
					}
					bi.p(new EventHandler<b25>(this.d));
					bi.j(new EventHandler<b25>(this.a));
					bi.g(new EventHandler<b25>(this.b));
					bi.l(new EventHandler<b25>(this.c));
					this.b[bi] = avd;
					this.c.Add(bi, new dsy(bi, this, djp.a, djp.b, new Rectangle?(value), null, djp.c, false, false));
					list.Add(bi);
				}
			}
		}
		return list;
	}

	// Token: 0x0600C40A RID: 50186 RVA: 0x00440628 File Offset: 0x0043E828
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		foreach (dsy dsy in this.c.Values)
		{
			dsy.a(A_0);
		}
	}

	// Token: 0x0600C40B RID: 50187 RVA: 0x0044068C File Offset: 0x0043E88C
	public ecs yf(euz A_0)
	{
		cao cao = A_0 as cao;
		if (cao != null)
		{
			avd avd;
			this.b.TryGetValue(cao, out avd);
			if (avd != null)
			{
				ecs ecs = new ecs();
				dl6 dl = new dl6();
				dl.a.Add(new bph(new d22(cq4.d(), adi.c), avd.c, null));
				ecs.a.Add(dl);
				ecs.a.Add(cq4.a());
				ecs.a.Add(cq4.a(avd.d, Color.White, null));
				return ecs;
			}
		}
		return null;
	}

	// Token: 0x0600C40C RID: 50188 RVA: 0x00440728 File Offset: 0x0043E928
	private void d(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.d)
		{
			base.b();
			return;
		}
		if (A_1.b() == eoo.b)
		{
			if (this.a.ao() != null && this.a.ao().a8() != null && this.a.ao().a8().Zone != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x.k.b != null)
					{
						avd avd;
						this.b.TryGetValue(A_0 as cao, out avd);
						if (avd != null)
						{
							c5x.k.b.b(this.a.ao().a8(), this.a.ao().t(), 1, this.a.ao().y(), avd.b);
						}
					}
				}
			}
			base.b();
		}
	}

	// Token: 0x0600C40D RID: 50189 RVA: 0x00440858 File Offset: 0x0043EA58
	private void c(object A_0, b25 A_1)
	{
		dsy dsy;
		this.c.TryGetValue(A_0 as cao, out dsy);
		if (dsy != null)
		{
			dsy.b();
		}
	}

	// Token: 0x0600C40E RID: 50190 RVA: 0x00440888 File Offset: 0x0043EA88
	private void b(object A_0, b25 A_1)
	{
		dsy dsy;
		this.c.TryGetValue(A_0 as cao, out dsy);
		if (dsy != null)
		{
			dsy.b();
		}
	}

	// Token: 0x0600C40F RID: 50191 RVA: 0x004408B8 File Offset: 0x0043EAB8
	private void a(object A_0, b25 A_1)
	{
		dsy dsy;
		this.c.TryGetValue(A_0 as cao, out dsy);
		if (dsy != null)
		{
			dsy.b();
		}
	}

	// Token: 0x04004763 RID: 18275
	private new EntityAspectReference<bim, bim> a;

	// Token: 0x04004764 RID: 18276
	private new Dictionary<cao, avd> b = new Dictionary<cao, avd>();

	// Token: 0x04004765 RID: 18277
	private new Dictionary<cao, dsy> c = new Dictionary<cao, dsy>();
}
