using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x0200030C RID: 780
[apc("facelessDoctor")]
public class amk : esk
{
	// Token: 0x06001669 RID: 5737 RVA: 0x0006D990 File Offset: 0x0006BB90
	public amk()
	{
		this.f = new ej0(new Action<ej0>(amk.a.a.c));
		this.f.a = this.c;
		this.d = new TryActivateAuraNode<aey>(new bool?(true));
		this.d.a = this.f;
		this.d.b = this.c;
		this.e = new TryActivateAuraNode<c7p>(new bool?(true));
		this.e.a = this.f;
		this.e.b = this.c;
		arr[] array = new arr[4];
		array[0] = new arr(this.d, new Func<e1k, bool>(amk.a.a.h));
		array[1] = new arr(this.e, new Func<e1k, bool>(amk.a.a.b));
		array[2] = new arr(this.d, new Func<e1k, bool>(amk.a.a.d));
		array[3] = new arr(this.c, null);
		this.c = new fh(array);
		this.d.b = this.c;
		this.a = new ej0(new Action<ej0>(amk.a.a.b));
		this.a.a = base.f();
		base.b(this.a);
		this.b = new ej0(new Action<ej0>(amk.a.a.a));
		this.b.a = this.c.a;
		this.c.a = this.b;
		this.g = new TryUseQuickSlotItemCapNode<b2v>();
		this.g.a = new int?(0);
		this.g.c = new Func<e1k, object>(amk.a.a.g);
		this.g.a = this.a;
		this.g.b = this.p.a;
		this.h = new TryUseQuickSlotItemCapNode<b2v>();
		this.h.a = new int?(0);
		this.h.c = new Func<e1k, object>(amk.a.a.a);
		this.h.a = this.a;
		this.h.b = this.p.a;
		this.i = new TryUseQuickSlotItemCapNode<b2v>();
		this.i.a = new int?(2);
		this.i.c = new Func<e1k, object>(amk.a.a.e);
		this.i.a = this.a;
		this.i.b = this.p.a;
		this.j = new TryUseQuickSlotItemCapNode<b2v>();
		this.j.a = new int?(2);
		this.j.c = new Func<e1k, object>(amk.a.a.c);
		this.j.a = this.a;
		this.j.b = this.p.a;
		this.k = new TryUseQuickSlotItemCapNode<b2v>();
		this.k.a = new int?(1);
		this.k.c = new Func<e1k, object>(amk.a.a.f);
		this.k.a = this.a;
		this.k.b = this.p.a;
		this.a.a.InsertRange(0, new arr[]
		{
			new arr(this.i, new Func<e1k, bool>(this.e)),
			new arr(this.g, new Func<e1k, bool>(this.d)),
			new arr(this.j, new Func<e1k, bool>(this.c)),
			new arr(this.h, new Func<e1k, bool>(this.b)),
			new arr(this.k, new Func<e1k, bool>(this.a))
		});
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x0006DE70 File Offset: 0x0006C070
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		return this.i.a(A_0) && this.i.c(A_0) != null;
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0006DEA0 File Offset: 0x0006C0A0
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (this.g.a(A_0) && this.g.c(A_0) != null);
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x0006DEF4 File Offset: 0x0006C0F4
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (this.j.a(A_0) && this.j.c(A_0) != null);
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0006DF48 File Offset: 0x0006C148
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (this.h.a(A_0) && this.h.c(A_0) != null);
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x0006DF9C File Offset: 0x0006C19C
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (this.k.a(A_0) && this.k.c(A_0) != null);
	}

	// Token: 0x04000D01 RID: 3329
	protected new ej0 a;

	// Token: 0x04000D02 RID: 3330
	protected new ej0 b;

	// Token: 0x04000D03 RID: 3331
	protected new fh c;

	// Token: 0x04000D04 RID: 3332
	protected new TryActivateAuraNode<aey> d;

	// Token: 0x04000D05 RID: 3333
	protected new TryActivateAuraNode<c7p> e;

	// Token: 0x04000D06 RID: 3334
	protected new ej0 f;

	// Token: 0x04000D07 RID: 3335
	protected new TryUseQuickSlotItemCapNode<b2v> g;

	// Token: 0x04000D08 RID: 3336
	protected new TryUseQuickSlotItemCapNode<b2v> h;

	// Token: 0x04000D09 RID: 3337
	protected new TryUseQuickSlotItemCapNode<b2v> i;

	// Token: 0x04000D0A RID: 3338
	protected new TryUseQuickSlotItemCapNode<b2v> j;

	// Token: 0x04000D0B RID: 3339
	protected new TryUseQuickSlotItemCapNode<b2v> k;

