using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002E1 RID: 737
[apc("lemurianHandmaiden")]
public sealed class b47 : esk
{
	// Token: 0x060015B7 RID: 5559 RVA: 0x00066EC8 File Offset: 0x000650C8
	public b47()
	{
		arr arr = Enumerable.FirstOrDefault<arr>(Enumerable.Where<arr>(this.c.a, new Func<arr, bool>(this.a)));
		if (arr != null)
		{
			this.c.a.Remove(arr);
		}
		this.a = new ej0(new Action<ej0>(b47.a.a.a));
		this.a.a = this.c;
		this.b = new ej0(new Action<ej0>(b47.a.a.b));
		this.b.a = this.c;
		List<arr> list = this.c.a;
		int index = this.c.a.Count - 1;
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(b47.a.a.b));
		array[1] = new arr(this.a, new Func<e1k, bool>(b47.a.a.a));
		list.InsertRange(index, array);
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x0006701C File Offset: 0x0006521C
	[CompilerGenerated]
	private new bool a(arr A_0)
	{
		return A_0.a == this.g;
	}

	// Token: 0x04000C5E RID: 3166
	private new ej0 a;

	// Token: 0x04000C5F RID: 3167
	private new ej0 b;

	// Token: 0x020002E2 RID: 738
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x00067044 File Offset: 0x00065244
		internal void a(ej0 A_0)
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("xpbl_LemurianHandmaidenBladesSheath"), null, null, null);
			a4s.b(new ar7(A_0.b().g().a8()));
			list.Add(a4s);
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom4, dz6.b(cux.a), 0, null, 1));
			List<auv> list2 = awx.ad();
			ar ar = new ar();
			ar.a(WeaponKey.Primary);
			a4s a4s2 = new a4s(ar, null, null, null);
			a4s2.b(new ar7(A_0.b().g().a8()));
			list2.Add(a4s2);
			A_0.b().i().b(awx, atp.a);
			dz6.a(awx);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00067124 File Offset: 0x00065324
		internal void b(ej0 A_0)
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("xpbl_LemurianHandmaidenBladesShing"), null, null, null);
			a4s.b(new ar7(A_0.b().g().a8()));
			list.Add(a4s);
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom3, dz6.b(100), 0, null, 1));
			List<auv> list2 = awx.ad();
			ar ar = new ar();
			ar.a(WeaponKey.Secondary);
			a4s a4s2 = new a4s(ar, null, null, null);
			a4s2.b(new ar7(A_0.b().g().a8()));
			list2.Add(a4s2);
			A_0.b().i().b(awx, atp.a);
			dz6.a(awx);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00067200 File Offset: 0x00065400
		internal bool b(e1k A_0)
		{
			if (A_0.g().aa().Offense.au() != WeaponKey.Secondary)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc != null && amc.a8() != null && !amc.aa().Dead)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00067264 File Offset: 0x00065464
		internal bool a(e1k A_0)
		{
			if (A_0.g().aa().Offense.au() != WeaponKey.Primary)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc == null || amc.a8() == null || amc.aa().Dead)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000C60 RID: 3168
		public static readonly b47.a a = new b47.a();

		// Token: 0x04000C61 RID: 3169
		public static Action<ej0> b;

		// Token: 0x04000C62 RID: 3170
		public static Action<ej0> c;

		// Token: 0x04000C63 RID: 3171
		public static Func<e1k, bool> d;

		// Token: 0x04000C64 RID: 3172
		public static Func<e1k, bool> e;
	}
}
