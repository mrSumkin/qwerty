using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003AF RID: 943
[fe("machineGunTurret")]
public class auz : bwv
{
	// Token: 0x060019DB RID: 6619 RVA: 0x0008AC00 File Offset: 0x00088E00
	public override int or()
	{
		return 1000;
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x0008AC0C File Offset: 0x00088E0C
	public auz(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new b64("Overwatch", new Func<TimeSpan, double, bool>(auz.a.a.a), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(auz.a.a.a), null));
		base.a(list);
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x0008AC8C File Offset: 0x00088E8C
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().a())
		{
			b2w b2w = Enumerable.FirstOrDefault<b2w>(base.h().aa().StatusEffects.Get<b2w>());
			if (b2w == null || b2w.Power < base.h().aa().Offense.n())
			{
				b2w = new b2w(base.h().aa().Offense.n(), 0);
				base.h().aa().StatusEffects.a(b2w, false, false, false);
			}
			return ej1.b;
		}
		return ej1.c;
	}

	// Token: 0x020003B0 RID: 944
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060019E0 RID: 6624 RVA: 0x0008AD3C File Offset: 0x00088F3C
		internal bool a(TimeSpan A_0, double A_1)
		{
			return false;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0008AD40 File Offset: 0x00088F40
		internal float a(bool A_0)
		{
			return 5.01f;
		}

		// Token: 0x04000E99 RID: 3737
		public static readonly auz.a a = new auz.a();

		// Token: 0x04000E9A RID: 3738
		public static Func<TimeSpan, double, bool> b;

		// Token: 0x04000E9B RID: 3739
		public static Func<bool, float> c;
	}
}
