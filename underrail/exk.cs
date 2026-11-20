using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003EB RID: 1003
[fe("suicideBot")]
public class exk : am2
{
	// Token: 0x06001AD4 RID: 6868 RVA: 0x000917D4 File Offset: 0x0008F9D4
	public exk(bm6 A_0) : base(A_0)
	{
		e8n e8n = Enumerable.First<c96>(Enumerable.Where<c96>((Enumerable.First<c96>(Enumerable.Where<c96>(base.g(), new Func<c96, bool>(exk.a.a.a))) as pd).g(), new Func<c96, bool>(exk.a.a.c))) as e8n;
		e8n.g().Remove(Enumerable.First<c96>(Enumerable.Where<c96>(e8n.g(), new Func<c96, bool>(exk.a.a.b))));
		pd pd = e8n;
		int a_ = 0;
		List<c96> list = new List<c96>();
		list.Add(new byh("MoveToKamikazeTarget", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(exk.a.a.b), null)
		{
			e = false
		});
		list.Add(new b64("Explode", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(exk.a.a.a), null));
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

	// Token: 0x06001AD5 RID: 6869 RVA: 0x000919C0 File Offset: 0x0008FBC0
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		amc amc = new bzv(this.Subject.y6()).g();
		return amc != null && amc.a8() != null && !amc.aa().Dead && !base.h().aa().SpecialStates.b && base.h().aa().IsInControl && this.Subject.a8().k.b != null;
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x00091A50 File Offset: 0x0008FC50
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

	// Token: 0x06001AD7 RID: 6871 RVA: 0x00091B08 File Offset: 0x0008FD08
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = new bzv(this.Subject.y6()).g();
		if (amc != null && amc.a8() != null && !amc.aa().Dead && base.h().aa().IsInControl)
		{
			blk blk = new bzv(this.Subject.y6()).c(amc.a8().qe());
			if (blk.b() && blk.a().f() == cem.d)
			{
				return aw1.b(this.Subject.a8(), amc.a8()) < 3.0;
			}
		}
		return false;
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x00091BC4 File Offset: 0x0008FDC4
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.aa().a(null, null, false);
		return ej1.b;
	}

	// Token: 0x020003EC RID: 1004
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001ADB RID: 6875 RVA: 0x00091C08 File Offset: 0x0008FE08
		internal bool a(c96 A_0)
		{
			return A_0.Name == "CombatNearEnemies";
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00091C1C File Offset: 0x0008FE1C
		internal bool c(c96 A_0)
		{
			return A_0.Name == "FocusPrimaryTarget";
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00091C30 File Offset: 0x0008FE30
		internal bool b(c96 A_0)
		{
			return A_0.Name == "AutoAttackCurrentTarget";
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00091C44 File Offset: 0x0008FE44
		internal float b(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00091C4C File Offset: 0x0008FE4C
		internal float a(bool A_0)
		{
			if (A_0)
			{
				return float.MaxValue;
			}
			return 0.75f;
		}

		// Token: 0x04000EFF RID: 3839
		public static readonly exk.a a = new exk.a();

		// Token: 0x04000F00 RID: 3840
		public static Func<c96, bool> b;

		// Token: 0x04000F01 RID: 3841
		public static Func<c96, bool> c;

		// Token: 0x04000F02 RID: 3842
		public static Func<c96, bool> d;

		// Token: 0x04000F03 RID: 3843
		public static Func<bool, float> e;

		// Token: 0x04000F04 RID: 3844
		public static Func<bool, float> f;
	}
}
