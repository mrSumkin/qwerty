using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020012E5 RID: 4837
[eiz("PS0")]
[global::a(typeof(bim))]
[Serializable]
public sealed class ai9 : bim
{
	// Token: 0x06006B48 RID: 27464 RVA: 0x002D18E4 File Offset: 0x002CFAE4
	private ai9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PS0:O");
		this.b = A_0.GetString("PS0:O1");
		this.c = A_0.GetString("PS0:S");
		di7.ReadList<cfr>("PS0:SL", ref this.d, A_0);
		di7.ReadList<dmz>("PS0:CL", ref this.e, A_0);
	}

	// Token: 0x06006B49 RID: 27465 RVA: 0x002D1964 File Offset: 0x002CFB64
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PS0:O", this.a);
		info.AddValue("PS0:O1", this.b);
		info.AddValue("PS0:S", this.c);
		di7.WriteList<cfr>("PS0:SL", this.d, info);
		di7.WriteList<dmz>("PS0:CL", this.e, info);
	}

	// Token: 0x06006B4A RID: 27466 RVA: 0x002D19D0 File Offset: 0x002CFBD0
	public string d()
	{
		return this.a;
	}

	// Token: 0x06006B4B RID: 27467 RVA: 0x002D19D8 File Offset: 0x002CFBD8
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006B4C RID: 27468 RVA: 0x002D19E4 File Offset: 0x002CFBE4
	public string e()
	{
		return this.b;
	}

	// Token: 0x06006B4D RID: 27469 RVA: 0x002D19EC File Offset: 0x002CFBEC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006B4E RID: 27470 RVA: 0x002D19F8 File Offset: 0x002CFBF8
	public string a()
	{
		return this.c;
	}

	// Token: 0x06006B4F RID: 27471 RVA: 0x002D1A00 File Offset: 0x002CFC00
	public void c(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006B50 RID: 27472 RVA: 0x002D1A0C File Offset: 0x002CFC0C
	public List<cfr> b()
	{
		return this.d;
	}

	// Token: 0x06006B51 RID: 27473 RVA: 0x002D1A14 File Offset: 0x002CFC14
	public void a(List<cfr> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006B52 RID: 27474 RVA: 0x002D1A20 File Offset: 0x002CFC20
	public List<dmz> f()
	{
		return this.e;
	}

	// Token: 0x06006B53 RID: 27475 RVA: 0x002D1A28 File Offset: 0x002CFC28
	public void a(List<dmz> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006B54 RID: 27476 RVA: 0x002D1A34 File Offset: 0x002CFC34
	public ai9(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006B55 RID: 27477 RVA: 0x002D1A58 File Offset: 0x002CFC58
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (base.a8().a() && !string.IsNullOrEmpty(this.c) && A_0 != null)
		{
			PropertyCollection propertyCollection = new PropertyCollection();
			azm a_ = this.a(propertyCollection);
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
			x.c((!string.IsNullOrEmpty(this.a)) ? this.a : base.a8().y8());
			list.Add(x);
			serviceOrThrow.amv(a_, A_0, base.a8(), list, false, false, false, propertyCollection, true, false);
		}
	}

	// Token: 0x06006B56 RID: 27478 RVA: 0x002D1B24 File Offset: 0x002CFD24
	private azm a(bq8 A_0)
	{
		azm azm = new azm();
		ax8 ax = new ax8("player");
		azm.a().Add(ax);
		ax8 a_ = new ax8("interface");
		azm.a().Add(ax);
		string arg;
		if (this.b != null)
		{
			arg = this.b;
		}
		else
		{
			arg = qv.b("PowerStations/" + bp5.c(this.c));
		}
		ad7 ad = new ad7();
		ad7 ad2 = new ad7();
		string text = string.Format("::Электроснабжение: {0}::\r\n::Каналы питания: {1}::\r\n\r\n::Текущая конфигурация: ::\r\n", arg, this.d.Count);
		foreach (cfr cfr in this.d)
		{
			string arg2 = this.a(cfr);
			this.b(cfr);
			bool flag = this.d(cfr);
			text += string.Format("\r\n::{0}: $(tempcontext.slot_{1}.DisplayName)", arg2, cfr.c());
			if (flag)
			{
				text += " (заблокировано)";
			}
			text += "::";
			A_0.set_Item(string.Format("slot_{0}", cfr.c()), new ai9.b(this, cfr));
			atr atr = new atr();
			atr.f()["English"] = string.Format("::Изменить конфигурацию {0}{1}::", arg2, flag ? " (заблокировано)" : "");
			atr.a(flag);
			Collection<esc> collection = atr.e();
			dsl dsl = new dsl();
			dsl.b("tempcontext.slot");
			dsl.a(cfr.c());
			collection.Add(dsl);
			Collection<esc> collection2 = atr.e();
			dsl dsl2 = new dsl();
			dsl2.b("tempcontext.slotCurrentClient");
			dsl2.a(this.c(cfr));
			collection2.Add(dsl2);
			atr.PossibleNextSteps.Add(ad2);
			ad.PossibleAnswers.Add(atr);
		}
		atr atr2 = new atr();
		atr2.f()["English"] = "::Выход::";
		ad.PossibleAnswers.Add(atr2);
		ad.f()["English"] = text;
		ad.Questioner = a_;
		ad.Answerer = ax;
		azm.a(ad);
		ad2.f()["English"] = "::Что должен питать канал $(tempcontext.slot)?::";
		ad2.Questioner = a_;
		ad2.Answerer = ax;
		atr atr3 = new atr();
		atr3.f()["English"] = "::Ничего::";
		atr3.PossibleNextSteps.Add(ad);
		atr3.e().Add(new ai9.a(this, null));
		ad2.PossibleAnswers.Add(atr3);
		foreach (dmz dmz in this.e)
		{
			atr atr4 = new atr();
			atr4.f()["English"] = string.Format("::{0}::", this.a(dmz));
			atr4.a(new ai9.c(this, dmz));
			atr4.PossibleNextSteps.Add(ad);
			atr4.e().Add(new ai9.a(this, dmz));
			ad2.PossibleAnswers.Add(atr4);
		}
		return azm;
	}

	// Token: 0x06006B57 RID: 27479 RVA: 0x002D1EC8 File Offset: 0x002D00C8
	private string a(dmz A_0)
	{
		return qv.b(string.Format("PowerStations/{0}_client_{1}", this.c, A_0.a()));
	}

	// Token: 0x06006B58 RID: 27480 RVA: 0x002D1EE8 File Offset: 0x002D00E8
	private bool d(cfr A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bp5.a(this.c, A_0.c()), null);
			if (primitivePropertyValue == null)
			{
				serviceOrThrow.aqu().r()[bp5.a(this.c, A_0.c())] = A_0.b();
				primitivePropertyValue = new bool?(A_0.b());
			}
			return primitivePropertyValue.Value;
		}
		return false;
	}

	// Token: 0x06006B59 RID: 27481 RVA: 0x002D1F80 File Offset: 0x002D0180
	private string c(cfr A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			return serviceOrThrow.aqu().r().GetClassPropertyValue<string>(bp5.b(this.c, A_0.c()));
		}
		return null;
	}

	// Token: 0x06006B5A RID: 27482 RVA: 0x002D1FC4 File Offset: 0x002D01C4
	private string b(cfr A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>(bp5.b(this.c, A_0.c()));
			if (text == null && A_0.a() != null)
			{
				serviceOrThrow.aqu().r()[bp5.b(this.c, A_0.c())] = A_0.a();
				text = A_0.a();
				A_0.b(null);
			}
			if (text != null)
			{
				return qv.b(string.Format("PowerStations/{0}_client_{1}", this.c, text));
			}
		}
		return "[Свободен]";
	}

	// Token: 0x06006B5B RID: 27483 RVA: 0x002D206C File Offset: 0x002D026C
	private string a(cfr A_0)
	{
		return qv.b(string.Format("PowerStations/{0}_slot_{1}", this.c, A_0.c()));
	}

	// Token: 0x04002C0C RID: 11276
	private new string a;

	// Token: 0x04002C0D RID: 11277
	private string b;

	// Token: 0x04002C0E RID: 11278
	private string c;

	// Token: 0x04002C0F RID: 11279
	private List<cfr> d = new List<cfr>();

	// Token: 0x04002C10 RID: 11280
	private List<dmz> e = new List<dmz>();

	// Token: 0x020012E6 RID: 4838
	private sealed class c : dnh
	{
		// Token: 0x06006B5C RID: 27484 RVA: 0x002D208C File Offset: 0x002D028C
		public c(ai9 A_0, dmz A_1)
		{
			this.b = A_0;
			this.a = A_1;
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x002D20A4 File Offset: 0x002D02A4
		public override bool cw(bq8 A_0, bq8 A_1)
		{
			foreach (cfr cfr in this.b.d)
			{
				if (this.b.c(cfr) == this.a.a() && A_1.get_Item("slot") != cfr.c())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04002C11 RID: 11281
		private dmz a;

		// Token: 0x04002C12 RID: 11282
		private ai9 b;
	}

	// Token: 0x020012E7 RID: 4839
	private new class a : esc
	{
		// Token: 0x06006B5E RID: 27486 RVA: 0x002D213C File Offset: 0x002D033C
		public a(ai9 A_0, dmz A_1)
		{
			this.b = A_0;
			this.a = A_1;
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x002D2154 File Offset: 0x002D0354
		public override int d5(bq8 A_0, bq8 A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				string name = bp5.b(this.b.c, A_1.get_Item("slot") as string);
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>(name);
				if (this.a == null)
				{
					if (classPropertyValue != null)
					{
						serviceOrThrow.aqu().r()[name] = null;
						axh axh = this.a(classPropertyValue);
						if (axh != null)
						{
							axh.a(null, false, null);
						}
					}
				}
				else
				{
					serviceOrThrow.aqu().r()[name] = this.a.a();
					if (classPropertyValue != null)
					{
						axh axh2 = this.a(classPropertyValue);
						if (axh2 != null)
						{
							axh2.a(null, false, null);
						}
					}
					axh axh3 = this.a(this.a.a());
					if (axh3 != null)
					{
						axh3.a(null, true, null);
					}
				}
			}
			return 0;
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x002D2260 File Offset: 0x002D0460
		private axh a(string A_0)
		{
			foreach (dmz dmz in this.b.e)
			{
				if (dmz.a() == A_0)
				{
					ar7 ar = new ar7(dmz.b(), this.b.a8().Area);
					if (ar.ao() != null)
					{
						return ar.ao().GetAspect<axh>();
					}
					return null;
				}
			}
			return null;
		}

		// Token: 0x04002C13 RID: 11283
		private dmz a;

		// Token: 0x04002C14 RID: 11284
		private ai9 b;
	}

	// Token: 0x020012E8 RID: 4840
	private class b
	{
		// Token: 0x06006B61 RID: 27489 RVA: 0x002D230C File Offset: 0x002D050C
		public b(ai9 A_0, cfr A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06006B62 RID: 27490 RVA: 0x002D2324 File Offset: 0x002D0524
		public string DisplayName
		{
			get
			{
				return this.a.b(this.b);
			}
		}

		// Token: 0x04002C15 RID: 11285
		private ai9 a;

		// Token: 0x04002C16 RID: 11286
		private cfr b;
	}
}
