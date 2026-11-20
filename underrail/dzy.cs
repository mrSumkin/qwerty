using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Ouroboros.Common.Aspects;

// Token: 0x02000F6F RID: 3951
[eiz("LMSCEA")]
[Serializable]
public sealed class dzy : Aspect<c5x>, bp1, chb, c98
{
	// Token: 0x0600504D RID: 20557 RVA: 0x0023FF9C File Offset: 0x0023E19C
	private dzy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.m = A_0.GetDouble("LMSCEA:C");
		this.n = A_0.GetInt32("LMSCEA:P");
		this.o = A_0.GetInt32("LMSCEA:T");
		this.l = (A_0.GetValue("LMSCEA:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
	}

	// Token: 0x0600504E RID: 20558 RVA: 0x00240010 File Offset: 0x0023E210
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LMSCEA:C", this.m);
		info.AddValue("LMSCEA:P", this.n);
		info.AddValue("LMSCEA:T", this.o);
		info.AddValue("LMSCEA:E", this.l);
	}

	// Token: 0x0600504F RID: 20559 RVA: 0x0024006C File Offset: 0x0023E26C
	public int f()
	{
		return this.o;
	}

	// Token: 0x06005050 RID: 20560 RVA: 0x00240074 File Offset: 0x0023E274
	public void a(int A_0)
	{
		this.o = d05.a(0, A_0, dzy.h + dzy.f - 1);
	}

