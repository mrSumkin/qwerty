using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020012F0 RID: 4848
[global::a(typeof(bim))]
[eiz("CC2")]
[Serializable]
public sealed class yf : bim
{
	// Token: 0x06006BC1 RID: 27585 RVA: 0x002D3BC8 File Offset: 0x002D1DC8
	private yf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CC2:O");
		this.b = A_0.GetString("CC2:O1");
		this.d = (A_0.GetValue("CC2:O2", typeof(int?)) as int?);
		this.c = A_0.GetString("CC2:S");
		di7.ReadList<d6d>("CC2:HD", ref this.e, A_0);
		di7.ReadList<s0>("CC2:I", ref this.f, A_0);
	}

	// Token: 0x06006BC2 RID: 27586 RVA: 0x002D3C70 File Offset: 0x002D1E70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CC2:O", this.a);
		info.AddValue("CC2:O1", this.b);
		info.AddValue("CC2:O2", this.d);
		info.AddValue("CC2:S", this.c);
		di7.WriteList<d6d>("CC2:HD", this.e, info);
		di7.WriteList<s0>("CC2:I", this.f, info);
	}

	// Token: 0x06006BC3 RID: 27587 RVA: 0x002D3CF0 File Offset: 0x002D1EF0
	public string g()
	{
		return this.a;
	}

	// Token: 0x06006BC4 RID: 27588 RVA: 0x002D3CF8 File Offset: 0x002D1EF8
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006BC5 RID: 27589 RVA: 0x002D3D04 File Offset: 0x002D1F04
	public string b()
	{
		return this.b;
	}

	// Token: 0x06006BC6 RID: 27590 RVA: 0x002D3D0C File Offset: 0x002D1F0C
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006BC7 RID: 27591 RVA: 0x002D3D18 File Offset: 0x002D1F18
	public string d()
	{
		return this.c;
	}

	// Token: 0x06006BC8 RID: 27592 RVA: 0x002D3D20 File Offset: 0x002D1F20
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006BC9 RID: 27593 RVA: 0x002D3D2C File Offset: 0x002D1F2C
	public int? h()
	{
		return this.d;
	}

	// Token: 0x06006BCA RID: 27594 RVA: 0x002D3D34 File Offset: 0x002D1F34
	public void a(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006BCB RID: 27595 RVA: 0x002D3D40 File Offset: 0x002D1F40
	public List<d6d> e()
	{
		return this.e;
	}

	// Token: 0x06006BCC RID: 27596 RVA: 0x002D3D48 File Offset: 0x002D1F48
	public void a(List<d6d> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006BCD RID: 27597 RVA: 0x002D3D54 File Offset: 0x002D1F54
	public List<s0> f()
	{
		return this.f;
	}

	// Token: 0x06006BCE RID: 27598 RVA: 0x002D3D5C File Offset: 0x002D1F5C
	public void a(List<s0> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006BCF RID: 27599 RVA: 0x002D3D68 File Offset: 0x002D1F68
	public yf(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006BD0 RID: 27600 RVA: 0x002D3D8C File Offset: 0x002D1F8C
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (base.a8().a() && !string.IsNullOrEmpty(this.c) && A_0 != null && A_0.h.b != null)
		{
			if (A_0.h.b.aa().b(d8o.t))
			{
				d8s.a();
				return;
			}
			int? num = this.a();
			int? num2 = this.a(A_0.h.b.aa());
			int num3 = Math.Max(num.GetValueOrDefault(), num2.GetValueOrDefault());
			int num4 = (this.d != null) ? Math.Max(this.d.Value, num3) : num3;
			PropertyCollection propertyCollection = new PropertyCollection();
			propertyCollection["AccessLevel"] = num4;
			azm a_ = this.a(num4, A_0.h.b.aa() as e3q, propertyCollection);
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
			x.c((!string.IsNullOrEmpty(this.g())) ? this.g() : base.a8().y8());
			list.Add(x);
			serviceOrThrow.amv(a_, A_0, base.a8(), list, false, false, false, propertyCollection, true, false);
		}
	}

	// Token: 0x06006BD1 RID: 27601 RVA: 0x002D3F1C File Offset: 0x002D211C
	private int? a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			return serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(bp5.d(this.c), new int?(0));
		}
		return null;
	}

	// Token: 0x06006BD2 RID: 27602 RVA: 0x002D3F68 File Offset: 0x002D2168
	private int? a(efk A_0)
	{
		foreach (coh coh in A_0.Bag.z2())
		{
			d48 d = coh as d48;
			if (d != null)
			{
				int? primitivePropertyValue = d.CustomProperties.GetPrimitivePropertyValue<int>(bp5.d(this.c), null);
				if (primitivePropertyValue != null)
				{
					return new int?(primitivePropertyValue.Value);
				}
			}
		}
		return null;
	}

	// Token: 0x06006BD3 RID: 27603 RVA: 0x002D4014 File Offset: 0x002D2214
	private azm a(int A_0, e3q A_1, PropertyCollection A_2)
	{
		azm azm = new azm();
		ax8 ax = new ax8("player");
		azm.a().Add(ax);
		ax8 ax2 = new ax8("interface");
		azm.a().Add(ax);
		string arg;
		if (this.b != null)
		{
			arg = this.b;
		}
		else
		{
			arg = qv.b("SecurityScopes/" + bp5.e(this.c));
		}
		ad7 ad = new ad7();
		ad.f()["English"] = string.Format("::Уровень безопасности: {0}::\r\n::Уровень доступа: $(tempcontext.AccessLevel)::", arg);
		ad.Questioner = ax2;
		ad.Answerer = ax;
		azm.a(ad);
		List<KeyValuePair<int, int>> list = this.a(A_0);
		if (list.Count > 0)
		{
			A_2[cc9.b] = list[list.Count - 1].Key;
			atr atr = new atr();
			atr.f()["English"] = "::Взлом::";
			atr.CausingCondition = new eba();
			ad.PossibleAnswers.Add(atr);
			ad7 ad2 = new ad7();
			ad2.f()["English"] = "::Ожидание ввода команды...::";
			ad2.Questioner = ax2;
			ad2.Answerer = ax;
			atr.PossibleNextSteps.Add(ad2);
			ad7 ad3 = null;
			foreach (KeyValuePair<int, int> keyValuePair in list)
			{
				bool flag = A_1.Skills.Get<adx>().g() >= keyValuePair.Value;
				atr atr2 = new atr();
				d55 d = atr2;
				e7k e7k = new e7k();
				e7k.a(ei6.c);
				e7k.b("tempcontext.AccessLevel");
				e7k.a(new int?(keyValuePair.Key));
				d.CausingCondition = e7k;
				atr2.a(!flag);
				atr2.f()["English"] = string.Format("::Попытаться получить уровень доступа {0} {1}::", keyValuePair.Key, flag ? "" : " [слишком сложно]");
				ad2.PossibleAnswers.Add(atr2);
				if (flag)
				{
					atr2.e().Add(new ar8(keyValuePair.Key));
					atr2.e().Add(new d86(c2h.d(c2h.d(A_1), keyValuePair.Value)));
					Collection<esc> collection = atr2.e();
					b6e b6e = new b6e();
					bfq bfq = new bfq();
					bfq.b("use");
					bfq.c("HackingSuccess");
					b6e.a(bfq);
					collection.Add(b6e);
					if (ad3 == null)
					{
						ad3 = new ad7();
						ad3.f()["English"] = "::Хакерский взлом прошёл успешно. Новый уровень доступа: $(tempcontext.AccessLevel)::";
						ad3.Questioner = ax2;
						ad3.Answerer = ax;
						ad3.PossibleNextSteps.Add(ad);
					}
					atr2.PossibleNextSteps.Add(ad3);
				}
			}
			atr atr3 = new atr();
			atr3.f()["English"] = "::Принудительный выход::";
			atr3.PossibleNextSteps.Add(ad);
			ad2.PossibleAnswers.Add(atr3);
		}
		Dictionary<string, afd> dictionary = new Dictionary<string, afd>();
		if (this.f != null && this.f.Count > 0)
		{
			foreach (s0 s in Enumerable.OrderBy<s0, string>(this.f, new Func<s0, string>(yf.b.a.a)))
			{
				if (!string.IsNullOrEmpty(s.Category))
				{
					afd afd = this.a(ad, dictionary, s, ax2, ax);
					ad7 ad4 = new ad7(Guid.NewGuid().ToString());
					ad4.f()["English"] = string.Format("::{0}::", s.el(A_1));
					ad4.PossibleNextSteps.Add(afd.b);
					ad4.Questioner = ax2;
					ad4.Answerer = ax;
					atr atr4 = new atr();
					atr4.f()["English"] = "::Назад::";
					atr4.PossibleNextSteps.Add(afd.b);
					atr atr5 = new atr();
					atr5.f()["English"] = string.Format("::{0}::", s.ep(A_1));
					atr5.a(new aar(s, A_1));
					atr5.PossibleNextSteps.Add(ad4);
					ad7 ad5 = new ad7(Guid.NewGuid().ToString());
					ad5.f()["English"] = string.Format("::{0}::", s.eo(A_1));
					ad5.Questioner = ax2;
					ad5.Answerer = ax;
					ad5.PossibleAnswers.Add(atr5);
					ad5.PossibleAnswers.Add(atr4);
					atr atr6 = new atr();
					atr6.f()["English"] = string.Format("::{0}::", s.ek(A_1));
					d55 d2 = atr6;
					e7k e7k2 = new e7k();
					e7k2.a(ei6.d);
					e7k2.b("tempcontext.AccessLevel");
					e7k2.a(new int?(s.AccessLevel));
					d2.CausingCondition = e7k2;
					atr6.PossibleNextSteps.Add(ad5);
					atr5.e().Add(new coy(s, A_1, atr6, atr5));
					afd.b.PossibleAnswers.Insert(afd.b.PossibleAnswers.Count - 1, atr6);
				}
			}
		}
		foreach (afd afd2 in dictionary.Values)
		{
			d55 d3 = afd2.a;
			e7k e7k3 = new e7k();
			e7k3.a(ei6.d);
			e7k3.b("tempcontext.AccessLevel");
			e7k3.a(new int?(afd2.c));
			d3.CausingCondition = e7k3;
		}
		atr atr7 = new atr();
		atr7.f()["English"] = "::Выход::";
		ad.PossibleAnswers.Add(atr7);
		return azm;
	}

	// Token: 0x06006BD4 RID: 27604 RVA: 0x002D46C8 File Offset: 0x002D28C8
	private afd a(ad7 A_0, Dictionary<string, afd> A_1, s0 A_2, ax8 A_3, ax8 A_4)
	{
		string key = A_2.Category.ToLowerInvariant();
		afd afd;
		if (!A_1.TryGetValue(key, out afd))
		{
			afd = new afd();
			atr atr = new atr();
			atr.f()["English"] = "::Назад::";
			atr.PossibleNextSteps.Add(A_0);
			afd.b = new ad7();
			afd.b.f()["English"] = string.Format("::{0}::", A_2.Category);
			afd.b.Questioner = A_3;
			afd.b.Answerer = A_4;
			afd.b.PossibleAnswers.Add(atr);
			afd.a = new atr();
			afd.a.f()["English"] = string.Format("::{0}::", A_2.Category);
			afd.a.PossibleNextSteps.Add(afd.b);
			A_0.PossibleAnswers.Add(afd.a);
			afd.c = A_2.AccessLevel;
			A_1.Add(key, afd);
		}
		afd.c = Math.Min(afd.c, A_2.AccessLevel);
		return afd;
	}

	// Token: 0x06006BD5 RID: 27605 RVA: 0x002D47FC File Offset: 0x002D29FC
	private List<KeyValuePair<int, int>> a(int A_0)
	{
		yf.a a = new yf.a();
		List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
		a.a = A_0 + 1;
		int? num;
		do
		{
			num = null;
			IEnumerable<d6d> enumerable = this.e;
			Func<d6d, bool> func;
			if ((func = a.b) == null)
			{
				func = (a.b = new Func<d6d, bool>(a.a));
			}
			d6d d6d = Enumerable.FirstOrDefault<d6d>(Enumerable.Where<d6d>(enumerable, func));
			if (d6d != null)
			{
				num = new int?(d6d.RequiredSkill);
			}
			else
			{
				string text = qv.b("SecurityScopes/" + bp5.a(this.c, a.a));
				int value;
				if (!string.IsNullOrEmpty(text) && int.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
				{
					num = new int?(value);
				}
			}
			if (num != null)
			{
				KeyValuePair<int, int> item = new KeyValuePair<int, int>(a.a, num.Value);
				list.Add(item);
			}
			int num2 = a.a;
			a.a = num2 + 1;
		}
		while (num != null);
		return list;
	}

	// Token: 0x04002C3B RID: 11323
	private new string a;

	// Token: 0x04002C3C RID: 11324
	private string b;

	// Token: 0x04002C3D RID: 11325
	private string c;

	// Token: 0x04002C3E RID: 11326
	private int? d;

	// Token: 0x04002C3F RID: 11327
	private List<d6d> e = new List<d6d>();

	// Token: 0x04002C40 RID: 11328
	private List<s0> f = new List<s0>();

	// Token: 0x020012F1 RID: 4849
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06006BD8 RID: 27608 RVA: 0x002D491C File Offset: 0x002D2B1C
		internal string a(s0 A_0)
		{
			return A_0.Category;
		}

		// Token: 0x04002C41 RID: 11329
		public static readonly yf.b a = new yf.b();

		// Token: 0x04002C42 RID: 11330
		public static Func<s0, string> b;
	}

	// Token: 0x020012F2 RID: 4850
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06006BDA RID: 27610 RVA: 0x002D492C File Offset: 0x002D2B2C
		internal bool a(d6d A_0)
		{
			return A_0.TargetLevel == this.a;
		}

		// Token: 0x04002C43 RID: 11331
		public int a;

		// Token: 0x04002C44 RID: 11332
		public Func<d6d, bool> b;
	}
}
