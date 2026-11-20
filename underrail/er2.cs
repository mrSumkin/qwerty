using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002DF RID: 735
[apc("nagaProtector")]
public sealed class er2 : esk
{
	// Token: 0x060015AE RID: 5550 RVA: 0x00066BB0 File Offset: 0x00064DB0
	public er2()
	{
		arr arr = Enumerable.FirstOrDefault<arr>(Enumerable.Where<arr>(this.c.a, new Func<arr, bool>(this.a)));
		if (arr != null)
		{
			this.c.a.Remove(arr);
		}
		this.a = new ej0(new Action<ej0>(er2.a.a.a));
		this.a.a = this.c;
		this.b = new ej0(new Action<ej0>(er2.a.a.b));
		this.b.a = this.c;
		this.c.a.InsertRange(this.c.a.Count - 1, new arr[]
		{
			new arr(this.a, new Func<e1k, bool>(this.b)),
			new arr(this.b, new Func<e1k, bool>(this.a))
		});
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x00066CD8 File Offset: 0x00064ED8
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
					if (num2 == -1f || (num2 < 2f && num2 * 10f <= (float)num))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x00066DB8 File Offset: 0x00064FB8
	[CompilerGenerated]
	private new bool a(arr A_0)
	{
		return A_0.a == this.g;
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00066DCC File Offset: 0x00064FCC
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return A_0.g().aa().Offense.au() != WeaponKey.Primary && !this.c(A_0) && d3k.a(A_0.g().aa(), A_0.g().aa().Offense.b(WeaponKey.Primary), false);
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00066E2C File Offset: 0x0006502C
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return A_0.g().aa().Offense.au() != WeaponKey.Secondary && this.c(A_0);
	}

	// Token: 0x04000C59 RID: 3161
	private new ej0 a;

	// Token: 0x04000C5A RID: 3162
	private new ej0 b;

	// Token: 0x020002E0 RID: 736
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015B5 RID: 5557 RVA: 0x00066E78 File Offset: 0x00065078
		internal void a(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00066EA0 File Offset: 0x000650A0
		internal void b(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x04000C5B RID: 3163
		public static readonly er2.a a = new er2.a();

		// Token: 0x04000C5C RID: 3164
		public static Action<ej0> b;

		// Token: 0x04000C5D RID: 3165
		public static Action<ej0> c;
	}
}
