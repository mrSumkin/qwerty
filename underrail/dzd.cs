using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000F7E RID: 3966
[eiz("SGYCTRL")]
[Serializable]
public sealed class dzd : Aspect<c5x>, bp1, cmm, chb
{
	// Token: 0x060050A7 RID: 20647 RVA: 0x00245150 File Offset: 0x00243350
	private dzd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.e = A_0.GetDouble("SGYCTRL:C");
	}

	// Token: 0x060050A8 RID: 20648 RVA: 0x0024516C File Offset: 0x0024336C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGYCTRL:C", this.e);
	}

	// Token: 0x060050A9 RID: 20649 RVA: 0x00245188 File Offset: 0x00243388
	public dzd(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060050AA RID: 20650 RVA: 0x00245194 File Offset: 0x00243394
	public void c9(TimeSpan A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && dh7.a != null && !string.IsNullOrEmpty(dh7.a.b) && string.Equals(dh7.a.b, "xpbl_gy_enter", StringComparison.OrdinalIgnoreCase))
		{
			double num = A_0.TotalMinutes * 0.5;
			double num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<double>(dzd.a, new double?(0.0)).Value;
			num2 = Math.Max(dzd.d, num2 - num);
			serviceOrThrow.aqu().r()[dzd.a] = num2;
			this.d();
			if (num2 < 70.0)
			{
				serviceOrThrow.aqu().r()[dzd.b] = false;
			}
		}
	}

	// Token: 0x060050AB RID: 20651 RVA: 0x00245284 File Offset: 0x00243484
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060050AC RID: 20652 RVA: 0x00245288 File Offset: 0x00243488
	public void r7(eds A_0)
	{
		double num = (double)d0u.b * 2.5;
		if (!dz6.e())
		{
			if ((this.e += A_0.b.TotalMilliseconds) >= num)
			{
				this.e -= num;
				this.e();
			}
		}
		else
		{
			this.e = 0.0;
		}
		this.d();
	}

	// Token: 0x060050AD RID: 20653 RVA: 0x00245300 File Offset: 0x00243500
	public void c()
	{
		this.e();
		this.d();
		this.e = 0.0;
	}

	// Token: 0x060050AE RID: 20654 RVA: 0x00245320 File Offset: 0x00243520
	public void mx()
	{
		this.d();
	}

	// Token: 0x060050AF RID: 20655 RVA: 0x00245328 File Offset: 0x00243528
	public void my()
	{
	}

	// Token: 0x060050B0 RID: 20656 RVA: 0x0024532C File Offset: 0x0024352C
	private void e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			double num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<double>(dzd.a, new double?(0.0)).Value;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(dzd.b, new bool?(false)).Value;
			num = Math.Min(100.0, num + 1.0);
			serviceOrThrow.aqu().r()[dzd.a] = num;
			if ((!value && num == 100.0) || (value && num >= 70.0))
			{
				this.b();
			}
		}
	}

	// Token: 0x060050B1 RID: 20657 RVA: 0x00245410 File Offset: 0x00243610
	private void d()
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null && base.a8() != null && base.a8().Zone != null)
		{
			double value = service.aqu().r().GetPrimitivePropertyValue<double>(dzd.a, new double?(0.0)).Value;
			double num = 1.0 - value / 120.0;
			int num2 = (int)(70.0 * num);
			Color a_ = new Color(num2, num2, num2);
			foreach (aud aud in base.a8().Zone.Areas)
			{
				if (aud.StartingLightning != a_)
				{
					aud.StartingLightning = a_;
					for (int i = 0; i < aud.Size.c; i++)
					{
						for (int j = 0; j < aud.Size.d; j++)
						{
							ak1 ak = aud.b(i, j);
							if (ak != null)
							{
								ak.e();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060050B2 RID: 20658 RVA: 0x00245574 File Offset: 0x00243774
	private void b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aqu().r()[dzd.b] = true;
		d60 addon = base.a8().Zone.GetAddon<d60>();
		if (addon != null && !(addon.ab5(dzd.c) is c5x))
		{
			ak1 ak = this.a();
			if (ak != null)
			{
				c5x c5x = vq.a(@is.a(true)[0], base.a8().Zone, new bt4(base.a8().Area.y8(), Vector3.Zero), false);
				if (c5x != null)
				{
					double num = 0.75 + (double)serviceOrThrow.aqu().ae() * 0.25;
					a1q value = new a1q(DamageType.Electricity, Convert.ToInt32(20.0 * num), Convert.ToInt32(35.0 * num));
					new d8g(null, c5x, new bt4(base.a8().Area.y8(), ak.Location.a()), new a1q?(value), false, new Guid?(aju.a), "Неупокоенные духи", dzd.c, new int?(1000000)).ym(null, null, null);
					c5x c5x2 = addon.ab5(dzd.c) as c5x;
					if (c5x2 != null)
					{
						do6 @do = new do6(c5x2);
						@do.a(true);
						do6 aspect = @do;
						c5x2.SetAspect<do6>(aspect);
						cm aspect2 = new cm(c5x2, Convert.ToInt32(60000.0 * (0.6 + (double)serviceOrThrow.aqu().ae() * 0.4)), false);
						c5x2.SetAspect<cm>(aspect2);
						anz anz = new anz(c5x2);
						anz.a(true);
						anz aspect3 = anz;
						c5x2.SetAspect<anz>(aspect3);
						if (c5x2.h.b != null)
						{
							c5x2.h.b.aa().BaseSightRange = 2f;
							c5x2.h.b.aa().BaseMovementSpeed = 0.75f;
							c5x2.h.b.aa().ImmunitiesBase |= CharacterImmunities.MindAffecting;
							c5x2.h.b.aa().EtherealBase = true;
							c5x2.h.b.aa().bl();
						}
						if (c5x2.t.b != null)
						{
							c5x2.t.b.y6().RemoveProperty(ddq.a3);
							c5x2.t.b.y6()[ddq.bz] = "player";
							c5x2.t.b.y6()[ddq.b0] = 0.1f;
						}
						c5x2.c().a("ghostSounds", "Xpbl_SavageGhost", 1f, c9z.a, true, false);
					}
					c5x.w();
					c5x.an();
				}
			}
		}
	}

	// Token: 0x060050B3 RID: 20659 RVA: 0x0024586C File Offset: 0x00243A6C
	private ak1 a()
	{
		List<ak1> list = new List<ak1>();
		for (int i = 0; i < base.a8().Area.Size.c; i++)
		{
			for (int j = 0; j < base.a8().Area.Size.d; j++)
			{
				ak1 ak = base.a8().Area.b(i, j);
				if (Enumerable.Count<b0b>(ak.c.Values, new Func<b0b, bool>(dzd.a.a.a)) > 0 && !aw1.a(ak, false, null, l9.a) && !ak.b(dm9.b))
				{
					list.Add(ak);
				}
			}
		}
		if (list.Count > 0)
		{
			return list[cuo.a.Next(list.Count)];
		}
		return null;
	}

	// Token: 0x04002112 RID: 8466
	public static readonly string a = "xpbl_gy_disturbanceLevel";

	// Token: 0x04002113 RID: 8467
	private static readonly string b = "xpbl_gy_guardianActive";

	// Token: 0x04002114 RID: 8468
	private static readonly string c = "GraveyardGuardian";

	// Token: 0x04002115 RID: 8469
	private static readonly double d = 30.0;

	// Token: 0x04002116 RID: 8470
	private double e;

	// Token: 0x02000F7F RID: 3967
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060050B7 RID: 20663 RVA: 0x002459A4 File Offset: 0x00243BA4
		internal bool a(b0b A_0)
		{
			return !A_0.aa;
		}

		// Token: 0x04002117 RID: 8471
		public static readonly dzd.a a = new dzd.a();

		// Token: 0x04002118 RID: 8472
		public static Func<b0b, bool> b;
	}
}
