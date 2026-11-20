using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000BCC RID: 3020
public sealed class ewh : eny
{
	// Token: 0x0600452B RID: 17707 RVA: 0x001C1CEC File Offset: 0x001BFEEC
	public override string mt()
	{
		return "hypnoGoggles";
	}

	// Token: 0x0600452C RID: 17708 RVA: 0x001C1CF4 File Offset: 0x001BFEF4
	public override int? mu()
	{
		return new int?(5);
	}

	// Token: 0x0600452D RID: 17709 RVA: 0x001C1CFC File Offset: 0x001BFEFC
	public override int? mv()
	{
		return new int?(15);
	}

	// Token: 0x0600452E RID: 17710 RVA: 0x001C1D08 File Offset: 0x001BFF08
	public override void mw(coh A_0, int A_1)
	{
		int num = base.b(A_1);
		base.mw(A_0, num);
		bqu bqu = A_0.Definition as bqu;
		if (bqu != null)
		{
			int a_ = (int)d05.b(10.0, (double)num * 1.75 * (0.75 + zp.a.NextDouble() * 0.5), 30.0);
			int value = 25 + num * 5;
			float a_2 = Math.Max(0.01f, Convert.ToSingle(Math.Round(0.01 * Math.Ceiling((double)(num - 3) / 3.1) * zp.a.NextDouble(), 2)));
			dpw dpw = Enumerable.FirstOrDefault<dpw>(Enumerable.Where<dpw>(Enumerable.OfType<dpw>(bqu.ar()), new Func<dpw, bool>(ewh.a.a.a)));
			if (dpw != null)
			{
				dpw.a(a_);
			}
			bi0 bi = Enumerable.FirstOrDefault<bi0>(Enumerable.OfType<bi0>(bqu.ar()));
			if (bi != null)
			{
				bi.a(a_2);
			}
			bqu.c(new int?(value));
			bqu.g(num);
			base.a(bqu, num, 0.35);
		}
	}

	// Token: 0x02000BCD RID: 3021
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004532 RID: 17714 RVA: 0x001C1E6C File Offset: 0x001C006C
		internal bool a(dpw A_0)
		{
			return A_0.SkillName == "Persuasion";
		}

		// Token: 0x04001C6C RID: 7276
		public static readonly ewh.a a = new ewh.a();

		// Token: 0x04001C6D RID: 7277
		public static Func<dpw, bool> b;
	}
}
