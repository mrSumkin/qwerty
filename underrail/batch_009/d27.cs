using System;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F3 RID: 5107
public class d27 : ay7
{
	// Token: 0x060072EB RID: 29419 RVA: 0x00306768 File Offset: 0x00304968
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		if (A_0 != null && A_1 != null)
		{
			A_0.a8().c().a("ChopChopAttack");
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			this.a(qy, A_0, A_1);
			A_0.a8().Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
	}

	// Token: 0x060072EC RID: 29420 RVA: 0x003067D4 File Offset: 0x003049D4
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}

	// Token: 0x060072ED RID: 29421 RVA: 0x003067D8 File Offset: 0x003049D8
	private void a(qy A_0, amc A_1, amc A_2)
	{
		cmn cmn = awq.b(A_1, A_2, null);
		bke bke = new bke();
		bke.g("Blade");
		bke.a(0);
		bke.f(0.1);
		bke.c(as3.bk);
		bke.d(as3.bk);
		bke.b(1f);
		bke.a(btz.g);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(esu.b);
		bke.a(bhx.a);
		bke.a(AmmoType.Sword);
		bke.g(true);
		bke.b(true);
		bke.l().Add(new a1q(DamageType.Mechanical, 30, 50));
		bke bke2 = new bke();
		bke2.g("Buzzsaw");
		bke2.a(0);
		bke2.f(0.05);
		bke2.c(as3.bk);
		bke2.d(as3.bk);
		bke2.b(1f);
		bke2.a(btz.g);
		bke2.a(ImpactSpeed.Low);
		bke2.a(esu.b);
		bke2.a(bhx.a);
		bke2.a(AmmoType.Sword);
		bke2.g(true);
		bke2.b(true);
		bke2.l().Add(new a1q(DamageType.Mechanical, 10, 18));
		bke2.l().Add(new a1q(DamageType.Mechanical, 10, 18));
		bke2.l().Add(new a1q(DamageType.Mechanical, 10, 18));
		bke2.aa().Add(new edm("bleedingWound", 0.25, 30, true));
		bke2.aa().Add(new edm("bleedingWound", 0.25, 30, true));
		bke2.aa().Add(new edm("bleedingWound", 0.25, 30, true));
		bke bke3 = new bke();
		bke3.g("Serrated Blade");
		bke3.a(0);
		bke3.f(0.1);
		bke3.c(as3.bk);
		bke3.d(as3.bk);
		bke3.b(1f);
		bke3.a(btz.g);
		bke3.a(ImpactSpeed.VeryLow);
		bke3.a(esu.b);
		bke3.a(bhx.a);
		bke3.a(AmmoType.Sword);
		bke3.g(true);
		bke3.b(true);
		bke3.l().Add(new a1q(DamageType.Mechanical, 20, 40));
		bke3.aa().Add(new edm("bleedingWound", 1.0, 100, true));
		cd1 cd = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
		cd1 cd2 = new cd1(new IndependentItemDefinitionProvider<bke>(bke2));
		cd1 cd3 = new cd1(new IndependentItemDefinitionProvider<bke>(bke3));
		efk a_ = A_1.aa();
		efk a_2 = A_2.aa();
		cmn a_3 = cmn;
		double a_4 = 0.0;
		cd1 a_5 = cd;
		cwt cwt = euf.a(a_, a_2, a_3, a_4, null, 1.0, a_5, true);
		cwt.k = "Blade";
		efk a_6 = A_1.aa();
		efk a_7 = A_2.aa();
		cmn a_8 = cmn;
		double a_9 = 0.0;
		a_5 = cd2;
		cwt cwt2 = euf.a(a_6, a_7, a_8, a_9, null, 1.0, a_5, true);
		cwt2.o = 0.33;
		cwt2.k = "Buzzsaw";
		efk a_10 = A_1.aa();
		efk a_11 = A_2.aa();
		cmn a_12 = cmn;
		double a_13 = 0.0;
		a_5 = cd3;
		cwt cwt3 = euf.a(a_10, a_11, a_12, a_13, null, 1.0, a_5, true);
		cwt3.k = "Serrated Blade";
		A_0.ad().Add(new a89(A_1, A_2, cwt, cd, null));
		A_0.ad().Add(new bm3(dz6.b(50)));
		A_0.ad().Add(new a89(A_1, A_2, cwt2, cd2, null));
		A_0.ad().Add(new bm3(dz6.b(50)));
		A_0.ad().Add(new a89(A_1, A_2, cwt3, cd3, null));
		A_0.ad().Add(new bm3(dz6.b(50)));
	}
}
