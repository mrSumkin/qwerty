using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001392 RID: 5010
[bs6("HFX:StriderParasiticInfestation")]
[eiz("SPIHI2")]
[Serializable]
public sealed class ela : cpl, ISerializable
{
	// Token: 0x06007143 RID: 28995 RVA: 0x002F8CBC File Offset: 0x002F6EBC
	private ela(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007144 RID: 28996 RVA: 0x002F8CC8 File Offset: 0x002F6EC8
	public ela()
	{
	}

	// Token: 0x06007145 RID: 28997 RVA: 0x002F8CD4 File Offset: 0x002F6ED4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		if (base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(ela.a.a.a)), new Func<csk, int>(ela.a.a.b)) > 0)
			{
				if (!base.b().aa().Passive && !base.b().aa().b(d8o.e))
				{
					List<zh> list = base.b().aa().StatusEffects.Get<zh>();
					if (list == null || list.Count < zh.c)
					{
						base.b().aa().StatusEffects.a(new zh(), false, false, false);
					}
				}
				else
				{
					etm a_ = new etm(new ap9(base.b().aa()), "заражению паразитами");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x02001393 RID: 5011
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007148 RID: 29000 RVA: 0x002F8E98 File Offset: 0x002F7098
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Bio;
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x002F8EA4 File Offset: 0x002F70A4
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E47 RID: 11847
		public static readonly ela.a a = new ela.a();

		// Token: 0x04002E48 RID: 11848
		public static Func<csk, bool> b;

		// Token: 0x04002E49 RID: 11849
		public static Func<csk, int> c;
	}
}
