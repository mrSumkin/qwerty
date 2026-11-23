using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000D09 RID: 3337
[e79("Cc_JookhelaAttacks")]
public sealed class qk : dgy
{
	// Token: 0x06004A0F RID: 18959 RVA: 0x001F1F08 File Offset: 0x001F0108
	public qk()
	{
		qk.a a = new qk.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				aud aud = a.b.Area;
				if (aud != null)
				{
					a.c = (new ar7(new Guid("d2dbfb3c-3247-46e6-8a7d-2f9a62eac32f"), aud).ao() as c5x);
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.a));
					array[num] = dva;
					base.a(array);
				}
			}
		}
	}

	// Token: 0x02000D0A RID: 3338
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A11 RID: 18961 RVA: 0x001F1FDC File Offset: 0x001F01DC
		internal bool a(e6d A_0)
		{
			if (this.c != null)
			{
				awq.a(this.c, this.b, true, true, true, true, false, false);
				if (this.c.h.b != null && !this.c.h.b.aa().Dead)
				{
					int num;
					if (this.a.aqu().ae() >= GameDifficulty.Hard)
					{
						num = 2;
					}
					else if (this.a.aqu().ae() >= GameDifficulty.Normal)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
					if (num > 0)
					{
						this.b.c().a("DarkSecretReveal");
					}
					for (int i = 1; i <= num; i++)
					{
						new d8g(this.c, this.c, new bt4("dopb" + i.ToString()), new a1q?(new a1q(DamageType.Electricity, 15, 30)), false, new Guid?(this.b.qe()), "Тень Жукелы", null, null).ym(this.c, null, null);
					}
				}
			}
			return true;
		}

		// Token: 0x04001D79 RID: 7545
		public cnk a;

		// Token: 0x04001D7A RID: 7546
		public c5x b;

		// Token: 0x04001D7B RID: 7547
		public c5x c;
	}
}