	// Token: 0x0200030D RID: 781
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x0006E008 File Offset: 0x0006C208
		internal void c(ej0 A_0)
		{
			A_0.b().c().y6()[ddq.a7] = 2;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0006E038 File Offset: 0x0006C238
		internal bool h(e1k A_0)
		{
			return A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0 && (double)(A_0.g().aa().Defense.q().zo() / Math.Max(1f, A_0.g().aa().Defense.q().zm())) <= 0.3;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0006E0C0 File Offset: 0x0006C2C0
		internal bool b(e1k A_0)
		{
			if (A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0)
			{
				cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					float num = classPropertyValue.b((int)A_0.c().a8().h.b.aa().Offense.u().TypedDefinition.ad());
					if (num == -1f || num >= 5f)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0006E160 File Offset: 0x0006C360
		internal bool d(e1k A_0)
		{
			return A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0006E198 File Offset: 0x0006C398
		internal void b(ej0 A_0)
		{
			A_0.b().c().y6().RemoveProperty(ddq.a7);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0006E1C0 File Offset: 0x0006C3C0
		internal void a(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a7] = num;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0006E220 File Offset: 0x0006C420
		internal object g(e1k A_0)
		{
			if (euf.f(A_0.g().aa()) < 0.7f)
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0006E24C File Offset: 0x0006C44C
		internal object a(e1k A_0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() == null)
			{
				return null;
			}
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = null;
			double num = double.MaxValue;
			bool flag = false;
			foreach (blk blk in bzv.b())
			{
				if (blk.a().f() == cem.d && blk.e() != null && (A_0.g().aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == global::h.e || A_0.g().aa().FactionId == blk.e().aa().FactionId) && euf.f(blk.e().aa()) <= 0.65f && !blk.e().aa().b(d8o.e))
				{
					double num2 = aw1.b(A_0.g().a8(), blk.e().a8());
					bool flag2 = euf.f(blk.e().aa()) < 0.4f && blk.e().aa().StatusEffects.a(c6h.a);
					if (amc == null || num2 < num || (flag2 && !flag))
					{
						num = num2;
						amc = blk.e();
						flag = flag2;
					}
				}
			}
			if (amc == null)
			{
				return null;
			}
			return amc.a8();
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0006E424 File Offset: 0x0006C624
		internal object e(e1k A_0)
		{
			if (euf.f(A_0.g().aa()) < 0.5f && euf.f(A_0.g().aa()) > 0.15f && !A_0.g().aa().StatusEffects.a(c6h.a))
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0006E494 File Offset: 0x0006C694
		internal object c(e1k A_0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() == null)
			{
				return null;
			}
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = null;
			double num = double.MaxValue;
			foreach (blk blk in bzv.b())
			{
				if (blk.a().f() == cem.d && blk.e() != null && (A_0.g().aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == global::h.e || A_0.g().aa().FactionId == blk.e().aa().FactionId) && euf.f(blk.e().aa()) < 0.5f && euf.f(A_0.g().aa()) > 0.15f && !blk.e().aa().StatusEffects.a(c6h.a) && !blk.e().aa().b(d8o.e))
				{
					double num2 = aw1.b(A_0.g().a8(), blk.e().a8());
					if (amc == null || num2 < num)
					{
						num = num2;
						amc = blk.e();
					}
				}
			}
			if (amc == null)
			{
				return null;
			}
			return amc.a8();
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0006E650 File Offset: 0x0006C850
		internal object f(e1k A_0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() == null)
			{
				return null;
			}
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = null;
			double num = double.MaxValue;
			foreach (blk blk in bzv.b())
			{
				if (blk.a().f() == cem.d && blk.e() != null && (A_0.g().aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == global::h.e || A_0.g().aa().FactionId == blk.e().aa().FactionId) && !blk.e().aa().StatusEffects.a(uj.a) && !blk.e().aa().b(d8o.e) && blk.e().aa().IsInControl)
				{
					double num2 = aw1.b(A_0.g().a8(), blk.e().a8());
					if (amc == null || num2 < num)
					{
						num = num2;
						amc = blk.e();
					}
				}
			}
			if (amc == null)
			{
				return null;
			}
			return amc.a8();
		}

		// Token: 0x04000D0C RID: 3340
		public static readonly amk.a a = new amk.a();

		// Token: 0x04000D0D RID: 3341
		public static Action<ej0> b;

		// Token: 0x04000D0E RID: 3342
		public static Func<e1k, bool> c;

		// Token: 0x04000D0F RID: 3343
		public static Func<e1k, bool> d;

		// Token: 0x04000D10 RID: 3344
		public static Func<e1k, bool> e;

		// Token: 0x04000D11 RID: 3345
		public static Action<ej0> f;

		// Token: 0x04000D12 RID: 3346
		public static Action<ej0> g;

		// Token: 0x04000D13 RID: 3347
		public static Func<e1k, object> h;

		// Token: 0x04000D14 RID: 3348
		public static Func<e1k, object> i;

		// Token: 0x04000D15 RID: 3349
		public static Func<e1k, object> j;

		// Token: 0x04000D16 RID: 3350
		public static Func<e1k, object> k;

		// Token: 0x04000D17 RID: 3351
		public static Func<e1k, object> l;
	}
}
