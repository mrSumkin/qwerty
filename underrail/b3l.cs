using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Common.Data;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002BF RID: 703
[apc("technomedic")]
public class b3l : esk
{
	// Token: 0x06001467 RID: 5223 RVA: 0x00058C14 File Offset: 0x00056E14
	public b3l()
	{
		b3l.b b = new b3l.b();
		b.a = this.q.a;
		this.q.a = new Action<ej0>(b.a);
		this.c = new TryInvokeSpecialAbilityNode<aas>();
		this.c.b = new Func<e1k, object>(b3l.a.a.b);
		this.c.a = this.a;
		this.c.b = this.a(this.c);
		this.a = new TryInvokeSpecialAbilityNode<a0k>();
		this.a.b = new Func<e1k, object>(b3l.a.a.a);
		this.a.a = this.a;
		this.a.b = this.a(this.a);
		this.b = new TryInvokeSpecialAbilityNode<a0k>();
		this.b.b = new Func<e1k, object>(b3l.a.a.h);
		this.b.a = this.a;
		this.b.b = this.a(this.b);
		this.d = new TryUseQuickSlotItemCapNode<b2v>();
		this.d.a = new int?(0);
		this.d.c = new Func<e1k, object>(b3l.a.a.f);
		this.d.a = this.a;
		this.d.b = this.a(this.d);
		this.e = new TryUseQuickSlotItemCapNode<b2v>();
		this.e.a = new int?(0);
		this.e.c = new Func<e1k, object>(b3l.a.a.e);
		this.e.a = this.a;
		this.e.b = this.a(this.e);
		this.f = new TryUseQuickSlotItemCapNode<b2v>();
		this.f.a = new int?(2);
		this.f.c = new Func<e1k, object>(b3l.a.a.d);
		this.f.a = this.a;
		this.f.b = this.a(this.f);
		this.g = new TryUseQuickSlotItemCapNode<b2v>();
		this.g.a = new int?(2);
		this.g.c = new Func<e1k, object>(b3l.a.a.c);
		this.g.a = this.a;
		this.g.b = this.a(this.g);
		this.h = new TryUseQuickSlotItemCapNode<b2v>();
		this.h.a = new int?(1);
		this.h.c = new Func<e1k, object>(b3l.a.a.g);
		this.h.a = this.a;
		this.h.b = this.a(this.h);
		this.a.a.InsertRange(0, new arr[]
		{
			new arr(this.c, new Func<e1k, bool>(this.h)),
			new arr(this.f, new Func<e1k, bool>(this.g)),
			new arr(this.d, new Func<e1k, bool>(this.f)),
			new arr(this.g, new Func<e1k, bool>(this.e)),
			new arr(this.e, new Func<e1k, bool>(this.d)),
			new arr(this.a, new Func<e1k, bool>(this.c)),
			new arr(this.b, new Func<e1k, bool>(this.b)),
			new arr(this.h, new Func<e1k, bool>(this.a))
		});
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00059094 File Offset: 0x00057294
	private new bool a(amc A_0, int A_1)
	{
		return A_0 != null && A_0.aa().Gear.l().Item != null && A_0.aa().Gear.l().Item.Battery > (double)A_1;
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x000590E4 File Offset: 0x000572E4
	private new bool a(abg A_0, e1k A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return false;
		}
		PropertyCollection propertyCollection = A_1.d();
		if (propertyCollection == null)
		{
			return false;
		}
		HashSet<abg> classPropertyValue = propertyCollection.GetClassPropertyValue<HashSet<abg>>("disabledTechnomedicNodes");
		return classPropertyValue != null && classPropertyValue.Contains(A_0);
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x0005912C File Offset: 0x0005732C
	private new abg a(abg A_0)
	{
		b3l.c c = new b3l.c();
		c.a = A_0;
		return new ej0
		{
			a = new Action<ej0>(c.a),
			a = this.p.a
		};
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00059170 File Offset: 0x00057370
	[CompilerGenerated]
	private new bool h(e1k A_0)
	{
		return !this.a(this.c, A_0) && this.c.b(A_0) && this.c.b(A_0) != null;
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x000591B0 File Offset: 0x000573B0
	[CompilerGenerated]
	private new bool g(e1k A_0)
	{
		return !this.a(this.f, A_0) && this.f.a(A_0) && this.f.c(A_0) != null;
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x000591F0 File Offset: 0x000573F0
	[CompilerGenerated]
	private new bool f(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (!this.a(this.d, A_0) && this.d.a(A_0) && this.d.c(A_0) != null);
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00059258 File Offset: 0x00057458
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (!this.a(this.g, A_0) && this.g.a(A_0) && this.g.c(A_0) != null);
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x000592C0 File Offset: 0x000574C0
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (!this.a(this.e, A_0) && this.e.a(A_0) && this.e.c(A_0) != null);
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x00059328 File Offset: 0x00057528
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (!this.a(this.a, A_0) && this.a.b(A_0) && this.a.b(A_0) != null && this.a(A_0.g(), a0k.d));
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x000593A4 File Offset: 0x000575A4
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (!this.a(this.b, A_0) && this.b.b(A_0) && this.b.b(A_0) != null && this.a(A_0.g(), a0k.d));
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x00059420 File Offset: 0x00057620
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.l && (!this.a(this.h, A_0) && this.h.a(A_0) && this.h.c(A_0) != null);
	}

	// Token: 0x04000B30 RID: 2864
	protected new TryInvokeSpecialAbilityNode<a0k> a;

	// Token: 0x04000B31 RID: 2865
	protected new TryInvokeSpecialAbilityNode<a0k> b;

	// Token: 0x04000B32 RID: 2866
	protected new TryInvokeSpecialAbilityNode<aas> c;

	// Token: 0x04000B33 RID: 2867
	protected new TryUseQuickSlotItemCapNode<b2v> d;

	// Token: 0x04000B34 RID: 2868
	protected new TryUseQuickSlotItemCapNode<b2v> e;

	// Token: 0x04000B35 RID: 2869
	protected new TryUseQuickSlotItemCapNode<b2v> f;

	// Token: 0x04000B36 RID: 2870
	protected new TryUseQuickSlotItemCapNode<b2v> g;

	// Token: 0x04000B37 RID: 2871
	protected new TryUseQuickSlotItemCapNode<b2v> h;

	// Token: 0x020002C1 RID: 705
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600151A RID: 5402 RVA: 0x0006133C File Offset: 0x0005F53C
		internal object b(e1k A_0)
		{
			if (euf.e(A_0.g().aa()) < 0.25f)
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00061368 File Offset: 0x0005F568
		internal object a(e1k A_0)
		{
			if (euf.f(A_0.g().aa()) < 0.85f)
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00061394 File Offset: 0x0005F594
		internal object h(e1k A_0)
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
				if (blk.a().f() == cem.d && blk.e() != null && (A_0.g().aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == global::h.e || A_0.g().aa().FactionId == blk.e().aa().FactionId) && euf.f(blk.e().aa()) <= 0.85f && !blk.e().aa().b(d8o.e))
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

		// Token: 0x0600151D RID: 5405 RVA: 0x00061514 File Offset: 0x0005F714
		internal object f(e1k A_0)
		{
			if (euf.f(A_0.g().aa()) < 0.55f)
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00061540 File Offset: 0x0005F740
		internal object e(e1k A_0)
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

		// Token: 0x0600151F RID: 5407 RVA: 0x00061718 File Offset: 0x0005F918
		internal object d(e1k A_0)
		{
			if (euf.f(A_0.g().aa()) < 0.5f && euf.f(A_0.g().aa()) > 0.15f && !A_0.g().aa().StatusEffects.a(c6h.a))
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00061788 File Offset: 0x0005F988
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

		// Token: 0x06001521 RID: 5409 RVA: 0x00061944 File Offset: 0x0005FB44
		internal object g(e1k A_0)
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

		// Token: 0x04000BD1 RID: 3025
		public static readonly b3l.a a = new b3l.a();

		// Token: 0x04000BD2 RID: 3026
		public static Func<e1k, object> b;

		// Token: 0x04000BD3 RID: 3027
		public static Func<e1k, object> c;

		// Token: 0x04000BD4 RID: 3028
		public static Func<e1k, object> d;

		// Token: 0x04000BD5 RID: 3029
		public static Func<e1k, object> e;

		// Token: 0x04000BD6 RID: 3030
		public static Func<e1k, object> f;

		// Token: 0x04000BD7 RID: 3031
		public static Func<e1k, object> g;

		// Token: 0x04000BD8 RID: 3032
		public static Func<e1k, object> h;

		// Token: 0x04000BD9 RID: 3033
		public static Func<e1k, object> i;
	}

	// Token: 0x020002C2 RID: 706
	[CompilerGenerated]
	private new sealed class c
	{
		// Token: 0x06001523 RID: 5411 RVA: 0x00061AE8 File Offset: 0x0005FCE8
		internal void a(ej0 A_0)
		{
			PropertyCollection propertyCollection = A_0.b().d();
			if (propertyCollection == null)
			{
				return;
			}
			HashSet<abg> hashSet = propertyCollection.GetClassPropertyValue<HashSet<abg>>("disabledTechnomedicNodes");
			if (hashSet == null)
			{
				hashSet = new HashSet<abg>();
				propertyCollection.SetPropertyValue("disabledTechnomedicNodes", hashSet);
			}
			hashSet.Add(this.a);
		}

		// Token: 0x04000BDA RID: 3034
		public abg a;
	}

	// Token: 0x020002C3 RID: 707
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x00061B44 File Offset: 0x0005FD44
		internal void a(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("disabledTechnomedicNodes");
			if (this.a != null)
			{
				this.a(A_0);
			}
		}

		// Token: 0x04000BDB RID: 3035
		public Action<ej0> a;
	}
}
