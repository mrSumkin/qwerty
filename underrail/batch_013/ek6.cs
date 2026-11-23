using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200030E RID: 782
[apc("facelessCentaur")]
public sealed class ek6 : esk
{
	// Token: 0x0600167C RID: 5756 RVA: 0x0006E7EC File Offset: 0x0006C9EC
	public ek6()
	{
		arr arr = Enumerable.FirstOrDefault<arr>(Enumerable.Where<arr>(this.c.a, new Func<arr, bool>(this.a)));
		if (arr != null)
		{
			this.c.a.Remove(arr);
		}
		this.e = new ej0(new Action<ej0>(ek6.a.a.e));
		this.e.a = this.c;
		this.d = new TryActivateAuraNode<cvf>(new bool?(true));
		this.d.a = this.e;
		this.d.b = this.c;
		arr[] array = new arr[2];
		array[0] = new arr(this.d, new Func<e1k, bool>(ek6.a.a.a));
		array[1] = new arr(this.c, null);
		this.c = new fh(array);
		this.d.b = this.c;
		this.a = new ej0(new Action<ej0>(ek6.a.a.a));
		this.a.a = base.f();
		base.b(this.a);
		this.b = new ej0(new Action<ej0>(ek6.a.a.d));
		this.b.a = this.c.a;
		this.c.a = this.b;
		this.f = new ej0(new Action<ej0>(ek6.a.a.b));
		this.f.a = this.c;
		this.g = new ej0(new Action<ej0>(ek6.a.a.c));
		this.g.a = this.c;
		this.c.a.InsertRange(this.c.a.Count - 1, new arr[]
		{
			new arr(this.f, new Func<e1k, bool>(this.b)),
			new arr(this.g, new Func<e1k, bool>(this.a))
		});
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x0006EA84 File Offset: 0x0006CC84
	private new bool c(e1k A_0)
	{
		if (!A_0.g().aa().SpecialStates.b)
		{
			d4n d4n = base.e();
			if (d4n != null && d4n.c >= (double)A_0.g().aa().Offense.b(WeaponKey.Secondary).TypedDefinition.v())
			{
				int num = (int)(d4n.d + (d4n.c - (double)A_0.g().aa().Offense.b(WeaponKey.Secondary).TypedDefinition.v())) - 5;
				cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					float num2 = classPropertyValue.b(0);
					if (num2 == -1f || num2 * 10f <= (float)num)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x0006EB58 File Offset: 0x0006CD58
	[CompilerGenerated]
	private new bool a(arr A_0)
	{
		return A_0.a == this.g;
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x0006EB6C File Offset: 0x0006CD6C
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return A_0.g().aa().Offense.au() != WeaponKey.Primary && !this.c(A_0) && d3k.a(A_0.g().aa(), A_0.g().aa().Offense.b(WeaponKey.Primary), false);
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x0006EBCC File Offset: 0x0006CDCC
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return A_0.g().aa().Offense.au() != WeaponKey.Secondary && this.c(A_0);
	}

	// Token: 0x04000D18 RID: 3352
	private new ej0 a;

	// Token: 0x04000D19 RID: 3353
	private new ej0 b;

	// Token: 0x04000D1A RID: 3354
	private new fh c;

	// Token: 0x04000D1B RID: 3355
	private new TryActivateAuraNode<cvf> d;

	// Token: 0x04000D1C RID: 3356
	private new ej0 e;

	// Token: 0x04000D1D RID: 3357
	private new ej0 f;

	// Token: 0x04000D1E RID: 3358
	private new ej0 g;

	// Token: 0x0200030F RID: 783
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001683 RID: 5763 RVA: 0x0006EC18 File Offset: 0x0006CE18
		internal void e(ej0 A_0)
		{
			A_0.b().c().y6()[ddq.a7] = 2;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0006EC48 File Offset: 0x0006CE48
		internal bool a(e1k A_0)
		{
			return A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value == 0;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0006EC80 File Offset: 0x0006CE80
		internal void a(ej0 A_0)
		{
			A_0.b().c().y6().RemoveProperty(ddq.a7);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0006ECA8 File Offset: 0x0006CEA8
		internal void d(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a7, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a7] = num;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0006ED08 File Offset: 0x0006CF08
		internal void b(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0006ED30 File Offset: 0x0006CF30
		internal void c(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x04000D1F RID: 3359
		public static readonly ek6.a a = new ek6.a();

		// Token: 0x04000D20 RID: 3360
		public static Action<ej0> b;

		// Token: 0x04000D21 RID: 3361
		public static Func<e1k, bool> c;

		// Token: 0x04000D22 RID: 3362
		public static Action<ej0> d;

		// Token: 0x04000D23 RID: 3363
		public static Action<ej0> e;

		// Token: 0x04000D24 RID: 3364
		public static Action<ej0> f;

		// Token: 0x04000D25 RID: 3365
		public static Action<ej0> g;
	}
}
