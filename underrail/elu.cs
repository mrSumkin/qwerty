using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000303 RID: 771
[apc("dreadnought")]
public sealed class elu : cqw
{
	// Token: 0x0600163B RID: 5691 RVA: 0x0006B8C8 File Offset: 0x00069AC8
	public override bool ef()
	{
		return false;
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x0006B8CC File Offset: 0x00069ACC
	public elu()
	{
		this.c = new fh(new arr[0]);
		this.e = new TryInvokeSpecialAbilityNode<a40>();
		this.e.a = this.j;
		this.e.b = this.p.a;
		this.e.b = new Func<e1k, object>(elu.a.a.a);
		this.a = new ej0(new Action<ej0>(elu.a.a.a));
		this.a.a = this.i.b;
		this.d = new TryInvokeSpecialAttackNode<c91>();
		this.d.a = this.j;
		this.d.b = this.p.a;
		this.b = new ej0(new Action<ej0>(elu.a.a.b));
		this.b.a = this.d;
		fh fh = this.c;
		arr[] array = new arr[3];
		array[0] = new arr(this.e, new Func<e1k, bool>(this.a));
		array[1] = new arr(this.a, new Func<e1k, bool>(elu.a.a.b));
		array[2] = new arr(this.b, null);
		fh.a(array);
		this.i.b = this.c;
		this.h.b = this.c;
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0006BA90 File Offset: 0x00069C90
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.e.b(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && aw1.b(A_0.g().a8(), amc.a8()) > 3.0)
			{
				cmb cmb = bzv.d();
				return cmb != null && eb4.IsSafeToThrow<ct7>(A_0.g(), amc, a40.h, a40.g, cmb, true, false, false, false);
			}
		}
		return false;
	}

	// Token: 0x04000CD3 RID: 3283
	private new ej0 a;

	// Token: 0x04000CD4 RID: 3284
	private new ej0 b;

	// Token: 0x04000CD5 RID: 3285
	private new fh c;

	// Token: 0x04000CD6 RID: 3286
	private new TryInvokeSpecialAttackNode<c91> d;

	// Token: 0x04000CD7 RID: 3287
	private new TryInvokeSpecialAbilityNode<a40> e;

	// Token: 0x02000304 RID: 772
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001640 RID: 5696 RVA: 0x0006BB30 File Offset: 0x00069D30
		internal object a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0006BB98 File Offset: 0x00069D98
		internal void a(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0006BBC0 File Offset: 0x00069DC0
		internal void b(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0006BBE8 File Offset: 0x00069DE8
		internal bool b(e1k A_0)
		{
			bool flag = false;
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					if (classPropertyValue.b(0) < 2f)
					{
						flag = true;
					}
				}
				else
				{
					flag = aw1.a(A_0.g().a8(), 1).Contains(amc);
				}
			}
			return flag && cuo.a.NextDouble() < 0.5;
		}

		// Token: 0x04000CD8 RID: 3288
		public static readonly elu.a a = new elu.a();

		// Token: 0x04000CD9 RID: 3289
		public static Func<e1k, object> b;

		// Token: 0x04000CDA RID: 3290
		public static Action<ej0> c;

		// Token: 0x04000CDB RID: 3291
		public static Action<ej0> d;

		// Token: 0x04000CDC RID: 3292
		public static Func<e1k, bool> e;
	}
}