	// Token: 0x06005051 RID: 20561 RVA: 0x00240094 File Offset: 0x0023E294
	static dzy()
	{
		dzy.h = dzy.d + dzy.e * dzy.i;
		dzy.g = dzy.d + dzy.e * dzy.i + dzy.f;
		dzy.k = new List<dzy.a>
		{
			new dzy.a(new Guid("1fc39018-8f83-4794-b348-0e3932504ee9"), 1, 818, "xpbl_LemurianSubDive", 1f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("07a257b1-7a73-4361-99f2-a661349bf15c"), 816, 3, "xpbl_LemurianSubSurface", 1f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("4744530e-3b4b-4d2c-b9a7-7141ede0b6a1"), 6, null, 1f, null, "::Вы улавливаете смутные очертания затонувших судов и обломков вокруг себя, прежде чем погрузиться во тьму.::", null, true, 1.0, false, false),
			new dzy.a(new Guid("418ac5b3-7416-44d7-ba16-07a5041e9a54"), 28, 27, "xpbl_LemurianSubHeadlightsToggle", 1f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("6c845657-a8dd-470b-9bc2-c6cc54072e26"), 120, null, 1f, null, "::Стены всё сближаются. Вы спускаетесь в какое-то ущелье.::", null, true, 1.0, false, false),
			new dzy.a(new Guid("a3d13179-acfc-43c5-b622-725a6de1b6bd"), 145, 165, "xpbl_SubmarineGroan5", 0.6f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("55d7c138-4e4c-4ce9-b554-6bffde6b4821"), 185, null, 1f, "Что это было? ::Вы выглядываете наружу.::", null, null, true, 1.0, false, false),
			new dzy.a(new Guid("402a3062-1e64-41f1-8f45-8c297043ceee"), 225, 330, "xpbl_SubmarineGroan4", 0.5f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("583ec254-30fe-4559-8068-b14f584fd3a0"), 230, null, 1f, "Хм.", null, null, true, 1.0, false, false),
			new dzy.a(new Guid("dd62a5ec-dfd2-4511-85e3-c7c7568a6683"), 285, null, 1f, null, "::Вы видите синий свет на одной из стен. Маяк. Затем пространство вокруг вас снова расширяется...::", null, true, 1.0, false, false),
			new dzy.a(new Guid("a1f61de7-fb0f-4edc-ade7-b1ea6d25121a"), 366, "MutagenTankBreaks", 0.7f, "...", null, null, true, 1.0, true, false),
			new dzy.a(new Guid("ac1a6987-f872-4117-ad66-ddcaf2045f39"), 381, "xpbl_AbyssalMonsterVocalization1", 1f, null, null, null, true, 1.0, false, false),
			new dzy.a(new Guid("ad89be95-24a9-4f5e-a92f-411927ed6247"), 420, "xpbl_AbyssalMonsterVocalization2", 1f, null, null, null, true, 1.0, false, false),
			new dzy.a(new Guid("e8fe7553-8344-4747-b8ec-72085701d2d4"), 470, 490, "xpbl_SubmarineGroan4", 1.3f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("cf01a49c-4bdc-4a11-9ad2-e248104e6c28"), 510, "xpbl_SubmarineGroan3", 1.7f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("705c5b48-27bd-455e-b908-8b98f7a962ca"), 534, "xpbl_SubmarineGroan1", 1.7f, null, null, null, true, 1.0, false, false),
			new dzy.a(new Guid("eacb3b20-2263-4916-8f6b-d5ccd3b8239b"), 564, "xpbl_SubmarineGroan2", 1.8f, null, null, null, true, 1.0, false, false),
			new dzy.a(new Guid("54ef37a5-ff68-42e3-b9ff-da5a7d7bdd06"), 578, "xpbl_SubmarineGroan3", 1.8f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("bacf424d-ff06-4ec0-8095-06c013a5a61d"), 609, "xpbl_SubmarineGroan4", 1.8f, "Не раскисай, чёрт возьми.", null, null, true, 1.0, false, false),
			new dzy.a(new Guid("83ec5612-d3f8-4865-9f05-9bb9ea40212a"), 632, "xpbl_SubmarineGroan3", 1.8f, null, null, null, true, 1.0, false, false),
			new dzy.a(new Guid("06799137-5a1e-47a6-9d1d-3c19d05284c7"), 650, "xpbl_SubmarineGroan1", 1.8f, null, null, null, true, 1.0, false, false),
			new dzy.a(new Guid("6aa376c3-6062-4781-85e0-87db7459b5a8"), 670, null, 1f, null, "::Вы видите очередной маяк.::", null, true, 1.0, false, false),
			new dzy.a(new Guid("996c023c-a8d0-42e4-8126-11742977a343"), 680, "xpbl_SubmarineGroan3", 2f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("abd3c80c-bde4-4f7d-ba67-abfc96f4b3f0"), 690, "xpbl_SubmarineGroan5", 2f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("dddfd974-6b7a-4f92-b92f-63b21f4ff5e5"), 700, "xpbl_SubmarineGroan4", 2f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("ecd9df52-b5a2-495c-b1c0-8ccada161d7d"), 710, "xpbl_SubmarineGroan2", 2f, "Ну же...", null, null, true, 1.0, false, false),
			new dzy.a(new Guid("6e5cfbca-2f0f-4f52-8569-d75e973a861a"), 725, null, 1f, null, "::Ещё один маяк. Должно быть, станция близко.::", null, true, 1.0, false, false),
			new dzy.a(new Guid("2465ed7e-de0b-4398-a769-0f71f2834a38"), 730, "xpbl_SubmarineGroan3", 1.9f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("ac72ad04-dce9-4848-94d3-e4ab771dbf9d"), 741, "xpbl_SubmarineGroan4", 1.8f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("bcf06bb2-e94d-4e09-b03b-9d1f50570cca"), -1, 780, null, 1f, null, null, "Мы... мы движемся!", true, 1.0, false, false),
			new dzy.a(new Guid("a916072c-3b60-4d37-ac6f-8e117d1e6459"), -1, 663, null, 1f, null, null, "Почему...?", true, 1.0, false, false),
			new dzy.a(new Guid("d4d17dc7-1d7b-47f6-823e-3a010237802e"), -1, 662, null, 1f, "Без вопросов.", null, null, true, 1.0, false, true),
			new dzy.a(new Guid("64348c20-656d-441e-8ca9-6ec92caac307"), -1, 640, "xpbl_SubmarineGroan5", 1f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("a537a7de-966a-4718-b439-355c2ef25f50"), -1, 547, null, 1f, null, null, "::Вздыхает.::", true, 1.0, false, false),
			new dzy.a(new Guid("08f31bf8-9f9f-452f-82f3-9feaf1a1f595"), -1, 462, null, 1f, null, null, "::Его дыхание учащается...::", true, 1.0, false, false),
			new dzy.a(new Guid("59796761-5b21-4d06-899e-b6b0624c6b8e"), -1, 415, "xpbl_SubmarineGroan4", 1f, null, null, null, false, 1.0, false, false),
			new dzy.a(new Guid("2c90fe52-0159-4cde-b385-e4f316571b8d"), -1, 410, null, 1f, null, null, "::...но он закрывает глаза и успокаивается.::", true, 1.0, false, false),
			new dzy.a(new Guid("a20a651e-5f24-4a5a-b727-2240aa07fefb"), -1, 285, null, 1f, null, "::Здесь должен быть маяк, но кругом лишь тьма. Хотя в воде довольно много частичек пыли.::", null, true, 1.0, false, false),
			new dzy.a(new Guid("1745ef88-0fc0-4a6c-9577-40f6437cb83b"), -1, 225, "xpbl_AbyssalMonsterVocalization2", 1f, null, null, "::Поднимает взгляд.:: Что это...?", true, 1.0, false, false),
			new dzy.a(new Guid("bd652e14-a815-45a6-9bbc-939e27c02262"), -1, 223, null, 1f, "Шшшшш...", null, null, true, 1.0, false, true),
			new dzy.a(new Guid("edfa5d58-89b6-4e52-84b2-8fb74e130877"), -1, 54, null, 1f, null, null, "Сколько...?", true, 1.0, false, false),
			new dzy.a(new Guid("3c681d87-8daf-4ebb-b624-1890c4ec0d0d"), -1, 54, null, 1f, "Мы почти на месте.", null, null, true, 1.0, false, true)
		};
	}

