using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using TimelapseVertigo.Rules;

// Token: 0x02000BA5 RID: 2981
[euj]
public class c17
{
	// Token: 0x060043B9 RID: 17337 RVA: 0x001A9E3C File Offset: 0x001A803C
	[ayh("EPJIPS")]
	public void o(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_up_emergencyPhoneMet", new bool?(false)).Value)
		{
			List<int> list = new List<int>
			{
				1,
				2,
				3,
				4,
				5,
				6
			};
			Random random = new Random(serviceOrThrow.aqu().l());
			int i = list.Count;
			while (i > 1)
			{
				i--;
				int index = random.Next(i + 1);
				int value = list[index];
				list[index] = list[i];
				list[i] = value;
			}
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneNumber_redCross"] = list[0];
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneNumber_rat"] = list[1];
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneNumber_security"] = list[2];
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneNumber_wrench"] = list[3];
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneNumber_hazard"] = list[4];
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneNumber_info"] = list[5];
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneMet"] = true;
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneStatus"] = "initial";
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoStatus"] = "initial";
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneSequenceStatus"] = "new";
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoSequenceStatus"] = "new";
		}
	}

	// Token: 0x060043BA RID: 17338 RVA: 0x001AA050 File Offset: 0x001A8250
	[ayh("EPJGENSEHO")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b(true);
	}

	// Token: 0x060043BB RID: 17339 RVA: 0x001AA05C File Offset: 0x001A825C
	[ayh("EPJGENSEHT")]
	public void w(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a(true);
	}

	// Token: 0x060043BC RID: 17340 RVA: 0x001AA068 File Offset: 0x001A8268
	[ayh("EPJPBSO")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneHideoutOneCurrentSequence");
	}

	// Token: 0x060043BD RID: 17341 RVA: 0x001AA078 File Offset: 0x001A8278
	[ayh("EPJPBST")]
	public void p(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneHideoutTwoCurrentSequence");
	}

