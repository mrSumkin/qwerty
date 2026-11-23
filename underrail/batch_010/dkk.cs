using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002015 RID: 8213
public sealed class dkk : cqy
{
	// Token: 0x170002CD RID: 717
	// (get) Token: 0x0600C22C RID: 49708 RVA: 0x004341E0 File Offset: 0x004323E0
	public override coh Item
	{
		get
		{
			if (this.Container != null && this.b >= 0 && this.b < this.Container.z2().Count)
			{
				return this.Container.z2()[this.b];
			}
			return null;
		}
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x0600C22D RID: 49709 RVA: 0x00434238 File Offset: 0x00432438
	// (set) Token: 0x0600C22E RID: 49710 RVA: 0x00434240 File Offset: 0x00432440
	public int Index
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

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x0600C22F RID: 49711 RVA: 0x0043424C File Offset: 0x0043244C
	public dbi Container
	{
		get
		{
			if (this.a == null)
			{
				return null;
			}
			return this.a.x();
		}
	}

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x0600C230 RID: 49712 RVA: 0x00434268 File Offset: 0x00432468
	// (set) Token: 0x0600C231 RID: 49713 RVA: 0x00434270 File Offset: 0x00432470
	public b3w ContainerView
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600C232 RID: 49714 RVA: 0x0043427C File Offset: 0x0043247C
	// (set) Token: 0x0600C233 RID: 49715 RVA: 0x00434298 File Offset: 0x00432498
	public override string ItemExchangeParty
	{
		get
		{
			if (this.a == null)
			{
				return null;
			}
			return this.a.x8();
		}
		set
		{
		}
	}

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x0600C234 RID: 49716 RVA: 0x0043429C File Offset: 0x0043249C
	// (set) Token: 0x0600C235 RID: 49717 RVA: 0x004342A4 File Offset: 0x004324A4
	public bool CanSplit
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x0600C236 RID: 49718 RVA: 0x004342B0 File Offset: 0x004324B0
	// (set) Token: 0x0600C237 RID: 49719 RVA: 0x004342B8 File Offset: 0x004324B8
	public bool CanMerge
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x0600C238 RID: 49720 RVA: 0x004342C4 File Offset: 0x004324C4
	protected override bool OverlayWhenBeingInvoked
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x0600C239 RID: 49721 RVA: 0x004342C8 File Offset: 0x004324C8
	public override double? ValueModifier
	{
		get
		{
			if (this.a != null)
			{
				return this.a.f();
			}
			return null;
		}
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x0600C23A RID: 49722 RVA: 0x004342F8 File Offset: 0x004324F8
	public override Color IconColor
	{
		get
		{
			if (this.e != null)
			{
				return this.e.Value;
			}
			return base.ano();
		}
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x0600C23B RID: 49723 RVA: 0x0043431C File Offset: 0x0043251C
	public override Color? CustomOutlineColor
	{
		get
		{
			return this.f;
		}
	}

	// Token: 0x0600C23C RID: 49724 RVA: 0x00434328 File Offset: 0x00432528
	public dkk(b3w A_0, int A_1)
	{
		czh.a(A_0, "containerView");
		this.a = A_0;
		this.b = A_1;
		base.a(Color.White * 0.3f);
	}

	// Token: 0x0600C23D RID: 49725 RVA: 0x00434378 File Offset: 0x00432578
	public dkk(b3w A_0, int A_1, esj A_2, esj A_3) : base(A_2, A_3)
	{
		czh.a(A_0, "containerView");
		this.a = A_0;
		this.b = A_1;
		base.a(Color.White * 0.3f);
	}

	// Token: 0x0600C23E RID: 49726 RVA: 0x004343CC File Offset: 0x004325CC
	public override bool iq(e08 A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		coh coh = A_0.c() as coh;
		return coh != null && this.a.iq(A_0) && (this.x6() == null || !c69.a(coh, this.x6()) || this.x6().Stacks >= this.x6().Definition.be() || this.d);
	}

	// Token: 0x0600C23F RID: 49727 RVA: 0x0043444C File Offset: 0x0043264C
	public override coh yb(coh A_0, bool A_1 = false)
	{
		if (this.x6() != null)
		{
			int num = this.a.l().z2().IndexOf(this.x6());
			if (num != -1)
			{
				return this.a.a(num, A_0);
			}
		}
		return this.a.yb(A_0, A_1);
	}

	// Token: 0x0600C240 RID: 49728 RVA: 0x004344A4 File Offset: 0x004326A4
	public override coh yd()
	{
		if (this.x6() != null)
		{
			coh result = this.x6();
			this.a.c(this.x6());
			return result;
		}
		return null;
	}

	// Token: 0x0600C241 RID: 49729 RVA: 0x004344D8 File Offset: 0x004326D8
	public override bool ye(ebk A_0, coh A_1)
	{
		return base.ye(A_0, A_1) && this.a.ye(A_0, A_1);
	}

	// Token: 0x0600C242 RID: 49730 RVA: 0x004344F8 File Offset: 0x004326F8
	public override bool yg(ebk A_0)
	{
		return A_0 != this && base.yg(A_0) && this.a.yg(A_0);
	}

	// Token: 0x0600C243 RID: 49731 RVA: 0x0043451C File Offset: 0x0043271C
	public override void yc(coh A_0, int A_1, int A_2)
	{
		this.a.yc(A_0, A_1, A_2);
	}

	// Token: 0x0600C244 RID: 49732 RVA: 0x00434530 File Offset: 0x00432730
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (wj.a().d == UiSize.Classic)
		{
			if (this.a.a(this.x6(), out this.e) || this.a.b(this.x6(), ref this.e))
			{
				this.f = new Color?(new Color(110, 80, 15));
				return;
			}
			this.f = null;
			return;
		}
		else
		{
			this.e = null;
			if (this.a.u && this.a.w != null)
			{
				if (this.a.a(this.x6(), out this.e))
				{
					this.s = new Color?(adi.b * 0.5f);
					return;
				}
				this.s = null;
				return;
			}
			else
			{
				if (this.a.b(this.x6(), ref this.e))
				{
					this.s = new Color?(adi.b * 0.5f);
					return;
				}
				this.s = null;
				return;
			}
		}
	}

	// Token: 0x0600C245 RID: 49733 RVA: 0x0043466C File Offset: 0x0043286C
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.x6() != null && this.a.b(this.x6()))
		{
			Vector2 a_ = base.at().b();
			Texture2D resource = A_1.a.GetResource<Texture2D>(this.d, null);
			Rectangle value = new Rectangle(this.e.X + 3 * this.f.c, this.e.Y, this.f.c, this.f.d);
			A_1.b().w5(resource, a_, new Rectangle?(value), Color.Red * 0.33f);
		}
	}

