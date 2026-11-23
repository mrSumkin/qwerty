using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000390 RID: 912
[fe("iceRemnant")]
public class c8h : am2
{
	// Token: 0x06001939 RID: 6457 RVA: 0x000845FC File Offset: 0x000827FC
	public c8h(bm6 A_0) : base(A_0)
	{
		e8n e8n = Enumerable.First<c96>(Enumerable.Where<c96>((Enumerable.First<c96>(Enumerable.Where<c96>(base.g(), new Func<c96, bool>(c8h.a.a.a))) as pd).g(), new Func<c96, bool>(c8h.a.a.c))) as e8n;
		e8n.g().Remove(Enumerable.First<c96>(Enumerable.Where<c96>(e8n.g(), new Func<c96, bool>(c8h.a.a.b))));
		pd pd = e8n;
		int a_ = 0;
		List<c96> list = new List<c96>();
		list.Add(new byh("MoveToKamikazeTarget", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(c8h.a.a.b), null)
		{
			e = false
		});
		list.Add(new b64("Explode", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(c8h.a.a.a), null));
		pd.a(a_, list);
		int num = base.g().IndexOf(Enumerable.First<aif>(Enumerable.OfType<aif>(base.g())));
		base.g().RemoveAt(num);
		base.a(num, new e1y("IdleMovement", new List<c96>
		{
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 5,
				c = 3
			},
			new aif("RestActivity")
		})
		{
			c = 0.5f
		});
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x000847E8 File Offset: 0x000829E8
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		amc amc = new bzv(this.Subject.y6()).g();
		return amc != null && amc.a8() != null && !amc.aa().Dead && !base.h().aa().SpecialStates.b && base.h().aa().IsInControl && this.Subject.a8().k.b != null;
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x00084878 File Offset: 0x00082A78
	[CompilerGenerated]
	private new cst c(TimeSpan A_0, double A_1)
	{
		amc amc = new bzv(this.Subject.y6()).g();
		if (amc != null && amc.a8() != null && !amc.aa().Dead && !base.h().aa().SpecialStates.b && base.h().aa().IsInControl && this.Subject.a8().k.b != null)
		{
			return this.Subject.a8().k.b.a(amc.a8(), 1.5f, 1, 0);
		}
		return null;
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x00084930 File Offset: 0x00082B30
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = new bzv(this.Subject.y6()).g();
		if (amc != null && amc.a8() != null && !amc.aa().Dead && base.h().aa().IsInControl)
		{
			blk blk = new bzv(this.Subject.y6()).c(amc.a8().qe());
			if (blk.b() && blk.a().f() == cem.d)
			{
				return aw1.b(this.Subject.a8(), amc.a8()) < 1.85;
			}
		}
		return false;
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x000849EC File Offset: 0x00082BEC
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.aa().a(null, null, false);
		this.Subject.a8().an();
		return ej1.b;
	}

	// Token: 0x02000391 RID: 913
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001940 RID: 6464 RVA: 0x00084A44 File Offset: 0x00082C44
		internal bool a(c96 A_0)
		{
			return A_0.Name == "CombatNearEnemies";
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00084A58 File Offset: 0x00082C58
		internal bool c(c96 A_0)
		{
			return A_0.Name == "FocusPrimaryTarget";
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00084A6C File Offset: 0x00082C6C
		internal bool b(c96 A_0)
		{
			return A_0.Name == "AutoAttackCurrentTarget";
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00084A80 File Offset: 0x00082C80
		internal float b(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00084A88 File Offset: 0x00082C88
		internal float a(bool A_0)
		{
			if (A_0)
			{
				return float.MaxValue;
			}
			return 0.75f;
		}

		// Token: 0x04000E77 RID: 3703
		public static readonly c8h.a a = new c8h.a();

		// Token: 0x04000E78 RID: 3704
		public static Func<c96, bool> b;

		// Token: 0x04000E79 RID: 3705
		public static Func<c96, bool> c;

		// Token: 0x04000E7A RID: 3706
		public static Func<c96, bool> d;

		// Token: 0x04000E7B RID: 3707
		public static Func<bool, float> e;

		// Token: 0x04000E7C RID: 3708
		public static Func<bool, float> f;
	}
}