	// Token: 0x060043BE RID: 17342 RVA: 0x001AA088 File Offset: 0x001A8288
	[ayh("EPJPPPSRC")]
	public void k(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneNumber_redCross", 0);
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x001AA098 File Offset: 0x001A8298
	[ayh("EPJPPPSR")]
	public void q(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneNumber_rat", 0);
	}

	// Token: 0x060043C0 RID: 17344 RVA: 0x001AA0A8 File Offset: 0x001A82A8
	[ayh("EPJPPPSS")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneNumber_security", 0);
	}

	// Token: 0x060043C1 RID: 17345 RVA: 0x001AA0B8 File Offset: 0x001A82B8
	[ayh("EPJPPPSSW")]
	public void j(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneNumber_wrench", 0);
	}

	// Token: 0x060043C2 RID: 17346 RVA: 0x001AA0C8 File Offset: 0x001A82C8
	[ayh("EPJPPPSH")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneNumber_hazard", 0);
	}

	// Token: 0x060043C3 RID: 17347 RVA: 0x001AA0D8 File Offset: 0x001A82D8
	[ayh("EPJPPPSI")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("loc_up_emergencyPhoneNumber_info", 0);
	}

	// Token: 0x060043C4 RID: 17348 RVA: 0x001AA0E8 File Offset: 0x001A82E8
	[ayh("EPJIRCISPO")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutOneCurrentSequenceString", "loc_up_emergencyPhoneNumber_redCross");
	}

	// Token: 0x060043C5 RID: 17349 RVA: 0x001AA0FC File Offset: 0x001A82FC
	[ayh("EPJIRISPO")]
	public void m(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutOneCurrentSequenceString", "loc_up_emergencyPhoneNumber_rat");
	}

	// Token: 0x060043C6 RID: 17350 RVA: 0x001AA110 File Offset: 0x001A8310
	[ayh("EPJISISPO")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutOneCurrentSequenceString", "loc_up_emergencyPhoneNumber_security");
	}

	// Token: 0x060043C7 RID: 17351 RVA: 0x001AA124 File Offset: 0x001A8324
	[ayh("EPJIWISPO")]
	public void t(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutOneCurrentSequenceString", "loc_up_emergencyPhoneNumber_wrench");
	}

	// Token: 0x060043C8 RID: 17352 RVA: 0x001AA138 File Offset: 0x001A8338
	[ayh("EPJIHISPO")]
	public void v(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutOneCurrentSequenceString", "loc_up_emergencyPhoneNumber_hazard");
	}

	// Token: 0x060043C9 RID: 17353 RVA: 0x001AA14C File Offset: 0x001A834C
	[ayh("EPJIIISPO")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutOneCurrentSequenceString", "loc_up_emergencyPhoneNumber_info");
	}

	// Token: 0x060043CA RID: 17354 RVA: 0x001AA160 File Offset: 0x001A8360
	[ayh("EPJIRCISPT")]
	public void u(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutTwoCurrentSequenceString", "loc_up_emergencyPhoneNumber_redCross");
	}

	// Token: 0x060043CB RID: 17355 RVA: 0x001AA174 File Offset: 0x001A8374
	[ayh("EPJIRISPT")]
	public void n(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutTwoCurrentSequenceString", "loc_up_emergencyPhoneNumber_rat");
	}

	// Token: 0x060043CC RID: 17356 RVA: 0x001AA188 File Offset: 0x001A8388
	[ayh("EPJISISPT")]
	public void s(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutTwoCurrentSequenceString", "loc_up_emergencyPhoneNumber_security");
	}

	// Token: 0x060043CD RID: 17357 RVA: 0x001AA19C File Offset: 0x001A839C
	[ayh("EPJIWISPT")]
	public void r(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutTwoCurrentSequenceString", "loc_up_emergencyPhoneNumber_wrench");
	}

	// Token: 0x060043CE RID: 17358 RVA: 0x001AA1B0 File Offset: 0x001A83B0
	[ayh("EPJIHISPT")]
	public void l(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutTwoCurrentSequenceString", "loc_up_emergencyPhoneNumber_hazard");
	}

	// Token: 0x060043CF RID: 17359 RVA: 0x001AA1C4 File Offset: 0x001A83C4
	[ayh("EPJIIISPT")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("loc_up_emergencyPhoneHideoutTwoCurrentSequenceString", "loc_up_emergencyPhoneNumber_info");
	}

	// Token: 0x060043D0 RID: 17360 RVA: 0x001AA1D8 File Offset: 0x001A83D8
	public void b(string A_0, string A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutOneInsertSequence") == null && A_0.Contains("One"))
			{
				serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneInsertSequence"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(A_1, null).ToString();
				serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneSequenceStatus"] = "ongoing";
				this.a(A_1, 0);
				return;
			}
			if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutTwoInsertSequence") == null && A_0.Contains("Two"))
			{
				serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoInsertSequence"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(A_1, null).ToString();
				serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoSequenceStatus"] = "ongoing";
				this.a(A_1, 0);
				return;
			}
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>(A_0);
			if (classPropertyValue.Length >= 1 && classPropertyValue.Length < 12)
			{
				string text;
				if (A_0.Contains("One"))
				{
					text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutOneInsertSequence");
					serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutOneSequenceStatus");
				}
				else
				{
					text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutTwoInsertSequence");
					serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutTwoSequenceStatus");
				}
				text += serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(A_1, null).ToString();
				this.a(A_1, 0);
				if (A_0.Contains("One"))
				{
					serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneInsertSequence"] = text;
				}
				else
				{
					serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoInsertSequence"] = text;
				}
				if (text.Length == classPropertyValue.Length)
				{
					if (!classPropertyValue.Equals(text))
					{
						if (c5x != null)
						{
							if (A_0.Contains("One"))
							{
								serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneStatus"] = "initial";
								this.b(true);
							}
							else
							{
								serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoStatus"] = "initial";
								this.a(true);
							}
							bfq bfq = new bfq();
							bfq.c("Electroshock");
							bfq.a(bvl.d);
							bfq.ym(c5x, c5x, null);
						}
						return;
					}
					if (A_0.Contains("One"))
					{
						string classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutOneStatus");
						if (classPropertyValue2.Equals("initial"))
						{
							serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneStatus"] = "midway";
							this.b(false);
							return;
						}
						if (classPropertyValue2.Equals("midway"))
						{
							serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneStatus"] = "final";
							this.b(false);
							return;
						}
						if (classPropertyValue2.Equals("final"))
						{
							serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneStatus"] = "ended";
						}
						return;
					}
					else
					{
						string classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutTwoStatus");
						if (classPropertyValue2.Equals("initial"))
						{
							serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoStatus"] = "midway";
							this.a(false);
							return;
						}
						if (classPropertyValue2.Equals("midway"))
						{
							serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoStatus"] = "final";
							this.a(false);
							return;
						}
						if (classPropertyValue2.Equals("final"))
						{
							serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoStatus"] = "ended";
						}
						return;
					}
				}
				else
				{
					if (A_0.Contains("One") && text.Length > classPropertyValue.Length)
					{
						serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneStatus"] = "initial";
						this.b(true);
						bfq bfq2 = new bfq();
						bfq2.c("Electroshock");
						bfq2.a(bvl.d);
						bfq2.ym(c5x, c5x, null);
						return;
					}
					if (A_0.Contains("Two") && text.Length == classPropertyValue.Length)
					{
						serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoStatus"] = "initial";
						this.a(true);
						bfq bfq3 = new bfq();
						bfq3.c("Electroshock");
						bfq3.a(bvl.d);
						bfq3.ym(c5x, c5x, null);
						return;
					}
					if (A_0.Contains("One"))
					{
						serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneSequenceStatus"] = "ongoing";
						return;
					}
					if (A_0.Contains("Two"))
					{
						serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoSequenceStatus"] = "ongoing";
					}
				}
			}
		}
	}

