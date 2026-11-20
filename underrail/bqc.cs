using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x020003D1 RID: 977
[fe("cc_gauntletRunner")]
public sealed class bqc : b5g
{
	// Token: 0x06001A50 RID: 6736 RVA: 0x0008DED0 File Offset: 0x0008C0D0
	public bqc(bm6 A_0) : base(A_0)
	{
		c96[] array = new c96[1];
		array[0] = new byh("Pull lever", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(bqc.a.a.a), null)
		{
			e = false
		};
		base.a(array);
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x0008DF40 File Offset: 0x0008C140
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		Guid cortexProperty = base.GetCortexProperty<Guid>("LeverId", default(Guid));
		bim bim = new EntityAspectReference<bim, bim>(this.Subject.a8().Area, cortexProperty).ao();
		return bim != null && bim.ab();
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x0008DF94 File Offset: 0x0008C194
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().k.b != null)
		{
			Guid cortexProperty = base.GetCortexProperty<Guid>("LeverId", default(Guid));
			bim bim = new EntityAspectReference<bim, bim>(this.Subject.a8().Area, cortexProperty).ao();
			if (bim != null && bim.ab())
			{
				return this.Subject.a8().k.b.b(bim.a8(), bim.t(), 1, false, null);
			}
		}
		return null;
	}

	// Token: 0x020003D2 RID: 978
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A55 RID: 6741 RVA: 0x0008E03C File Offset: 0x0008C23C
		internal float a(bool A_0)
		{
			return 0.99f;
		}

		// Token: 0x04000EC7 RID: 3783
		public static readonly bqc.a a = new bqc.a();

		// Token: 0x04000EC8 RID: 3784
		public static Func<bool, float> b;
	}
}
