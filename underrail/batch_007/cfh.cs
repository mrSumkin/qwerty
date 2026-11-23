using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002C7 RID: 711
[apc("giantWeaver")]
public sealed class cfh : cqw
{
	// Token: 0x06001536 RID: 5430 RVA: 0x00062428 File Offset: 0x00060628
	public override bool ef()
	{
		return false;
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0006242C File Offset: 0x0006062C
	public cfh()
	{
		this.c = new fh(new arr[0]);
		this.a = new ej0(new Action<ej0>(cfh.a.a.a));
		this.a.a = this.i.b;
		this.e = new ej0(new Action<ej0>(cfh.a.a.b));
		this.e.a = this.j;
		this.d = new TryInvokeSpecialAbilityNode<adk>();
		this.d.a = this.e;
		this.d.b = this.p.a;
		this.b = new ej0(new Action<ej0>(cfh.a.a.c));
		this.b.a = this.i.b;
		fh fh = this.c;
		arr[] array = new arr[3];
		array[0] = new arr(this.d, new Func<e1k, bool>(this.a));
		array[1] = new arr(this.a, new Func<e1k, bool>(cfh.a.a.a));
		array[2] = new arr(this.b, null);
		fh.a(array);
		this.i.b = this.c;
		this.h.b = this.c;
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x000625D4 File Offset: 0x000607D4
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.d.b(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			if (A_0.c().y6().GetPrimitivePropertyValue<int>("webShotsCount", new int?(0)).Value >= 3)
			{
				return false;
			}
			amc amc = bzv.g();
			if (amc != null && !amc.aa().SpecialStates.b)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000BF0 RID: 3056
	private new ej0 a;

	// Token: 0x04000BF1 RID: 3057
	private new ej0 b;

	// Token: 0x04000BF2 RID: 3058
	private new fh c;

	// Token: 0x04000BF3 RID: 3059
	private new TryInvokeSpecialAbilityNode<adk> d;

	// Token: 0x04000BF4 RID: 3060
	private new ej0 e;

	// Token: 0x020002C8 RID: 712
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600153B RID: 5435 RVA: 0x0006266C File Offset: 0x0006086C
		internal void a(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00062694 File Offset: 0x00060894
		internal void b(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>("webShotsCount", new int?(0)).Value;
			num++;
			A_0.b().c().y6()["webShotsCount"] = num;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x000626F0 File Offset: 0x000608F0
		internal void c(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00062718 File Offset: 0x00060918
		internal bool a(e1k A_0)
		{
			bool flag = false;
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					if ((double)classPropertyValue.b(0) < 1.5)
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

		// Token: 0x04000BF5 RID: 3061
		public static readonly cfh.a a = new cfh.a();

		// Token: 0x04000BF6 RID: 3062
		public static Action<ej0> b;

		// Token: 0x04000BF7 RID: 3063
		public static Action<ej0> c;

		// Token: 0x04000BF8 RID: 3064
		public static Action<ej0> d;

		// Token: 0x04000BF9 RID: 3065
		public static Func<e1k, bool> e;
	}
}
