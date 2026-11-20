using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000B65 RID: 2917
[eiz("CCSBHDJ")]
[Serializable]
public sealed class dah : cze, ISerializable
{
	// Token: 0x060042BE RID: 17086 RVA: 0x0019E910 File Offset: 0x0019CB10
	private dah(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042BF RID: 17087 RVA: 0x0019E91C File Offset: 0x0019CB1C
	public dah()
	{
	}

	// Token: 0x060042C0 RID: 17088 RVA: 0x0019E924 File Offset: 0x0019CB24
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("dun_cc_sBombersKilled", new int?(0)).Value;
				num++;
				serviceOrThrow.aqu().r()["dun_cc_sBombersKilled"] = num;
				c5x c5x2 = new ar7(new Guid("97cd18e7-7de2-469e-a9cb-021c7bbdfe80"), c5x.Area).ao() as c5x;
				bool flag = false;
				if (c5x2 != null && c5x2.h != null && c5x2.h.b.aa().IsInCombat && A_1 != c5x2 && !c5x2.h.b.aa().Dead)
				{
					flag = true;
				}
				c5x c5x3 = new ar7(new Guid("1bf97cb7-30a4-41a7-917e-c9b2c52e222e"), c5x.Area).ao() as c5x;
				bool flag2 = false;
				if (c5x3 != null && c5x3.h != null && c5x3.h.b.aa().IsInCombat && A_1 != c5x3 && !c5x3.h.b.aa().Dead)
				{
					flag2 = true;
				}
				c5x c5x4 = new ar7(new Guid("27a6587b-4e20-464d-80ba-7026b3c75a00"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("af5f02be-9803-49ef-b89a-c22aec2d61d1"), c5x.Area).ao() as c5x;
				bool flag3 = false;
				if (c5x4 != null && c5x4.h != null && c5x4.h.b.aa().IsInCombat && A_1 != c5x4 && !c5x4.h.b.aa().Dead)
				{
					flag3 = true;
				}
				bool flag4 = false;
				if (c5x5 != null && c5x5.h != null && c5x5.h.b.aa().IsInCombat && A_1 != c5x5 && !c5x5.h.b.aa().Dead)
				{
					flag4 = true;
				}
				awx awx = new awx();
				if (flag && flag2 && (!flag4 && !flag3))
				{
					c5x2.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
					c5x2.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
					c5x3.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
					c5x3.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
					List<auv> list = awx.ad();
					egx egx = new egx();
					egx.a("Её усилия не пропадут даром! Мы всех взорвём!");
					a4s a4s = new a4s(egx, null, null, null);
					a4s.b(new ar7(c5x2));
					list.Add(a4s);
					awx.ad().Add(new bm3(cuo.a.Next(650, 1000)));
					List<auv> list2 = awx.ad();
					egx egx2 = new egx();
					egx2.a("Проклятый трубочист! Такие, как ты, никогда не увидят истинного света! Тебе останется только сгореть в нём.");
					a4s a4s2 = new a4s(egx2, null, null, null);
					a4s2.b(new ar7(c5x3));
					list2.Add(a4s2);
					c5x.i.b.b(awx, atp.a);
					return;
				}
				if (flag && (flag3 || flag4) && !flag2)
				{
					List<auv> list3 = awx.ad();
					egx egx3 = new egx();
					egx3.a("Лазер, нет! Он не выдохнется просто так!");
					a4s a4s3 = new a4s(egx3, null, null, null);
					a4s3.b(new ar7(c5x2));
					list3.Add(a4s3);
					awx.ad().Add(new bm3(cuo.a.Next(650, 1000)));
					c5x2.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
					c5x2.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
					if (flag3 && c5x4 != null)
					{
						c5x4.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
						c5x4.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
						List<auv> list4 = awx.ad();
						egx egx4 = new egx();
						egx4.a("Ар-р-р! Я превращу тебя в пыль! ::Оглядывается:: М-мы сможем это провернуть!");
						a4s a4s4 = new a4s(egx4, null, null, null);
						a4s4.b(new ar7(c5x4));
						list4.Add(a4s4);
					}
					else if (flag4 && c5x5 != null)
					{
						c5x5.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
						c5x5.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
						List<auv> list5 = awx.ad();
						egx egx5 = new egx();
						egx5.a("Чёрт... Ар-р-р, я разнесу твой мозг вдребезги за это!");
						a4s a4s5 = new a4s(egx5, null, null, null);
						a4s5.b(new ar7(c5x5));
						list5.Add(a4s5);
					}
					c5x.i.b.b(awx, atp.a);
					return;
				}
				if (flag2 && (flag3 || flag4) && !flag)
				{
					List<auv> list6 = awx.ad();
					egx egx6 = new egx();
					egx6.a("Крушитель, нет! Твой молот взлетит высоко! Твоя слава не умрёт!");
					a4s a4s6 = new a4s(egx6, null, null, null);
					a4s6.b(new ar7(c5x3));
					list6.Add(a4s6);
					awx.ad().Add(new bm3(cuo.a.Next(650, 1000)));
					c5x3.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
					c5x3.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
					if (flag3 && c5x4 != null)
					{
						c5x4.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
						c5x4.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
						List<auv> list7 = awx.ad();
						egx egx7 = new egx();
						egx7.a("Мы... мы нуждались в нем больше всего... А-а-ар!");
						a4s a4s7 = new a4s(egx7, null, null, null);
						a4s7.b(new ar7(c5x4));
						list7.Add(a4s7);
					}
					else if (flag4 && c5x5 != null)
					{
						c5x5.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
						c5x5.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 1), false, false, false);
						List<auv> list8 = awx.ad();
						egx egx8 = new egx();
						egx8.a("Этого... этого не может быть! Я... Я...");
						a4s a4s8 = new a4s(egx8, null, null, null);
						a4s8.b(new ar7(c5x5));
						list8.Add(a4s8);
					}
					c5x.i.b.b(awx, atp.a);
					return;
				}
				if (flag && !flag2 && (!flag4 && !flag3))
				{
					this.a(c5x2);
					c5x2.h.b.aa().StatusEffects.a(new awz(0, 0.35), false, false, false);
					c5x2.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.2f, 0, 0, 25, 2), false, false, false);
					c5x2.h.b.aa().ImmunitiesBase |= CharacterImmunities.Root;
					awx.ad().Add(new bm3(cuo.a.Next(125, 450)));
					List<auv> list9 = awx.ad();
					egx egx9 = new egx();
					egx9.a("Всё сводится к нам двоим! ::Неудержимо трясётся:: А-А-А, время всему ВЗОРВАТЬСЯ! ::Вытаскивает ремень и обвязывается им.::");
					a4s a4s9 = new a4s(egx9, null, null, null);
					a4s9.b(new ar7(c5x2));
					list9.Add(a4s9);
					c5x.i.b.b(awx, atp.a);
					return;
				}
				if (flag2 && !flag && (!flag4 && !flag3))
				{
					this.a(c5x3);
					c5x3.h.b.aa().StatusEffects.a(new awz(0, 0.35), false, false, false);
					c5x3.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.2f, 0, 0, 25, 2), false, false, false);
					c5x3.h.b.aa().ImmunitiesBase |= CharacterImmunities.Root;
					awx.ad().Add(new bm3(cuo.a.Next(125, 355)));
					List<auv> list10 = awx.ad();
					egx egx10 = new egx();
					egx10.a("В огне мы были выкованы, в огне ВЫ И ПОГИБНЕТЕ! ::Неконтролируемо дёргается.::");
					a4s a4s10 = new a4s(egx10, null, null, null);
					a4s10.b(new ar7(c5x3));
					list10.Add(a4s10);
					c5x.i.b.b(awx, atp.a);
					return;
				}
				if (flag3 && !flag && !flag2 && c5x4 != null)
				{
					this.a(c5x4);
					c5x4.h.b.aa().StatusEffects.a(new awz(0, 0.35), false, false, false);
					c5x4.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.2f, 0, 0, 25, 2), false, false, false);
					c5x4.h.b.aa().ImmunitiesBase |= CharacterImmunities.Root;
					awx.ad().Add(new bm3(cuo.a.Next(125, 255)));
					List<auv> list11 = awx.ad();
					egx egx11 = new egx();
					egx11.a("Вы не можете отложить неизбежное! Наше дело увенчается успехом! И если это означает, что мы все умрём, так тому и быть!");
					a4s a4s11 = new a4s(egx11, null, null, null);
					a4s11.b(new ar7(c5x4));
					list11.Add(a4s11);
					c5x.i.b.b(awx, atp.a);
					return;
				}
				if (flag4 && !flag && !flag2 && c5x5 != null)
				{
					this.a(c5x5);
					c5x5.h.b.aa().StatusEffects.a(new awz(0, 0.35), false, false, false);
					c5x5.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.2f, 0, 0, 25, 2), false, false, false);
					c5x5.h.b.aa().ImmunitiesBase |= CharacterImmunities.Root;
					awx.ad().Add(new bm3(cuo.a.Next(225, 355)));
					List<auv> list12 = awx.ad();
					egx egx12 = new egx();
					egx12.a("Ты хоть понимаешь, кого пытаешься спасти?! Они ВСЕ ПОТЕРЯНЫ, и ты тоже!");
					a4s a4s12 = new a4s(egx12, null, null, null);
					a4s12.b(new ar7(c5x5));
					list12.Add(a4s12);
					c5x.i.b.b(awx, atp.a);
				}
				return;
			}
		}
	}

	// Token: 0x060042C1 RID: 17089 RVA: 0x0019F5C8 File Offset: 0x0019D7C8
	private void a(c5x A_0)
	{
		int num = 0;
		foreach (coh coh in Enumerable.ToList<coh>(A_0.h.b.aa().Bag.z2()))
		{
			if (coh.Definition.bi() == a0.r)
			{
				A_0.h.b.aa().Gear.d()[num++].po(coh);
			}
			if (coh.Definition.a5() == "suicideBomberBelt")
			{
				A_0.h.b.aa().Gear.e().po(coh);
				A_0.h.b.aa().Bag.z5(coh);
			}
		}
	}
}
