using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002FE RID: 766
[apc("facelessSoldier")]
public class ake : esk
{
	// Token: 0x06001615 RID: 5653 RVA: 0x00069FA0 File Offset: 0x000681A0
	public ake()
	{
		this.h = new ej0(new Action<ej0>(ake.a.a.a));
		this.h.a = this.c;
		this.d = new TryActivateAuraNode<cvf>(new bool?(true));
		this.d.a = this.h;
		this.d.b = this.c;
		this.e = new TryActivateAuraNode<aey>(new bool?(true));
		this.e.a = this.h;
		this.e.b = this.c;
		this.f = new TryActivateAuraNode<c7p>(new bool?(true));
		this.f.a = this.h;
		this.f.b = this.c;
		this.g = new TryActivateAuraNode<dxf>(new bool?(true));
		this.g.a = this.h;
		this.g.b = this.c;
		this.c = new fh(new arr[]
		{
			new arr(this.e, new Func<e1k, bool>(this.e)),
			new arr(this.g, new Func<e1k, bool>(this.d)),
			new arr(this.f, new Func<e1k, bool>(this.c)),
			new arr(this.d, new Func<e1k, bool>(this.b)),
			new arr(this.e, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.d.b = this.c;
		this.a = new ej0(new Action<ej0>(ake.a.a.c));
		this.a.a = base.f();
		base.b(this.a);
		this.b = new ej0(new Action<ej0>(ake.a.a.b));
		this.b.a = this.c.a;
		this.c.a = this.b;
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x0006A210 File Offset: 0x00068410
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		return this.e.a(A_0) && A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0 && (double)(A_0.g().aa().Defense.q().zo() / Math.Max(1f, A_0.g().aa().Defense.q().zm())) <= 0.3;
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x0006A2A8 File Offset: 0x000684A8
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		if (this.g.a(A_0) && A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0 && base.Caster && A_0.g().aa().PsiAbilities.a() > 0)
		{
			float num = float.MaxValue;
			foreach (ce5 ce in Enumerable.Select<aia, ce5>(A_0.g().aa().PsiAbilities, new Func<aia, ce5>(ake.a.a.a)))
			{
				num = Math.Min(num, ce.e(new eoj(A_0.g().aa(), null, null)));
			}
			if (num <= A_0.g().aa().Offense.aa().zo())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x0006A3D0 File Offset: 0x000685D0
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (this.f.a(A_0) && A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0)
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

	// Token: 0x06001619 RID: 5657 RVA: 0x0006A484 File Offset: 0x00068684
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return this.d.a(A_0) && A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0 && A_0.g().aa().Offense.u().TypedDefinition.e() == btz.g;
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x0006A4F4 File Offset: 0x000686F4
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.e.a(A_0) && A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0;
	}

	// Token: 0x04000CA6 RID: 3238
	protected new ej0 a;

	// Token: 0x04000CA7 RID: 3239
	protected new ej0 b;

	// Token: 0x04000CA8 RID: 3240
	protected new fh c;

	// Token: 0x04000CA9 RID: 3241
	protected new TryActivateAuraNode<cvf> d;

	// Token: 0x04000CAA RID: 3242
	protected new TryActivateAuraNode<aey> e;

	// Token: 0x04000CAB RID: 3243
	protected new TryActivateAuraNode<c7p> f;

	// Token: 0x04000CAC RID: 3244
	protected new TryActivateAuraNode<dxf> g;

	// Token: 0x04000CAD RID: 3245
	protected new ej0 h;

	// Token: 0x02000310 RID: 784
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600168B RID: 5771 RVA: 0x0006ED6C File Offset: 0x0006CF6C
		internal void a(ej0 A_0)
		{
			A_0.b().c().y6()[ddq.a7] = 2;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0006ED9C File Offset: 0x0006CF9C
		internal ce5 a(aia A_0)
		{
			return A_0.Value as ce5;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0006EDAC File Offset: 0x0006CFAC
		internal void c(ej0 A_0)
		{
			A_0.b().c().y6().RemoveProperty(ddq.a7);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0006EDD4 File Offset: 0x0006CFD4
		internal void b(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a7] = num;
		}

		// Token: 0x04000D26 RID: 3366
		public static readonly ake.a a = new ake.a();

		// Token: 0x04000D27 RID: 3367
		public static Action<ej0> b;

		// Token: 0x04000D28 RID: 3368
		public static Func<aia, ce5> c;

		// Token: 0x04000D29 RID: 3369
		public static Action<ej0> d;

		// Token: 0x04000D2A RID: 3370
		public static Action<ej0> e;
	}
}
