using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x020016E7 RID: 5863
[eiz("SPA")]
[Serializable]
public sealed class n2 : a6k, ISerializable
{
	// Token: 0x06007F78 RID: 32632 RVA: 0x0035FBA0 File Offset: 0x0035DDA0
	private n2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F79 RID: 32633 RVA: 0x0035FBAC File Offset: 0x0035DDAC
	public n2()
	{
	}

	// Token: 0x06007F7A RID: 32634 RVA: 0x0035FBB8 File Offset: 0x0035DDB8
	protected override dc4 dt()
	{
		ps service = bpo.GetService<ps>();
		c5x c5x = base.vg().h() as c5x;
		if (service == null || base.vg().q() == null || base.vg().q().j != cgy.b || base.vg().q().i.b == null || c5x == null || c5x.j != cgy.b || c5x.h.b == null)
		{
			return dc4.e;
		}
		if (!b87.a(base.vg().e().b8(), c5x.h.b.aa()))
		{
			bmj.a(base.vg().q(), new ccq(ScrollingCombatTextOptions.Mandatory, "Недостаточно навыка.", adi.l, null, false));
			a7v.a(new h0("Недостаточно навыка кражи.", new Color?(adi.l)));
			return dc4.e;
		}
		if (c5x != null && c5x.h.b != null)
		{
			for (int i = c5x.h.b.aa().Bag.z2().Count - 1; i >= 0; i--)
			{
				coh coh = c5x.h.b.aa().Bag.z2()[i];
				if (coh.Definition is dgr && coh.Stacks > 20)
				{
					coh coh2 = coh.fy();
					coh2.Stacks = coh.Stacks - 20;
					coh.Stacks = 20;
					c5x.h.b.aa().Bag.z2().Insert(i, coh2);
					i++;
				}
			}
		}
		rc rc = new rc(base.vg().q().h.b, c5x.h.b);
		rc.l(new EventHandler<EventArgs>(this.a));
		base.vg().q().i.b.a(rc, atp.a, true, false);
		service.am8(base.vg().q(), c5x.h.b, rc);
		return dc4.c;
	}

	// Token: 0x06007F7B RID: 32635 RVA: 0x0035FDF4 File Offset: 0x0035DFF4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.c;
	}

	// Token: 0x06007F7C RID: 32636 RVA: 0x0035FDF8 File Offset: 0x0035DFF8
	[dcc("SPA:mOIAC")]
	private void a(object A_0, EventArgs A_1)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.am9();
		}
	}
}