	// Token: 0x060043D1 RID: 17361 RVA: 0x001AA758 File Offset: 0x001A8958
	public void a(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				List<int> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<int>>(A_0);
				if (classPropertyValue.Count > 0)
				{
					int a_ = 3000;
					float a_2 = 0.85f;
					int num = 25;
					if (serviceOrThrow.aqu().a() == GameDifficulty.Hard)
					{
						a_ = 2250;
						num = 35;
						a_2 = 0.95f;
					}
					else if (serviceOrThrow.aqu().a() == GameDifficulty.Dominating)
					{
						a_ = 1650;
						num = 45;
						a_2 = 1f;
					}
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					foreach (int a_3 in classPropertyValue)
					{
						if (this.a(null, serviceOrThrow, a_3) != null)
						{
							if (num > cuo.a.Next(0, 100))
							{
								List<auv> list = awx.ad();
								bfq bfq = new bfq();
								bfq.c((5 > cuo.a.Next(0, 11)) ? this.b() : this.a());
								bfq.a(bvl.d);
								bfq.a(a_2);
								list.Add(new a4s(bfq, new ar7(c5x), null, null));
								awx.ad().Add(new bm3(cuo.a.Next(4, 7) * 100));
							}
							List<auv> list2 = awx.ad();
							bfq bfq2 = new bfq();
							bfq2.c(this.a(null, serviceOrThrow, a_3));
							bfq2.a(bvl.d);
							list2.Add(new a4s(bfq2, new ar7(c5x), null, null));
							awx.ad().Add(new bm3(a_));
						}
					}
					c5x.Zone.ActionManager.g9(awx, atp.a);
				}
			}
		}
	}

	// Token: 0x060043D2 RID: 17362 RVA: 0x001AA960 File Offset: 0x001A8B60
	public void a(string A_0, int A_1 = 0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			int num = 99;
			if (A_1 != 0)
			{
				num = A_1;
			}
			else if (A_0 != null)
			{
				num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(A_0, new int?(0)).Value;
			}
			if (num > 0 && num < 7)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null)
				{
					switch (num)
					{
					case 1:
					{
						bfq bfq = new bfq();
						bfq.c("EmergencyPhoneButtonSound1");
						bfq.a(bvl.d);
						bfq.ym(c5x, c5x, null);
						return;
					}
					case 2:
					{
						bfq bfq2 = new bfq();
						bfq2.c("EmergencyPhoneButtonSound2");
						bfq2.a(bvl.d);
						bfq2.ym(c5x, c5x, null);
						return;
					}
					case 3:
					{
						bfq bfq3 = new bfq();
						bfq3.c("EmergencyPhoneButtonSound3");
						bfq3.a(bvl.d);
						bfq3.ym(c5x, c5x, null);
						return;
					}
					case 4:
					{
						bfq bfq4 = new bfq();
						bfq4.c("EmergencyPhoneButtonSound4");
						bfq4.a(bvl.d);
						bfq4.ym(c5x, c5x, null);
						return;
					}
					case 5:
					{
						bfq bfq5 = new bfq();
						bfq5.c("EmergencyPhoneButtonSound5");
						bfq5.a(bvl.d);
						bfq5.ym(c5x, c5x, null);
						return;
					}
					case 6:
					{
						bfq bfq6 = new bfq();
						bfq6.c("EmergencyPhoneButtonSound6");
						bfq6.a(bvl.d);
						bfq6.ym(c5x, c5x, null);
						break;
					}
					default:
						return;
					}
				}
			}
		}
	}

	// Token: 0x060043D3 RID: 17363 RVA: 0x001AAABC File Offset: 0x001A8CBC
	public string a(string A_0, cnk A_1, int A_2 = 0)
	{
		int num = 0;
		if (A_2 != 0)
		{
			num = A_2;
		}
		else if (A_0 != null)
		{
			num = A_1.aqu().r().GetPrimitivePropertyValue<int>(A_0, new int?(0)).Value;
		}
		if (num > 0 && num < 7)
		{
			switch (num)
			{
			case 1:
				return "EmergencyPhoneButtonSound1";
			case 2:
				return "EmergencyPhoneButtonSound2";
			case 3:
				return "EmergencyPhoneButtonSound3";
			case 4:
				return "EmergencyPhoneButtonSound4";
			case 5:
				return "EmergencyPhoneButtonSound5";
			case 6:
				return "EmergencyPhoneButtonSound6";
			}
		}
		return null;
	}

	// Token: 0x060043D4 RID: 17364 RVA: 0x001AAB58 File Offset: 0x001A8D58
	public string b()
	{
		switch (cuo.a.Next(1, 11))
		{
		case 1:
			return "StaticFilter1";
		case 2:
			return "StaticFilter2";
		case 3:
			return "StaticFilter3";
		case 4:
			return "StaticFilter4";
		case 5:
			return "StaticFilterSweep1";
		case 6:
			return "StaticFilterSweep2";
		case 7:
			return "StaticFilterSweep3";
		case 8:
			return "StaticFilterSweep4";
		case 9:
			return "StaticFilterSweep5";
		case 10:
			return "StaticFilterSweep6";
		default:
			return "StaticFilterSweep7";
		}
	}

	// Token: 0x060043D5 RID: 17365 RVA: 0x001AABEC File Offset: 0x001A8DEC
	public string a()
	{
		switch (cuo.a.Next(1, 7))
		{
		case 1:
			return "StaticNormal1";
		case 2:
			return "StaticNormal2";
		case 3:
			return "StaticNormal3";
		case 4:
			return "StaticFilterSweep4";
		case 5:
			return "StaticFilterSweep5";
		case 6:
			return "StaticFilterSweep6";
		default:
			return "StaticFilterSweep7";
		}
	}

	// Token: 0x060043D6 RID: 17366 RVA: 0x001AAC54 File Offset: 0x001A8E54
	public void b(bool A_0 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			List<int> list = new List<int>
			{
				cuo.a.Next(1, 5),
				cuo.a.Next(1, 7),
				cuo.a.Next(2, 5),
				cuo.a.Next(1, 7)
			};
			if (serviceOrThrow.aqu().a() >= GameDifficulty.Normal)
			{
				list.Add(cuo.a.Next(2, 6));
			}
			if (serviceOrThrow.aqu().a() >= GameDifficulty.Hard)
			{
				list.Add(cuo.a.Next(1, 7));
			}
			if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutOneStatus").Equals("midway") && serviceOrThrow.aqu().a() == GameDifficulty.Dominating)
			{
				list.Add(cuo.a.Next(1, 7));
			}
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			int i = list.Count;
			while (i > 1)
			{
				byte[] array = new byte[1];
				do
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
				while ((int)array[0] >= i * (255 / i));
				int index = (int)array[0] % i;
				i--;
				int value = list[index];
				list[index] = list[i];
				list[i] = value;
			}
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneCurrentSequence"] = list;
			string text = "";
			foreach (int num in list)
			{
				text += num.ToString();
			}
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneInsertSequence"] = null;
			if (A_0)
			{
				serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneStatus"] = "initial";
			}
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneCurrentSequenceString"] = text;
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutOneSequenceStatus"] = "new";
		}
	}

	// Token: 0x060043D7 RID: 17367 RVA: 0x001AAE84 File Offset: 0x001A9084
	public void a(bool A_0 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			List<int> list = new List<int>
			{
				cuo.a.Next(2, 6),
				cuo.a.Next(1, 7),
				cuo.a.Next(1, 5),
				cuo.a.Next(1, 7)
			};
			if (serviceOrThrow.aqu().a() >= GameDifficulty.Normal)
			{
				list.Add(cuo.a.Next(1, 6));
			}
			if (serviceOrThrow.aqu().a() >= GameDifficulty.Hard)
			{
				list.Add(cuo.a.Next(1, 4));
			}
			if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_up_emergencyPhoneHideoutTwoStatus").Equals("midway") && serviceOrThrow.aqu().a() == GameDifficulty.Dominating)
			{
				list.Add(cuo.a.Next(1, 7));
			}
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			int i = list.Count;
			while (i > 1)
			{
				byte[] array = new byte[1];
				do
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
				while ((int)array[0] >= i * (255 / i));
				int index = (int)array[0] % i;
				i--;
				int value = list[index];
				list[index] = list[i];
				list[i] = value;
			}
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoCurrentSequence"] = list;
			string text = "";
			foreach (int num in list)
			{
				text += num.ToString();
			}
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoInsertSequence"] = null;
			if (A_0)
			{
				serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoStatus"] = "initial";
			}
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoCurrentSequenceString"] = text;
			serviceOrThrow.aqu().r()["loc_up_emergencyPhoneHideoutTwoSequenceStatus"] = "new";
		}
	}

	// Token: 0x060043D8 RID: 17368 RVA: 0x001AB0B4 File Offset: 0x001A92B4
	private void a(string A_0, string A_1)
	{
		if (string.IsNullOrEmpty(A_0) && string.IsNullOrEmpty(A_1))
		{
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow == null)
		{
			return;
		}
		List<int> list = new List<int>
		{
			serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up_emergencyPhoneNumber_redCross", new int?(0)).Value,
			serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up_emergencyPhoneNumber_rat", new int?(0)).Value,
			serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up_emergencyPhoneNumber_security", new int?(0)).Value,
			serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up_emergencyPhoneNumber_wrench", new int?(0)).Value,
			serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up_emergencyPhoneNumber_hazard", new int?(0)).Value,
			serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up_emergencyPhoneNumber_info", new int?(0)).Value
		};
		if (list.Count < 6)
		{
			return;
		}
		string text = "";
		for (int i = 0; i < A_0.Length; i++)
		{
			int num = 0;
			foreach (int num2 in list)
			{
				if (num2 == 0)
				{
					return;
				}
				if (int.Parse(A_0.Substring(i, 1)) == num2)
				{
					num = list.IndexOf(num2) + 1;
				}
			}
			text += num.ToString();
		}
		if (text.Length == A_0.Length)
		{
			serviceOrThrow.aqu().r()[A_1] = text;
			return;
		}
		serviceOrThrow.aqu().r()[A_1] = A_0;
	}
}
