using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020003A2 RID: 930
[fe("rnd_feastingLurkers")]
public sealed class s9 : b5g
{
	// Token: 0x0600198F RID: 6543 RVA: 0x000875C4 File Offset: 0x000857C4
	public s9(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Eat", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(s9.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x0008764C File Offset: 0x0008584C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && !this.Subject.a8().h.b.aa().IsInCombat && aw1.a(this.Subject.a8(), base.GetCortexProperty<bt4>(ddq.ay, null), true))
		{
			TimeSpan? timeSpan = new TimeSpan?(base.GetCortexProperty<TimeSpan>(s9.a, default(TimeSpan)));
			return timeSpan == null || timeSpan.Value <= A_0;
		}
		return false;
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x000876E8 File Offset: 0x000858E8
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[s9.a] = A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(8, 20));
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			serviceOrThrow.aqu().v().b();
			string str = "";
			if (this.Subject.a8().h.b != null && this.Subject.a8().h.b.aa().Gender == Gender.Female)
			{
				str = "";
			}
			string[] array = new string[]
			{
				"::хруст:: М-м-м... ::хруст::",
				"Да... *Да*!",
				"М-м-н... Сочное!",
				"::чавк-чавк-чавк::",
				"М-м-м... Ам-м-м... Р-р-р...",
				"::хруст:: ::хруст::",
				str + "Вкусно, м-м-м... ::хруст::",
				"Вкусняшка...",
				"::скалится:: А-р-р..."
			};
			if (this.Subject.a8().u.b != null)
			{
				this.Subject.a8().u.b.a(array[cuo.a.Next(0, array.Length - 1)], true, null, null);
			}
		}
		return ej1.b;
	}

	// Token: 0x04000E90 RID: 3728
	private new static readonly string a = "NextLineTime";

	// Token: 0x020003A3 RID: 931
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001995 RID: 6549 RVA: 0x00087884 File Offset: 0x00085A84
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000E91 RID: 3729
		public static readonly s9.a a = new s9.a();

		// Token: 0x04000E92 RID: 3730
		public static Func<bool, float> b;
	}
}
