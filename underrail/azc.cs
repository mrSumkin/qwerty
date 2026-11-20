using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002B2 RID: 690
[apc("augmentedRathound")]
public class azc : or
{
	// Token: 0x06001437 RID: 5175 RVA: 0x000572C4 File Offset: 0x000554C4
	public azc()
	{
		TryInvokeSpecialAttackNode<cgb> tryInvokeSpecialAttackNode = new TryInvokeSpecialAttackNode<cgb>();
		tryInvokeSpecialAttackNode.a = this.i.b;
		tryInvokeSpecialAttackNode.b = this.i.b;
		this.a = new d8l();
		this.a.a = tryInvokeSpecialAttackNode;
		this.i = new ej0(new Action<ej0>(azc.a.a.c));
		this.i.a = this.c;
		this.f = new TryActivateAuraNode<cvf>(new bool?(true));
		this.f.a = this.i;
		this.f.b = this.c;
		this.g = new TryActivateAuraNode<aey>(new bool?(true));
		this.g.a = this.i;
		this.g.b = this.c;
		this.h = new TryActivateAuraNode<c7p>(new bool?(true));
		this.h.a = this.i;
		this.h.b = this.c;
		arr[] array = new arr[4];
		array[0] = new arr(this.g, new Func<e1k, bool>(azc.a.a.c));
		array[1] = new arr(this.h, new Func<e1k, bool>(azc.a.a.a));
		array[2] = new arr(this.f, new Func<e1k, bool>(azc.a.a.b));
		array[3] = new arr(this.c, null);
		this.e = new fh(array);
		this.d.b = this.e;
		this.h.b = this.a;
		this.i.b = this.a;
		this.b = new ej0(new Action<ej0>(azc.a.a.a));
		this.b.a = this.c.a;
		this.c.a = this.b;
		this.c = new ej0(new Action<ej0>(azc.a.a.b));
		this.c.a = base.f();
		base.b(this.c);
		this.d = new ej0(new Action<ej0>(azc.a.a.d));
		this.d.a = this.c.a;
		this.c.a = this.d;
	}

	// Token: 0x04000B00 RID: 2816
	protected new d8l a;

	// Token: 0x04000B01 RID: 2817
	protected new ej0 b;

	// Token: 0x04000B02 RID: 2818
	protected new ej0 c;

	// Token: 0x04000B03 RID: 2819
	protected new ej0 d;

	// Token: 0x04000B04 RID: 2820
	protected new fh e;

	// Token: 0x04000B05 RID: 2821
	protected new TryActivateAuraNode<cvf> f;

	// Token: 0x04000B06 RID: 2822
	protected new TryActivateAuraNode<aey> g;

	// Token: 0x04000B07 RID: 2823
	protected new TryActivateAuraNode<c7p> h;

	// Token: 0x04000B08 RID: 2824
	protected new ej0 i;

	// Token: 0x020002B3 RID: 691
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600143A RID: 5178 RVA: 0x000575DC File Offset: 0x000557DC
		internal void c(ej0 A_0)
		{
			A_0.b().c().y6()[ddq.a7] = 2;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0005760C File Offset: 0x0005580C
		internal bool c(e1k A_0)
		{
			return A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0 && (double)(A_0.g().aa().Defense.q().zo() / Math.Max(1f, A_0.g().aa().Defense.q().zm())) <= 0.3;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00057694 File Offset: 0x00055894
		internal bool a(e1k A_0)
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

		// Token: 0x0600143D RID: 5181 RVA: 0x00057734 File Offset: 0x00055934
		internal bool b(e1k A_0)
		{
			return A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0005776C File Offset: 0x0005596C
		internal void a(ej0 A_0)
		{
			A_0.b().c().y6().RemoveProperty(ddq.a);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00057794 File Offset: 0x00055994
		internal void b(ej0 A_0)
		{
			A_0.b().c().y6().RemoveProperty(ddq.a7);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000577BC File Offset: 0x000559BC
		internal void d(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a7] = num;
		}

		// Token: 0x04000B09 RID: 2825
		public static readonly azc.a a = new azc.a();

		// Token: 0x04000B0A RID: 2826
		public static Action<ej0> b;

		// Token: 0x04000B0B RID: 2827
		public static Func<e1k, bool> c;

		// Token: 0x04000B0C RID: 2828
		public static Func<e1k, bool> d;

		// Token: 0x04000B0D RID: 2829
		public static Func<e1k, bool> e;

		// Token: 0x04000B0E RID: 2830
		public static Action<ej0> f;

		// Token: 0x04000B0F RID: 2831
		public static Action<ej0> g;

		// Token: 0x04000B10 RID: 2832
		public static Action<ej0> h;
	}
}