	// Token: 0x0600C246 RID: 49734 RVA: 0x0043472C File Offset: 0x0043292C
	public override ecs yf(euz A_0)
	{
		coh coh = this.x6();
		if (coh != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
			bool a_ = this.a != null && this.a.x8() == "PlayerInventory";
			return cq4.a(coh, (serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null, this, true, serviceOrThrow2.ak7(), serviceOrThrow2.ak8(), null, this.ann(), a_);
		}
		return null;
	}

	// Token: 0x0600C247 RID: 49735 RVA: 0x004347B4 File Offset: 0x004329B4
	protected override bool x7()
	{
		return this.a.t();
	}

	// Token: 0x0600C248 RID: 49736 RVA: 0x004347C4 File Offset: 0x004329C4
	protected override Rectangle? aia()
	{
		return this.a.n();
	}

	// Token: 0x0600C249 RID: 49737 RVA: 0x004347D4 File Offset: 0x004329D4
	protected override bool anq(coh A_0)
	{
		if (this.a != null)
		{
			return this.a.a(A_0);
		}
		return base.anq(A_0);
	}

	// Token: 0x0600C24A RID: 49738 RVA: 0x004347F8 File Offset: 0x004329F8
	protected override object yh()
	{
		return new dkk.b(this);
	}

	// Token: 0x0600C24B RID: 49739 RVA: 0x00434800 File Offset: 0x00432A00
	protected override ebk anr()
	{
		return new dkk.a(this);
	}

	// Token: 0x0600C24C RID: 49740 RVA: 0x0043480C File Offset: 0x00432A0C
	protected override void rd(object A_0, b25 A_1)
	{
		base.rd(A_0, A_1);
		if (d4f.b())
		{
			if (base.zf())
			{
				d4f.b(this);
				return;
			}
		}
		else if (!d4f.a && this.x6() != null && this.x6().Stacks > 1)
		{
			KeyboardState state = Keyboard.GetState();
			if ((state.IsKeyDown(Keys.LeftShift) || state.IsKeyDown(Keys.RightShift)) && this.c && !state.IsKeyDown(Keys.LeftAlt) && !state.IsKeyDown(Keys.RightAlt) && !state.IsKeyDown(Keys.LeftControl) && !state.IsKeyDown(Keys.RightControl))
			{
				Point point = d05.a(base.at(), A_1.a(), false);
				tg tg = new tg(this.x6().Stacks);
				tg.Gravity = axy.c;
				tg.Location = new Point(point.X - tg.Size.c / 2, point.Y - tg.Size.d / 2);
				tg.a(new EventHandler<el5>(this.a));
				tg.c(new EventHandler<EventArgs>(this.a));
				a2x.a(tg);
				tg.bj();
				tg.a9();
				ps service = bpo.GetService<ps>();
				if (service != null)
				{
					service.amh();
				}
			}
		}
	}

	// Token: 0x0600C24D RID: 49741 RVA: 0x00434980 File Offset: 0x00432B80
	private new void a(object A_0, EventArgs A_1)
	{
		tg tg = A_0 as tg;
		if (this.x6() != null && tg != null)
		{
			coh coh = this.x6().fy();
			coh.Stacks = tg.f();
			this.x6().Stacks = tg.e();
			this.a.yb(coh, false);
		}
	}

	// Token: 0x0600C24E RID: 49742 RVA: 0x004349DC File Offset: 0x00432BDC
	private new void a(object A_0, el5 A_1)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.ami();
		}
	}

	// Token: 0x04004646 RID: 17990
	private new b3w a;

	// Token: 0x04004647 RID: 17991
	private new int b;

	// Token: 0x04004648 RID: 17992
	private new bool c = true;

	// Token: 0x04004649 RID: 17993
	private new bool d = true;

	// Token: 0x0400464A RID: 17994
	private new Color? e;

	// Token: 0x0400464B RID: 17995
	private new Color? f;

	// Token: 0x02002016 RID: 8214
	private new class b : ebk, bxd
	{
		// Token: 0x0600C24F RID: 49743 RVA: 0x004349FC File Offset: 0x00432BFC
		public b(dkk A_0)
		{
			this.a = A_0;
			this.b = A_0.x6();
		}

		// Token: 0x0600C250 RID: 49744 RVA: 0x00434A18 File Offset: 0x00432C18
		public string x8()
		{
			return this.a.x8();
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x00434A28 File Offset: 0x00432C28
		public bool ye(ebk A_0, coh A_1)
		{
			return this.a.ye(A_0, A_1);
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x00434A38 File Offset: 0x00432C38
		public bool yg(ebk A_0)
		{
			return this.a.yg(A_0);
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x00434A48 File Offset: 0x00432C48
		public coh yd()
		{
			if (this.b != null && this.a.a.c(this.b))
			{
				return this.b;
			}
			return null;
		}

		// Token: 0x0600C254 RID: 49748 RVA: 0x00434A78 File Offset: 0x00432C78
		public coh yb(coh A_0, bool A_1 = false)
		{
			return this.a.yb(A_0, A_1);
		}

		// Token: 0x0600C255 RID: 49749 RVA: 0x00434A88 File Offset: 0x00432C88
		public void yc(coh A_0, int A_1, int A_2)
		{
			this.a.yc(A_0, A_1, A_2);
		}

		// Token: 0x0600C256 RID: 49750 RVA: 0x00434A98 File Offset: 0x00432C98
		public coh yx()
		{
			return this.b;
		}

		// Token: 0x0600C257 RID: 49751 RVA: 0x00434AA0 File Offset: 0x00432CA0
		public bool yy()
		{
			return true;
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x00434AA8 File Offset: 0x00432CA8
		public bool aoz(coh A_0)
		{
			return this.a.a == null || this.a.a.s() == null || this.a.a.s().kj(this.a.a.l(), A_0, null);
		}

		// Token: 0x0400464C RID: 17996
		private dkk a;

		// Token: 0x0400464D RID: 17997
		private coh b;
	}

	// Token: 0x02002017 RID: 8215
	private new class a : ebk
	{
		// Token: 0x0600C259 RID: 49753 RVA: 0x00434B04 File Offset: 0x00432D04
		public a(dkk A_0)
		{
			this.a = A_0;
			this.b = ((A_0.x6() != null) ? A_0.b : -1);
		}

		// Token: 0x0600C25A RID: 49754 RVA: 0x00434B3C File Offset: 0x00432D3C
		public string x8()
		{
			return this.a.x8();
		}

		// Token: 0x0600C25B RID: 49755 RVA: 0x00434B4C File Offset: 0x00432D4C
		public bool ye(ebk A_0, coh A_1)
		{
			return this.a.ye(A_0, A_1);
		}

		// Token: 0x0600C25C RID: 49756 RVA: 0x00434B5C File Offset: 0x00432D5C
		public bool yg(ebk A_0)
		{
			return this.a.yg(A_0);
		}

		// Token: 0x0600C25D RID: 49757 RVA: 0x00434B6C File Offset: 0x00432D6C
		public coh yd()
		{
			return this.a.yd();
		}

		// Token: 0x0600C25E RID: 49758 RVA: 0x00434B7C File Offset: 0x00432D7C
		public coh yb(coh A_0, bool A_1 = false)
		{
			int num = -1;
			if (this.a.x6() != null)
			{
				num = this.a.a.l().z2().IndexOf(this.a.x6());
			}
			if (num != -1)
			{
				return this.a.a.a(num, A_0);
			}
			return this.a.a.yb(A_0, A_1);
		}

		// Token: 0x0600C25F RID: 49759 RVA: 0x00434BF0 File Offset: 0x00432DF0
		public void yc(coh A_0, int A_1, int A_2)
		{
			this.a.yc(A_0, A_1, A_2);
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x00434C00 File Offset: 0x00432E00
		public coh yx()
		{
			return this.a.yx();
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x00434C10 File Offset: 0x00432E10
		public bool yy()
		{
			return true;
		}

		// Token: 0x0400464E RID: 17998
		private dkk a;

		// Token: 0x0400464F RID: 17999
		private int b;
	}
}
