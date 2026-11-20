using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Playfield.Locale.Aspects;

// Token: 0x02001270 RID: 4720
[cnn("TimelapseVertigo.Playfield.Design.Forms.ContainerAspectEditorForm, TimelapseVertigo.Playfield.Design")]
[eiz("VMEA")]
[global::a(typeof(bim))]
[Serializable]
public sealed class en8 : c7j
{
	// Token: 0x06006668 RID: 26216 RVA: 0x002B8868 File Offset: 0x002B6A68
	private en8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (VendingMachineCurrency)A_0.GetValue("VMEA:C", typeof(VendingMachineCurrency));
		this.b = A_0.GetSingle("VMEA:M");
		this.c = A_0.GetString("VMEA:T");
		this.d = A_0.GetInt32("VMEA:V");
		this.e = A_0.GetInt32("VMEA:H");
		this.f = (VendingMachineHackingDifficulty)A_0.GetValue("VMEA:D", typeof(VendingMachineHackingDifficulty));
		this.g = (A_0.GetValue("VMEA:U", typeof(int?)) as int?);
	}

	// Token: 0x06006669 RID: 26217 RVA: 0x002B8934 File Offset: 0x002B6B34
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VMEA:C", this.a);
		info.AddValue("VMEA:M", this.b);
		info.AddValue("VMEA:T", this.c);
		info.AddValue("VMEA:V", this.d);
		info.AddValue("VMEA:H", this.e);
		info.AddValue("VMEA:D", this.f);
		info.AddValue("VMEA:U", this.g);
	}

	// Token: 0x0600666A RID: 26218 RVA: 0x002B89D0 File Offset: 0x002B6BD0
	public en8(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600666B RID: 26219 RVA: 0x002B89E8 File Offset: 0x002B6BE8
	protected override void mz(c5x A_0, string A_1 = null)
	{
		this.h = cuo.a.Next();
		azm a_ = this.a();
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
		x.c("Торговый автомат");
		list.Add(x);
		PropertyCollection a_2 = new PropertyCollection();
		serviceOrThrow.amv(a_, A_0, base.a8(), list, false, false, false, a_2, true, false);
	}

	// Token: 0x0600666C RID: 26220 RVA: 0x002B8A78 File Offset: 0x002B6C78
	private azm a()
	{
		azm azm = new azm();
		azm.b(true);
		azm.a(true);
		ax8 ax = new ax8("player");
		azm.a().Add(ax);
		ax8 ax2 = new ax8("interface");
		azm.a().Add(ax2);
		ad7 ad = new ad7();
		azm.a(ad);
		ad.Questioner = ax2;
		ad.Answerer = ax;
		this.a(ad);
		return azm;
	}

	// Token: 0x0600666D RID: 26221 RVA: 0x002B8AE8 File Offset: 0x002B6CE8
	private void a(ad7 A_0)
	{
		cc8 serviceOrThrow = bpo.GetServiceOrThrow<cc8>();
		string key = "English";
		string text = "";
		if (!string.IsNullOrEmpty(this.c))
		{
			if (this.d > 1)
			{
				text = qv.b(this.c + "_" + (this.h % this.d).ToString());
			}
			if (string.IsNullOrEmpty(text))
			{
				text = qv.b(this.c);
			}
		}
		if (this.e > 0)
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += "\r\n\r\n";
			}
			text += "::Машина, по-видимому, подверглась закалке.::";
		}
		A_0.f()[key] = text;
		string text2 = qv.b("Devices/vendingMachine_currency_" + this.a.ToString() + "_singular");
		string text3 = qv.b("Devices/vendingMachine_currency_" + this.a.ToString() + "_plural");
		int num;
		string a_;
		if (this.a == VendingMachineCurrency.StygianCoins)
		{
			num = 30;
			a_ = "currency.sc";
		}
		else if (this.a == VendingMachineCurrency.SgsCredits)
		{
			num = 10;
			a_ = "currency.sgs";
		}
		else
		{
			num = 50;
			a_ = "currency.usd";
		}
		A_0.PossibleAnswers.Clear();
		en8.b b = new en8.b();
		b.a = this;
		b.b = A_0;
		for (int i = 0; i < base.ItemContainer.z2().Count; i++)
		{
			coh coh = base.ItemContainer.z2()[i];
			coh coh2 = coh.fy();
			coh2.Stacks = 1;
			float num2 = this.b;
			if (this.e > 1)
			{
				num2 = 0f;
			}
			else if (this.e > 0)
			{
				num2 = this.b * 0.5f;
			}
			int num3 = (int)Math.Ceiling((double)((float)coh2.ItemValue * num2 / (float)num));
			string text4;
			if (num3 == 1)
			{
				text4 = text3;
			}
			else
			{
				text4 = text2;
			}
			atr atr = new atr();
			atr.f()[key] = string.Format("::" + qv.b("Devices/vendingMachine_buy_option_format") + "::", new object[]
			{
				coh2.Definition.az(),
				num3,
				text4,
				coh.Stacks
			});
			if (num3 > 0)
			{
				atr.a(serviceOrThrow.as6(a_, num3, true));
				atr.e().Add(serviceOrThrow.as7(a_, num3));
			}
			if (!string.IsNullOrEmpty(coh.Definition.a5()))
			{
				atr.e().Add(serviceOrThrow.as9(coh.Definition.a5(), null, 1, false, false, new Guid?(base.a8().qe()), true));
			}
			else
			{
				atr.e().Add(serviceOrThrow.as9(null, new Guid?(coh.Id), 1, false, false, new Guid?(base.a8().qe()), true));
			}
			atr.e().Add(b);
			atr.a(coh2);
			atr.PossibleNextSteps.Add(A_0);
			A_0.PossibleAnswers.Add(atr);
		}
		ad7 ad = new ad7();
		if (this.e < 2)
		{
			atr atr2 = new atr();
			atr2.f()[key] = "::[Хакерство] Попытаться взломать торговый автомат::";
			atr2.PossibleNextSteps.Add(ad);
			A_0.PossibleAnswers.Add(atr2);
		}
		atr atr3 = new atr();
		atr3.f()[key] = "::" + qv.b("Devices/vendingMachine_leave_it_be") + "::";
		A_0.PossibleAnswers.Add(atr3);
		if (this.e < 2)
		{
			int num4 = this.b();
			int num5 = Math.Max(5, num4 - 15);
			ad.Questioner = A_0.Questioner;
			ad.Answerer = A_0.Answerer;
			ad.b("// TODO");
			int num6 = 0;
			if (pp.b != null && pp.b.aqu() != null && pp.b.aqu().v() != null)
			{
				num6 = pp.b.aqu().v().Skills.Get<adx>().g();
			}
			ad7 ad2 = new ad7();
			ad2.b("::Успех!::");
			ad2.Questioner = A_0.Questioner;
			ad2.Answerer = A_0.Answerer;
			ad2.e().Add(b);
			ad2.PossibleNextSteps.Add(A_0);
			if (this.e < 1)
			{
				atr atr4 = new atr();
				atr4.b(string.Format("::[Хакерство {0}] Попытаться взломать автомат, чтобы снизить цены вдвое.::", num5));
				atr4.a(num6 < num5);
				atr4.PossibleNextSteps.Add(ad2);
				atr4.e().Add(new en8.a(this, 1));
				ad.PossibleAnswers.Add(atr4);
			}
			if (this.e < 2)
			{
				atr atr5 = new atr();
				atr5.b(string.Format("::[Хакерство {0}] Попытаться взломать автомат и обнулить цены.::", num4));
				atr5.a(num6 < num4);
				atr5.PossibleNextSteps.Add(ad2);
				atr5.e().Add(new en8.a(this, 2));
				ad.PossibleAnswers.Add(atr5);
			}
			atr atr6 = new atr();
			atr6.b("::Отмена::");
			atr6.PossibleNextSteps.Add(A_0);
			ad.PossibleAnswers.Add(atr6);
		}
	}

	// Token: 0x0600666E RID: 26222 RVA: 0x002B90B0 File Offset: 0x002B72B0
	public int b()
	{
		if (this.g != null)
		{
			return this.g.Value;
		}
		return (int)((this.f + 1) * (VendingMachineHackingDifficulty)30);
	}

	// Token: 0x04002A7E RID: 10878
	public new VendingMachineCurrency a;

	// Token: 0x04002A7F RID: 10879
	public new float b = 1.5f;

	// Token: 0x04002A80 RID: 10880
	public new string c;

	// Token: 0x04002A81 RID: 10881
	public int d;

	// Token: 0x04002A82 RID: 10882
	public int e;

	// Token: 0x04002A83 RID: 10883
	public VendingMachineHackingDifficulty f;

	// Token: 0x04002A84 RID: 10884
	public int? g;

	// Token: 0x04002A85 RID: 10885
	[NonSerialized]
	private int h;

	// Token: 0x02001272 RID: 4722
	private new sealed class b : esc
	{
		// Token: 0x06006683 RID: 26243 RVA: 0x002B957C File Offset: 0x002B777C
		public override int d5(bq8 A_0, bq8 A_1)
		{
			en8 en = this.a;
			if (en != null)
			{
				en.a(this.b);
			}
			return 1;
		}

		// Token: 0x04002A89 RID: 10889
		public en8 a;

		// Token: 0x04002A8A RID: 10890
		public ad7 b;
	}

	// Token: 0x02001273 RID: 4723
	private new sealed class a : esc
	{
		// Token: 0x06006685 RID: 26245 RVA: 0x002B95A4 File Offset: 0x002B77A4
		public a(en8 A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x002B95BC File Offset: 0x002B77BC
		public override int d5(bq8 A_0, bq8 A_1)
		{
			if (this.a != null)
			{
				this.a.e = this.b;
			}
			return 1;
		}

		// Token: 0x04002A8B RID: 10891
		public en8 a;

		// Token: 0x04002A8C RID: 10892
		public int b;
	}
}
