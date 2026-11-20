using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AEF RID: 6895
[eiz("AEEC")]
[Serializable]
public sealed class br1 : els, ISerializable
{
	// Token: 0x06009562 RID: 38242 RVA: 0x003A9C40 File Offset: 0x003A7E40
	private br1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("AEEC:PD");
	}

	// Token: 0x06009563 RID: 38243 RVA: 0x003A9C5C File Offset: 0x003A7E5C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AEEC:PD", this.b);
	}

	// Token: 0x06009564 RID: 38244 RVA: 0x003A9C78 File Offset: 0x003A7E78
	public br1(efk A_0, int A_1, int A_2) : base(br1.a, "Опутывание едкой кислотой", ci8.c)
	{
		this.b = A_2;
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "DamageType.CorrosiveAcid";
		base.VisualEffects.Add(new ud(this, "CorrosiveAcidBlobEntanglement"));
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		cwt cwt = new cwt();
		if (A_0 != null)
		{
			cwt.i = new ap9(A_0);
		}
		cwt.l = true;
		cwt.e = false;
		cwt.r = true;
		cwt.f = new List<csk>
		{
			new csk(DamageType.Acid, A_2)
		};
		cwt.q = false;
		cwt.b = true;
		cwt.v = "опутывание едкой кислотой";
		cwt.ad["IsAcidWeapon"] = true;
		base.StaticEffects.Add(new ap0());
		base.DynamicEffects.Add(new vf(cwt, cwt, new br1.a()));
	}

	// Token: 0x06009565 RID: 38245 RVA: 0x003A9D7C File Offset: 0x003A7F7C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CorrosiveAcidicEntanglement", new object[]
		{
			this.b,
			c18.bl
		});
	}

	// Token: 0x04003985 RID: 14725
	public new static readonly string a = "acidicEntanglement";

	// Token: 0x04003986 RID: 14726
	private int b;

	// Token: 0x02001AF0 RID: 6896
	[eiz("AEECa")]
	[Serializable]
	private new sealed class a : j5, ISerializable
	{
		// Token: 0x06009567 RID: 38247 RVA: 0x003A9DB8 File Offset: 0x003A7FB8
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x003A9DC0 File Offset: 0x003A7FC0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x003A9DC4 File Offset: 0x003A7FC4
		public a()
		{
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x003A9DCC File Offset: 0x003A7FCC
		public void aft(efk A_0, cwt A_1, cru A_2)
		{
			if (A_2 != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_2.a, new Func<csk, bool>(br1.a.a.a.b)), new Func<csk, int>(br1.a.a.a.a)) > 0)
				{
					A_0.StatusEffects.a(new deu(deu.c * d0u.b)
					{
						Stacks = c18.bl
					}, false, false, false);
				}
			}
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x003A9E64 File Offset: 0x003A8064
		public object Clone()
		{
			return new br1.a();
		}

		// Token: 0x02001AF1 RID: 6897
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600956E RID: 38254 RVA: 0x003A9E80 File Offset: 0x003A8080
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Acid;
			}

			// Token: 0x0600956F RID: 38255 RVA: 0x003A9E8C File Offset: 0x003A808C
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003987 RID: 14727
			public static readonly br1.a.a a = new br1.a.a();

			// Token: 0x04003988 RID: 14728
			public static Func<csk, bool> b;

			// Token: 0x04003989 RID: 14729
			public static Func<csk, int> c;
		}
	}
}
