using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000403 RID: 1027
[fe("soldier_operateIdle")]
public sealed class aj1 : b5g
{
	// Token: 0x06001B4C RID: 6988 RVA: 0x00094ECC File Offset: 0x000930CC
	public aj1(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("Operate", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(aj1.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x00094F44 File Offset: 0x00093144
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().h.b.aa().IsInControl && !this.Subject.a8().h.b.aa().IsInCombat)
		{
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null && aw1.a(this.Subject.a8(), classPropertyValue, true))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x00094FD0 File Offset: 0x000931D0
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		return new e4t(this.Subject.a8().h.b, CharacterState.Operating, cux.a, 0, null, 100);
	}

	// Token: 0x02000404 RID: 1028
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B51 RID: 6993 RVA: 0x00095020 File Offset: 0x00093220
		internal float a(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x04000F2D RID: 3885
		public static readonly aj1.a a = new aj1.a();

		// Token: 0x04000F2E RID: 3886
		public static Func<bool, float> b;
	}
}
