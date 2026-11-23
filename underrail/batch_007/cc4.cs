using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;

// Token: 0x020012F4 RID: 4852
[global::a(typeof(bim))]
[eiz("PC2")]
[Serializable]
public sealed class cc4 : bim, c98
{
	// Token: 0x06006BE2 RID: 27618 RVA: 0x002D4B3C File Offset: 0x002D2D3C
	private cc4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006BE3 RID: 27619 RVA: 0x002D4B48 File Offset: 0x002D2D48
	public cc4(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006BE4 RID: 27620 RVA: 0x002D4B54 File Offset: 0x002D2D54
	public void r7(eds A_0)
	{
		if ((this.a += A_0.b.TotalMilliseconds) > 1000.0)
		{
			this.a = 0.0;
			this.a();
		}
	}

	// Token: 0x06006BE5 RID: 27621 RVA: 0x002D4BA0 File Offset: 0x002D2DA0
	public override void mx()
	{
		base.mx();
		this.a = 1000.0;
	}

	// Token: 0x06006BE6 RID: 27622 RVA: 0x002D4BBC File Offset: 0x002D2DBC
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (base.a8().a() && A_0 != null && A_0.h.b != null)
		{
			azm a_ = this.a(A_0.h.b.aa() as e3q);
			ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
			List<ble> list = new List<ble>();
			j7 aspect = A_0.GetAspect<j7>();
			if (aspect != null)
			{
				list.Add(aspect);
			}
			x4 x = new x4();
			x.a(base.a8());
			x.a("interface");
			x.c("Персональный компьютер");
			list.Add(x);
			serviceOrThrow.amv(a_, A_0, base.a8(), list, false, false, false, new PropertyCollection(), true, false);
		}
	}

	// Token: 0x06006BE7 RID: 27623 RVA: 0x002D4C74 File Offset: 0x002D2E74
	private azm a(e3q A_0)
	{
		azm azm = new azm();
		ax8 ax = new ax8("player");
		azm.a().Add(ax);
		ax8 a_ = new ax8("interface");
		azm.a().Add(ax);
		ad7 ad = new ad7();
		ad.f()["English"] = "::Уровень безопасности: " + A_0.Name + " (персональный)::\r\n::Уровень доступа: ПОЛНЫЙ::";
		ad.Questioner = a_;
		ad.Answerer = ax;
		azm.a(ad);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			ad7 ad2 = new ad7();
			ad2.f()["English"] = string.Format("::Новые личные сообщения: {0}::", serviceOrThrow.aqu().w().Count);
			ad2.Questioner = a_;
			ad2.Answerer = ax;
			for (int i = serviceOrThrow.aqu().w().Count - 1; i >= 0; i--)
			{
				cqh a_2 = serviceOrThrow.aqu().w()[i];
				zr zr = new zr();
				zr.a(a_2);
				zr.a(true);
				ad7 ad3 = new ad7(Guid.NewGuid().ToString());
				ad3.f()["English"] = string.Format("::{0}::", zr.el(A_0));
				ad3.PossibleNextSteps.Add(ad2);
				ad3.Questioner = a_;
				ad3.Answerer = ax;
				atr atr = new atr();
				atr.f()["English"] = string.Format("::{0}::", zr.ep(A_0));
				atr.a(new aar(zr, A_0));
				atr.e().Add(new coy(zr, A_0, null, atr));
				atr.PossibleNextSteps.Add(ad3);
				ad2.PossibleAnswers.Add(atr);
			}
			atr atr2 = new atr();
			atr2.f()["English"] = string.Format("::Назад::", new object[0]);
			atr2.PossibleNextSteps.Add(ad);
			ad2.PossibleAnswers.Add(atr2);
			atr atr3 = new atr();
			atr3.f()["English"] = "::Личные сообщения::";
			atr3.PossibleNextSteps.Add(ad2);
			ad.PossibleAnswers.Add(atr3);
		}
		atr atr4 = new atr();
		atr4.f()["English"] = "::Выход::";
		ad.PossibleAnswers.Add(atr4);
		return azm;
	}

	// Token: 0x06006BE8 RID: 27624 RVA: 0x002D4F14 File Offset: 0x002D3114
	private void a()
	{
		if (base.a8().p.b != null && base.a8().p.b.a.Count >= 1)
		{
			List<cd0> list = base.a8().p.b.a;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (Enumerable.Any<cqh>(serviceOrThrow.aqu().w(), new Func<cqh, bool>(cc4.a.a.a)))
				{
					if (list.Count > 1 && !(list[1] is etz))
					{
						list.RemoveAt(1);
					}
					if (list.Count == 1)
					{
						etz etz = new etz(base.a8());
						etz.b = new Point(list[0].b.X + 1, list[0].b.Y);
						etz.a = "Objects\\Devices\\PersonalLaptop";
						etz.c = new Color?(new Color(255, 255, 255, 255));
						etz.a(1);
						etz.b(1);
						etz.c(2);
						etz.d(350);
						list.Insert(1, etz);
						return;
					}
				}
				else
				{
					if (list.Count > 1 && list[1] is etz)
					{
						list.RemoveAt(1);
					}
					if (list.Count == 1)
					{
						list.Insert(1, new cd0(base.a8())
						{
							b = new Point(list[0].b.X + 1, list[0].b.Y),
							a = "Objects\\Devices\\PersonalLaptop",
							c = new Color?(new Color(255, 255, 255))
						});
					}
				}
			}
		}
	}

	// Token: 0x04002C49 RID: 11337
	private new double a;

	// Token: 0x020012F5 RID: 4853
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006BEB RID: 27627 RVA: 0x002D5128 File Offset: 0x002D3328
		internal bool a(cqh A_0)
		{
			return !A_0.Read;
		}

		// Token: 0x04002C4A RID: 11338
		public static readonly cc4.a a = new cc4.a();

		// Token: 0x04002C4B RID: 11339
		public static Func<cqh, bool> b;
	}
}