	// Token: 0x06005052 RID: 20562 RVA: 0x0024099C File Offset: 0x0023EB9C
	public dzy(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005053 RID: 20563 RVA: 0x002409B0 File Offset: 0x0023EBB0
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if ((this.m += A_0.b.TotalMilliseconds) >= (double)dzy.b)
			{
				this.m -= (double)dzy.b;
				this.b();
			}
		}
		else
		{
			this.m = 0.0;
		}
		this.a(A_0);
		this.b(A_0);
		this.e();
		if ((this.q += A_0.b.TotalMilliseconds) >= (double)dzy.a)
		{
			this.q = 0.0;
			if (this.d() && this.n > dzy.d && this.n < dzy.h + 30)
			{
				base.a8().c().a("xpbl_LemurianSubSonarPing");
				this.a();
			}
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = new ar7(new Guid("9afee91f-0b67-4b60-8ecf-3c369ac13c40"), base.a8().Area).ao() as c5x;
			if (c5x != null)
			{
				d85 d = c5x.GetAspect<bim>() as d85;
				if (d != null)
				{
					d.a()[0] = this.g().ToString() + "m";
				}
			}
			if (this.o > this.n)
			{
				serviceOrThrow.aqu().r()["vehicle_xpbl_submarine_state"] = "diving";
			}
			if (this.o < this.n)
			{
				serviceOrThrow.aqu().r()["vehicle_xpbl_submarine_state"] = "surfacing";
			}
			bim aspect = (new ar7(new Guid("fae0be13-9d4e-44e3-9ba1-dfb7a8597ae4"), base.a8().Area).ao() as c5x).GetAspect<bim>();
			if (this.d())
			{
				serviceOrThrow.aqu().r()["vehicle_xpbl_submarine_inTransit"] = true;
				aspect.g(false);
				return;
			}
			if (this.n != 0)
			{
				serviceOrThrow.aqu().r()["vehicle_xpbl_submarine_atAbyssal"] = true;
			}
			else
			{
				serviceOrThrow.aqu().r()["vehicle_xpbl_submarine_atAbyssal"] = false;
			}
			serviceOrThrow.aqu().r()["vehicle_xpbl_submarine_inTransit"] = false;
			aspect.g(true);
		}
	}

	// Token: 0x06005054 RID: 20564 RVA: 0x00240C3C File Offset: 0x0023EE3C
	public void c()
	{
		int num = d0u.b / dzy.b;
		for (int i = 0; i < num; i++)
		{
			this.b();
		}
		this.m = 0.0;
	}

	// Token: 0x06005055 RID: 20565 RVA: 0x00240C7C File Offset: 0x0023EE7C
	public void mx()
	{
	}

	// Token: 0x06005056 RID: 20566 RVA: 0x00240C80 File Offset: 0x0023EE80
	public void my()
	{
	}

	// Token: 0x06005057 RID: 20567 RVA: 0x00240C84 File Offset: 0x0023EE84
	public int g()
	{
		return Convert.ToInt32((double)Math.Min(this.n, dzy.h) / (double)dzy.h * (double)dzy.j);
	}

	// Token: 0x06005058 RID: 20568 RVA: 0x00240CAC File Offset: 0x0023EEAC
	private void e()
	{
		if (this.d())
		{
			SoundState? soundState = base.a8().c().b("subAmbientMove");
			SoundState soundState2 = SoundState.Playing;
			if (!(soundState.GetValueOrDefault() == soundState2 & soundState != null))
			{
				base.a8().c().a("subAmbientMove", "xpbl_LemurianSubmarineMove", 1f, c9z.b, true, false);
			}
			soundState = base.a8().c().b("subAmbientRest");
			soundState2 = SoundState.Playing;
			if (soundState.GetValueOrDefault() == soundState2 & soundState != null)
			{
				base.a8().c().a("subAmbientRest", false);
				return;
			}
		}
		else
		{
			SoundState? soundState = base.a8().c().b("subAmbientRest");
			SoundState soundState2 = SoundState.Playing;
			if (!(soundState.GetValueOrDefault() == soundState2 & soundState != null))
			{
				base.a8().c().a("subAmbientRest", "xpbl_LemurianSubmarineRest", 1f, c9z.b, true, false);
			}
			soundState = base.a8().c().b("subAmbientMove");
			soundState2 = SoundState.Playing;
			if (soundState.GetValueOrDefault() == soundState2 & soundState != null)
			{
				base.a8().c().a("subAmbientMove", false);
			}
		}
	}

	// Token: 0x06005059 RID: 20569 RVA: 0x00240DF8 File Offset: 0x0023EFF8
	private bool d()
	{
		return this.n != this.o;
	}

	// Token: 0x0600505A RID: 20570 RVA: 0x00240E0C File Offset: 0x0023F00C
	private void b()
	{
		this.p = false;
		int num;
		if (this.o < this.n)
		{
			this.n--;
			num = -1;
		}
		else if (this.o > this.n)
		{
			this.n++;
			num = 1;
		}
		else
		{
			this.p = true;
			num = 0;
		}
		if (!this.p)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			c5x c5x = new ar7(new Guid("8b993b71-2472-446c-a9ba-30099404c50d"), base.a8().Area).ao() as c5x;
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
				foreach (dzy.a a in dzy.k)
				{
					if ((!a.i || !this.l.Contains(a.a)) && cuo.a.NextDouble() < a.j && ((num == 1 && a.b == this.n) || (num == -1 && a.c == this.n)))
					{
						this.l.Add(a.a);
						if (!string.IsNullOrWhiteSpace(a.d))
						{
							base.a8().c().a(Guid.NewGuid().ToString(), a.d, a.e, c9z.a, false, false);
						}
						if (!string.IsNullOrWhiteSpace(a.g))
						{
							c0s aspect = base.a8().GetAspect<c0s>();
							if (aspect != null)
							{
								aspect.a(a.g, true, null, null);
							}
						}
						if (!string.IsNullOrWhiteSpace(a.h) && c5x != null)
						{
							c0s aspect2 = c5x.GetAspect<c0s>();
							if (aspect2 != null)
							{
								aspect2.a(a.h, true, null, null);
							}
						}
						if (a.k)
						{
							ps service = bpo.GetService<ps>();
							if (service != null)
							{
								service.ane(800, null, null, null, null, null);
							}
						}
						if (!string.IsNullOrWhiteSpace(a.f) && c5x2 != null && (!a.l || c5x != null))
						{
							c0s aspect3 = c5x2.GetAspect<c0s>();
							if (aspect3 != null)
							{
								aspect3.a(a.f, true, null, null);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600505B RID: 20571 RVA: 0x00241140 File Offset: 0x0023F340
	private void b(eds A_0)
	{
		ah7 ah = base.a8().Zone.i("SurfaceLight");
		if (ah != null)
		{
			float a_;
			if (this.n < 25)
			{
				a_ = 0.5f * ((25f - (float)this.n) / 25f);
			}
			else
			{
				a_ = 0f;
			}
			this.a(ah, a_);
		}
		ah7 ah2 = base.a8().Zone.i("SubmarineHeadLights");
		if (ah2 != null)
		{
			float a_2;
			if (this.n >= 28)
			{
				a_2 = 0.3f;
			}
			else
			{
				a_2 = 0f;
			}
			this.a(ah2, a_2);
		}
		ah7 ah3 = base.a8().Zone.i("DocksLight");
		if (ah3 != null)
		{
			float a_3;
			if (this.n > dzy.h)
			{
				if (this.o < this.n)
				{
					a_3 = 0.5f * Math.Min(1f, (float)Math.Max(0, this.n + 33 - (dzy.h + dzy.f)) / 33f);
				}
				else
				{
					a_3 = 0.5f * Math.Min(1f, (float)Math.Max(0, this.n - (dzy.h + 40)) / 5f);
				}
			}
			else
			{
				a_3 = 0f;
			}
			this.a(ah3, a_3);
		}
	}

	// Token: 0x0600505C RID: 20572 RVA: 0x002412A4 File Offset: 0x0023F4A4
	private void a(ah7 A_0, float A_1)
	{
		if (A_1 > 0f)
		{
			A_0.Enabled = true;
			A_0.Light = new ae8(A_0.Light.d(), A_1, A_0.Light.a());
		}
		else
		{
			A_0.Enabled = false;
			A_0.Light = new ae8(A_0.Light.d(), 0f, A_0.Light.a());
		}
		A_0.d();
	}

	// Token: 0x0600505D RID: 20573 RVA: 0x0024132C File Offset: 0x0023F52C
	private void a(eds A_0)
	{
		string str;
		int num;
		if (this.p && this.n == 0)
		{
			str = "xpbl_SubmarineWindowSurfaceLoop";
			num = (int)A_0.a.TotalMilliseconds / dzy.b % dzy.c;
		}
		else if (this.n < dzy.d)
		{
			str = "xpbl_SubmarineWindowDiveSurface";
			num = this.n;
		}
		else if (this.n < dzy.h)
		{
			str = "xpbl_SubmarineWindowDiveRepeat";
			num = this.n - dzy.d;
			num %= dzy.e;
		}
		else if (this.o < this.n)
		{
			str = "xpbl_SubmarineWindowDiveExit";
			num = dzy.f - (this.n - dzy.h);
		}
		else
		{
			str = "xpbl_SubmarineWindowDiveEnter";
			num = this.n - dzy.h;
		}
		if (base.a8().o.b != null)
		{
			Point point = new Point(num % 20, num / 20);
			base.a8().o.b.a = "Objects\\Vehicles\\" + str;
			base.a8().o.b.b = point;
		}
	}

	// Token: 0x0600505E RID: 20574 RVA: 0x00241468 File Offset: 0x0023F668
	private void a()
	{
		c5x c5x = new ar7(new Guid("8ddffaa5-91d3-421a-8727-d09b28dc3adc"), base.a8().Area).ao() as c5x;
		if (c5x != null)
		{
			dtb dtb = new dtb();
			List<auv> list = dtb.ad();
			ad6 ad = new ad6(c5x);
			ad.b(0.0);
			ad.c(1.0);
			ad.a(0.02);
			list.Add(ad);
			dtb.ad().Add(new bm3(200));
			List<auv> list2 = dtb.ad();
			ad6 ad2 = new ad6(c5x);
			ad2.b(1.0);
			ad2.c(0.0);
			ad2.a(0.0005);
			list2.Add(ad2);
			base.a8().Zone.ActionManager.g9(dtb, atp.a);
		}
	}

	// Token: 0x040020BD RID: 8381
	private static readonly int a = 3000;

	// Token: 0x040020BE RID: 8382
	private static readonly int b = 150;

	// Token: 0x040020BF RID: 8383
	private static readonly int c = 16;

	// Token: 0x040020C0 RID: 8384
	private static readonly int d = 32;

	// Token: 0x040020C1 RID: 8385
	private static readonly int e = 24;

	// Token: 0x040020C2 RID: 8386
	private static readonly int f = 68;

	// Token: 0x040020C3 RID: 8387
	private static readonly int g;

	// Token: 0x040020C4 RID: 8388
	private static readonly int h;

	// Token: 0x040020C5 RID: 8389
	private static readonly int i = 30;

	// Token: 0x040020C6 RID: 8390
	private static readonly int j = 1437;

	// Token: 0x040020C7 RID: 8391
	private static List<dzy.a> k;

	// Token: 0x040020C8 RID: 8392
	private HashSet<Guid> l = new HashSet<Guid>();

	// Token: 0x040020C9 RID: 8393
	private double m;

	// Token: 0x040020CA RID: 8394
	private int n;

	// Token: 0x040020CB RID: 8395
	private int o;

	// Token: 0x040020CC RID: 8396
	[NonSerialized]
	private bool p;

	// Token: 0x040020CD RID: 8397
	[NonSerialized]
	private double q;

	// Token: 0x02000F72 RID: 3954
	private sealed class a
	{
		// Token: 0x06005062 RID: 20578 RVA: 0x00241550 File Offset: 0x0023F750
		public a(Guid A_0, int A_1, string A_2 = null, float A_3 = 1f, string A_4 = null, string A_5 = null, string A_6 = null, bool A_7 = false, double A_8 = 1.0, bool A_9 = false, bool A_10 = false) : this(A_0, A_1, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10)
		{
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00241578 File Offset: 0x0023F778
		public a(Guid A_0, int A_1, int A_2, string A_3 = null, float A_4 = 1f, string A_5 = null, string A_6 = null, string A_7 = null, bool A_8 = false, double A_9 = 1.0, bool A_10 = false, bool A_11 = false)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
			this.e = A_4;
			this.f = A_5;
			this.g = A_6;
			this.h = A_7;
			this.i = A_8;
			this.j = A_9;
			this.k = A_10;
			this.l = A_11;
		}

		// Token: 0x040020CE RID: 8398
		public Guid a;

		// Token: 0x040020CF RID: 8399
		public int b = -1;

		// Token: 0x040020D0 RID: 8400
		public int c = -1;

		// Token: 0x040020D1 RID: 8401
		public string d;

		// Token: 0x040020D2 RID: 8402
		public float e;

		// Token: 0x040020D3 RID: 8403
		public string f;

		// Token: 0x040020D4 RID: 8404
		public string g;

		// Token: 0x040020D5 RID: 8405
		public string h;

		// Token: 0x040020D6 RID: 8406
		public bool i;

		// Token: 0x040020D7 RID: 8407
		public double j;

		// Token: 0x040020D8 RID: 8408
		public bool k;

		// Token: 0x040020D9 RID: 8409
		public bool l;
	}
}
