using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000413 RID: 1043
[fe("psionicDoppelganger")]
public class c8v : bwv
{
	// Token: 0x06001B7F RID: 7039 RVA: 0x000962C4 File Offset: 0x000944C4
	public c8v(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("DespawnDoppelganger", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(c8v.a.a.a), null));
		base.a(list);
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x00096330 File Offset: 0x00094530
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		dlo dlo = Enumerable.FirstOrDefault<dlo>(this.Subject.a8().h.b.aa().StatusEffects.Get<dlo>());
		if (dlo == null || dlo.TimeLeft <= 100.0)
		{
			return true;
		}
		Guid? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<Guid>(ddq.a3, null);
		if (primitivePropertyValue != null)
		{
			EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(this.Subject.a8().Area, primitivePropertyValue.Value);
			if (entityAspectReference.ao() == null || entityAspectReference.ao().aa().Dead)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000963F0 File Offset: 0x000945F0
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		awx awx = new awx();
		awx.a(awx.kh() | (m7.b | m7.k));
		awx.a(false);
		List<auv> list = awx.ad();
		ad6 ad = new ad6(this.Subject.a8());
		ad.b(1.0);
		ad.c(0.0);
		ad.a(0.001);
		list.Add(ad);
		awx.ad().Add(new c7(this.Subject.a8(), true, true, true, false));
		dz6.a(awx);
		return awx;
	}

	// Token: 0x02000414 RID: 1044
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x000964A0 File Offset: 0x000946A0
		internal float a(bool A_0)
		{
			return float.MaxValue;
		}

		// Token: 0x04000F42 RID: 3906
		public static readonly c8v.a a = new c8v.a();

		// Token: 0x04000F43 RID: 3907
		public static Func<bool, float> b;
	}
}
