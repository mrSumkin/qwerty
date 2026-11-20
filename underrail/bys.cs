using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002050 RID: 8272
public sealed class bys : ao4
{
	// Token: 0x0600C442 RID: 50242 RVA: 0x00442050 File Offset: 0x00440250
	public bys(Point A_0, Rectangle A_1, euz A_2, euz A_3, coh A_4, bool A_5 = false, bool A_6 = false) : base(A_0, A_1, A_2, A_3, A_6)
	{
		this.b = A_5;
		this.a = A_4;
	}

	// Token: 0x0600C443 RID: 50243 RVA: 0x00442074 File Offset: 0x00440274
	protected override List<cao> acl()
	{
		wj wj = wj.a();
		List<cao> list = new List<cao>();
		if (this.a != null && this.a.Definition != null && this.a.Definition.a2().Count > 0)
		{
			foreach (aia aia in this.a.Definition.a2())
			{
				if (aia.Value != null)
				{
					av a_ = ecf.a(aia.Value, new dsx(), this.a);
					eqw eqw;
					if (wj.d == UiSize.Classic)
					{
						eqw = new eqw(this);
					}
					else
					{
						eqw = new eqw(this, wj.n, wj.o);
					}
					eqw.a(a_);
					eqw.p(new EventHandler<b25>(this.a));
					if (this.b)
					{
						eqw.b("Назначить действие: ");
					}
					list.Add(eqw);
				}
			}
		}
		return list;
	}

	// Token: 0x0600C444 RID: 50244 RVA: 0x004421A4 File Offset: 0x004403A4
	private void a(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.d)
		{
			base.b();
			return;
		}
		if (A_1.b() == eoo.b)
		{
			eqw eqw = (eqw)A_0;
			if (eqw.zc() != null)
			{
				if (this.b)
				{
					eb1 eb = base.d() as eb1;
					if (eb != null)
					{
						base.b();
						eb.a(eqw.zc());
						return;
					}
				}
				else if (eqw.zc().yw())
				{
					base.b();
					bpo.GetServiceOrThrow<ps>().amb(eqw.zc());
				}
			}
		}
	}

	// Token: 0x04004787 RID: 18311
	private new coh a;

	// Token: 0x04004788 RID: 18312
	private new bool b;
}
