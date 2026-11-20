using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200200D RID: 8205
public sealed class cqn : eb1, ta
{
	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x0600C1CE RID: 49614 RVA: 0x00432BDC File Offset: 0x00430DDC
	public override av Proxy
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x0600C1CF RID: 49615 RVA: 0x00432BE4 File Offset: 0x00430DE4
	// (set) Token: 0x0600C1D0 RID: 49616 RVA: 0x00432BEC File Offset: 0x00430DEC
	public bool Locked
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x0600C1D1 RID: 49617 RVA: 0x00432BF8 File Offset: 0x00430DF8
	public coh Item
	{
		get
		{
			if (this.a != null)
			{
				return this.a.b9() as coh;
			}
			return null;
		}
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x0600C1D2 RID: 49618 RVA: 0x00432C18 File Offset: 0x00430E18
	public bool CanTarget
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x0600C1D3 RID: 49619 RVA: 0x00432C1C File Offset: 0x00430E1C
	public override bool ForceProvidesCursor
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x0600C1D4 RID: 49620 RVA: 0x00432C20 File Offset: 0x00430E20
	protected override bool DrawSubCapabilityIconOnItems
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600C1D5 RID: 49621 RVA: 0x00432C24 File Offset: 0x00430E24
	public cqn()
	{
	}

	// Token: 0x0600C1D6 RID: 49622 RVA: 0x00432C2C File Offset: 0x00430E2C
	public cqn(esj A_0, esj A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600C1D7 RID: 49623 RVA: 0x00432C38 File Offset: 0x00430E38
	public override bool iq(e08 A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		coh coh = A_0.c() as coh;
		return (coh != null && coh.Definition.a2().Count > 0) || A_0.c() is av || A_0.c() is aui;
	}

	// Token: 0x0600C1D8 RID: 49624 RVA: 0x00432C98 File Offset: 0x00430E98
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (this.a != null)
		{
			coh coh = this.a.b9() as coh;
			if (coh != null && this.a.b8().a(coh.Id) != coh)
			{
				base.a(null);
			}
		}
	}

	// Token: 0x0600C1D9 RID: 49625 RVA: 0x00432CF4 File Offset: 0x00430EF4
	protected override void ag6(object A_0, etu A_1)
	{
		try
		{
			if (A_1.b() != null && A_1.b().a() != this)
			{
				coh coh = A_1.b().c() as coh;
				if (coh != null && coh.Definition.a2().Count > 0)
				{
					base.a(ecf.a(coh.Definition.a2()[0].Value, new dsx(), coh));
					e4z.c();
				}
				else
				{
					av av = A_1.b().c() as av;
					if (av == null)
					{
						aui aui = A_1.b().c() as aui;
						if (aui != null)
						{
							av = aui.a;
						}
					}
					if (av != null)
					{
						cqn cqn = A_1.b().a() as cqn;
						if (cqn != null)
						{
							cqn.a(this.zc());
						}
						base.a(av);
						e4z.c();
					}
				}
			}
		}
		finally
		{
			base.ag6(A_0, A_1);
		}
	}

	// Token: 0x0600C1DA RID: 49626 RVA: 0x00432E08 File Offset: 0x00431008
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		if (!this.b && base.Pressed && this.zc() != null && base.PressedDuration >= wj.b)
		{
			chr service = bpo.GetService<chr>();
			if (service != null && service.ax() == null)
			{
				e08 a_ = new e08(this, this.zc(), TimelapseCursor.ItemDrag.ToString());
				service.az(a_);
				base.Pressed = false;
				e4z.d();
			}
		}
	}

	// Token: 0x0600C1DB RID: 49627 RVA: 0x00432E98 File Offset: 0x00431098
	protected override void ag7(object A_0, etu A_1)
	{
		base.ag7(A_0, A_1);
		base.a(null);
	}

	// Token: 0x0600C1DC RID: 49628 RVA: 0x00432EAC File Offset: 0x004310AC
	protected override void zh(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C1DD RID: 49629 RVA: 0x00432EB8 File Offset: 0x004310B8
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (A_1.b() == eoo.d && this.zc() != null)
		{
			coh coh = this.zc().b9() as coh;
			if (coh != null && coh.Definition.a2().Count > 1)
			{
				Point point = base.at();
				global::bc.a(this, base.Parent, coh, new Point(point.X + base.Size.c / 2, point.Y + base.Size.d / 2), true, false);
			}
		}
	}

	// Token: 0x04004631 RID: 17969
	private new av a;

	// Token: 0x04004632 RID: 17970
	private new bool b;
}
