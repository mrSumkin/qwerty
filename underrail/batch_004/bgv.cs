using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AD2 RID: 6866
[eiz("RAEEC")]
[Serializable]
public sealed class bgv : els, ISerializable
{
	// Token: 0x060094D7 RID: 38103 RVA: 0x003A7C7C File Offset: 0x003A5E7C
	private bgv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("AEEC:PD");
	}

	// Token: 0x060094D8 RID: 38104 RVA: 0x003A7C98 File Offset: 0x003A5E98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AEEC:PD", this.b);
	}

	// Token: 0x060094D9 RID: 38105 RVA: 0x003A7CB4 File Offset: 0x003A5EB4
	public bgv(efk A_0, int A_1, int A_2) : base(bgv.a, "Опрыскивание кислотой ржавчиной", ci8.c)
	{
		this.b = A_2;
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "DamageType.RustingAcid";
		base.VisualEffects.Add(new ud(this, "RustingAcidBlobEntanglement"));
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
		cwt.v = "опрыскивание кислотой ржавчиной";
		cwt.ad["IsAcidWeapon"] = true;
		base.StaticEffects.Add(new ap0());
		base.DynamicEffects.Add(new vf(cwt, cwt, new bgv.a()));
	}

	// Token: 0x060094DA RID: 38106 RVA: 0x003A7DB8 File Offset: 0x003A5FB8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/RustingAcidicEntanglement", new object[]
		{
			this.b,
			c18.bq
		});
	}

	// Token: 0x04003954 RID: 14676
	public new static readonly string a = "acidicEntanglement";

	// Token: 0x04003955 RID: 14677
	private int b;

	// Token: 0x02001AD3 RID: 6867
	[eiz("RAEECa")]
	[Serializable]
	private new sealed class a : j5, ISerializable
	{
		// Token: 0x060094DC RID: 38108 RVA: 0x003A7DF4 File Offset: 0x003A5FF4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x003A7DFC File Offset: 0x003A5FFC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x003A7E00 File Offset: 0x003A6000
		public a()
		{
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x003A7E08 File Offset: 0x003A6008
		public void aft(efk A_0, cwt A_1, cru A_2)
		{
			if (A_2 != null && A_2.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_2.a, new Func<csk, bool>(bgv.a.a.a.b)), new Func<csk, int>(bgv.a.a.a.a)) > 0)
				{
					A_0.StatusEffects.a(new ce(ce.b * d0u.b)
					{
						Stacks = c18.bq
					}, false, false, false);
				}
			}
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x003A7EAC File Offset: 0x003A60AC
		public object Clone()
		{
			return new bgv.a();
		}

		// Token: 0x02001AD5 RID: 6869
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060094E4 RID: 38116 RVA: 0x003A7EC8 File Offset: 0x003A60C8
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Acid;
			}

			// Token: 0x060094E5 RID: 38117 RVA: 0x003A7ED4 File Offset: 0x003A60D4
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003956 RID: 14678
			public static readonly bgv.a.a a = new bgv.a.a();

			// Token: 0x04003957 RID: 14679
			public static Func<csk, bool> b;

			// Token: 0x04003958 RID: 14680
			public static Func<csk, int> c;
		}
	}
}
