using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.References;

// Token: 0x02001282 RID: 4738
[eiz("SKCEAS")]
[a(typeof(bim))]
[Serializable]
public sealed class ddh : bim
{
	// Token: 0x060066EC RID: 26348 RVA: 0x002BB60C File Offset: 0x002B980C
	private ddh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060066ED RID: 26349 RVA: 0x002BB618 File Offset: 0x002B9818
	public ddh(c5x A_0) : base(A_0)
	{
		base.l(false);
	}

	// Token: 0x060066EE RID: 26350 RVA: 0x002BB62C File Offset: 0x002B982C
	protected override void mz(c5x A_0, string A_1 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.h.b != null && serviceOrThrow.aqu() != null)
		{
			List<int> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<int>>("xpbl_gy_skerderGravesRandomizedList");
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(bp5.l, new int?(0)).Value;
			if (classPropertyValue != null && A_0.h.b != null)
			{
				int num = -1;
				foreach (string text in base.a8().b())
				{
					if (text.StartsWith("GraveRope_", StringComparison.OrdinalIgnoreCase))
					{
						string[] array = text.Split(new string[]
						{
							"_"
						}, StringSplitOptions.None);
						int num2;
						if (array.Length > 1 && int.TryParse(array[1], out num2))
						{
							num = num2;
							break;
						}
						break;
					}
				}
				if (num >= 0)
				{
					bool flag = classPropertyValue[num] == value;
					azm a_ = this.a(A_0.h.b.aa() as e3q, flag);
					ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
					List<ble> list = new List<ble>();
					j7 aspect = A_0.GetAspect<j7>();
					if (aspect != null)
					{
						list.Add(aspect);
					}
					x4 x = new x4();
					x.a(base.a8());
					x.a("interface");
					x.c("Corpse");
					list.Add(x);
					new PropertyCollection()["IsCorrectSkerder"] = flag;
					serviceOrThrow2.amv(a_, A_0, base.a8(), list, false, false, false, new PropertyCollection(), true, false);
				}
			}
		}
	}

	// Token: 0x060066EF RID: 26351 RVA: 0x002BB810 File Offset: 0x002B9A10
	private void a(c5x A_0)
	{
		c3n c3n = dgk.Get<cxy>();
		if (c3n != null)
		{
			eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.h.b)), null) as eu7;
			if (eu != null)
			{
				cp.b(eu, A_0, A_0);
			}
		}
	}

	// Token: 0x060066F0 RID: 26352 RVA: 0x002BB85C File Offset: 0x002B9A5C
	private azm a(e3q A_0, bool A_1)
	{
		azm azm = new azm();
		azm.b(true);
		azm.a(true);
		ax8 ax = new ax8("player");
		azm.a().Add(ax);
		ax8 ax2 = new ax8("interface");
		azm.a().Add(ax2);
		ad7 ad = new ad7();
		if (A_1)
		{
			ad.f()["English"] = "::Гигантский труп, обёрнутый чешуйчатой змеиной кожей и заключённый в кости, медленно гниёт, источая едкий запах. При желании вы могли бы пролезть к трупу, чтобы обыскать его.::";
		}
		else
		{
			ad.f()["English"] = "::Огромный труп, обёрнутый чешуйчатой змеиной кожей и заключённый в кости, медленно гниёт, источая едкий запах. При желании вы могли бы пролезть к трупу, чтобы обыскать его.::";
		}
		ad.Questioner = ax2;
		ad.Answerer = ax;
		azm.a(ad);
		foreach (euy a_ in dbp.a)
		{
			this.a(ad, a_, A_1);
		}
		atr atr = new atr();
		atr.f()["English"] = "::Оставить это.::";
		ad.PossibleAnswers.Add(atr);
		return azm;
	}

	// Token: 0x060066F1 RID: 26353 RVA: 0x002BB978 File Offset: 0x002B9B78
	private void a(ad7 A_0, euy A_1, bool A_2)
	{
		if (A_1.c.Count == 0)
		{
			atr atr = new atr();
			atr.f()["English"] = string.Format("::Поискать {0}.::", A_1.b);
			if (A_2)
			{
				Collection<esc> collection = atr.e();
				b6e b6e = new b6e();
				b6e.a(new eh(A_1.a));
				collection.Add(b6e);
			}
			else
			{
				Collection<esc> collection2 = atr.e();
				b6e b6e2 = new b6e();
				b6e2.a(new eh("incorrectPart"));
				collection2.Add(b6e2);
			}
			A_0.PossibleAnswers.Add(atr);
			return;
		}
		ad7 ad = new ad7();
		ad.f()["English"] = string.Format("::Вы изучаете {0}.::", A_1.b);
		ad.Questioner = A_0.Questioner;
		ad.Answerer = A_0.Answerer;
		atr atr2 = new atr();
		atr2.f()["English"] = string.Format("::Изучить {0}.::", A_1.b);
		atr2.PossibleNextSteps.Add(ad);
		A_0.PossibleAnswers.Add(atr2);
		foreach (euy a_ in A_1.c)
		{
			this.a(ad, a_, A_2);
		}
		atr atr3 = new atr();
		atr3.f()["English"] = "::Назад.::";
		atr3.PossibleNextSteps.Add(A_0);
		ad.PossibleAnswers.Add(atr3);
	}
}
