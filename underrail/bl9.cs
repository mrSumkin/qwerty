using System;
using System.IO;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FB7 RID: 8119
public static class bl9
{
	// Token: 0x0600BEB6 RID: 48822 RVA: 0x004197C4 File Offset: 0x004179C4
	public static void e()
	{
		bl9.c();
		bl9.b();
	}

	// Token: 0x0600BEB7 RID: 48823 RVA: 0x004197D0 File Offset: 0x004179D0
	public static void d()
	{
		dhn.a();
	}

	// Token: 0x0600BEB8 RID: 48824 RVA: 0x004197D8 File Offset: 0x004179D8
	public static char a(UiSize A_0)
	{
		return A_0.ToString()[0];
	}

	// Token: 0x0600BEB9 RID: 48825 RVA: 0x004197F0 File Offset: 0x004179F0
	private static void c()
	{
		d67 serviceOrThrow = bpo.GetServiceOrThrow<d67>();
		try
		{
			w3.a(Path.Combine(serviceOrThrow.lh().RootDirectory, "GUI"));
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Failed to preload GUI assets.", new object[0]);
		}
	}

	// Token: 0x0600BEBA RID: 48826 RVA: 0x0041984C File Offset: 0x00417A4C
	public static void b()
	{
		bcm bcm = bjn.b();
		d9d d9d = bjn.a();
		d9d.o7(new bnz(TimelapseCursor.Default.ToString(), bo1.b3, new Point(0, 0), 1, 500, new esj(23, 32), Vector2.Zero, 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Use.ToString(), bo1.b3, new Point(0, 100), 1, 500, new esj(20, 33), new Vector2(5f, 1f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.ForbiddenUse.ToString(), bo1.b3, new Point(562, 33), 1, 500, new esj(20, 33), new Vector2(5f, 1f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Impossible.ToString(), bo1.b3, new Point(24, 0), 1, 500, new esj(29, 29), new Vector2(15f, 15f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.InvokeSpell.ToString(), bo1.b3, new Point(0, 134), 20, 40, new esj(46, 46), new Vector2(23f, 23f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.InvokeHostileSpell.ToString(), bo1.b3, new Point(0, 181), 20, 40, new esj(46, 46), new Vector2(23f, 23f), 1f, 0));
		d9d.o7(new esm(TimelapseCursor.InvokeHostileSpellWithChance.ToString(), bo1.b3, new Point(0, 181), 20, 40, new esj(46, 46), new Vector2(23f, 23f), 1f));
		d9d.o7(new esm(TimelapseCursor.Attack.ToString(), bo1.b3, new Point(0, 33), 8, 40, new esj(35, 35), new Vector2(17f, 17f), 1f));
		d9d.o7(new esm(TimelapseCursor.SpecialAttack.ToString(), bo1.b3, new Point(281, 33), 8, 40, new esj(35, 35), new Vector2(17f, 17f), 1f));
		d9d.o7(new bnz(TimelapseCursor.Talk.ToString(), bo1.b3, new Point(0, 69), 4, 180, new esj(37, 30), new Vector2(19f, 15f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.AreaTransition.ToString(), bo1.b3, new Point(54, 0), 18, 50, new esj(25, 25), new Vector2(16f, 13f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Lock.ToString(), bo1.b3, new Point(493, 96), 6, 90, new esj(37, 37), new Vector2(19f, 19f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Lockpick.ToString(), bo1.b3, new Point(21, 100), 1, 500, new esj(31, 31), new Vector2(3f, 4f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Hack.ToString(), bo1.b3, new Point(53, 100), 20, 50, new esj(22, 33), new Vector2(1f, 3f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Pickpocket.ToString(), bo1.b3, new Point(583, 33), 1, 500, new esj(33, 33), new Vector2(9f, 21f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Power.ToString(), bo1.b3, new Point(505, 0), 1, 500, new esj(27, 31), new Vector2(14f, 16f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.ForbiddenPower.ToString(), bo1.b3, new Point(370, 68), 1, 500, new esj(27, 31), new Vector2(14f, 16f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Reload.ToString(), bo1.b3, new Point(533, 0), 1, 500, new esj(20, 33), new Vector2(6f, 0f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Wait.ToString(), bo1.b3, new Point(0, 228), 15, 100, new esj(32, 32), new Vector2(17f, 17f), 0.5f, 0));
		d9d.o7(new bnz(TimelapseCursor.DisarmTrap.ToString(), bo1.b3, new Point(617, 0), 1, 500, new esj(40, 40), new Vector2(5f, 5f), 1f, 0));
		d9d.o7(new esm(TimelapseCursor.GroundAttack.ToString(), bo1.b3, new Point(0, 33), 8, 40, new esj(35, 35), new Vector2(17f, 17f), 1f));
		d9d.o7(new bnz(TimelapseCursor.MultiUse.ToString(), bo1.b3, new Point(658, 0), 1, 500, new esj(29, 40), new Vector2(5f, 1f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.ForbiddenMultiUse.ToString(), bo1.b3, new Point(688, 0), 1, 500, new esj(29, 40), new Vector2(5f, 1f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Observe.ToString(), bo1.b3, new Point(149, 69), 1, 500, new esj(35, 19), new Vector2(17f, 9f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.ObserveMultiple.ToString(), bo1.b3, new Point(185, 69), 4, 250, new esj(46, 19), new Vector2(17f, 9f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Disembark.ToString(), bo1.b3, new Point(481, 228), 14, 75, new esj(33, 24), new Vector2(16f, 12f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.ForbiddenDisembark.ToString(), bo1.b3, new Point(481, 253), 14, 75, new esj(33, 24), new Vector2(16f, 12f), 1f, 0));
		d9d.o7(new bnz(TimelapseCursor.Hotwire.ToString(), bo1.b3, new Point(716, 96), 1, 500, new esj(29, 30), new Vector2(2f, 2f), 1f, 0));
		d9d.o7(new a3n());
		d9d.o7(new cqi());
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aq1() != null && service.aq1().b().t() != UiSize.Classic)
		{
			char c = bl9.a(service.aq1().b().t());
			string a_ = string.Format(bo1.b4, c);
			if (service.aq1().b().t() == UiSize.Huge)
			{
				d9d.o7(new bnz(TimelapseCursor.Default.ToString(), a_, new Point(1, 1), 1, 500, new esj(42, 58), Vector2.Zero, 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Use.ToString(), a_, new Point(48, 51), 1, 500, new esj(40, 61), new Vector2(16f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenUse.ToString(), a_, new Point(88, 51), 1, 500, new esj(40, 61), new Vector2(16f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Impossible.ToString(), a_, new Point(1, 61), 1, 500, new esj(45, 45), new Vector2(23f, 23f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.InvokeSpell.ToString(), a_, new Point(0, 411), 20, 40, new esj(100, 100), new Vector2(50f, 50f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.InvokeHostileSpell.ToString(), a_, new Point(0, 512), 20, 40, new esj(100, 100), new Vector2(50f, 50f), 1f, 0));
				d9d.o7(new esm(TimelapseCursor.InvokeHostileSpellWithChance.ToString(), a_, new Point(0, 512), 20, 40, new esj(100, 100), new Vector2(50f, 50f), 1f));
				d9d.o7(new esm(TimelapseCursor.Attack.ToString(), a_, new Point(1, 690), 12, 40, new esj(80, 80), new Vector2(40f, 40f), 1f));
				d9d.o7(new esm(TimelapseCursor.SpecialAttack.ToString(), a_, new Point(963, 690), 12, 40, new esj(80, 80), new Vector2(40f, 40f), 1f));
				d9d.o7(new bnz(TimelapseCursor.Talk.ToString(), a_, new Point(206, 41), 4, 180, new esj(57, 48), new Vector2(25f, 46f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.AreaTransition.ToString(), a_, new Point(1, 351), 18, 50, new esj(71, 59), new Vector2(50f, 30f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Lock.ToString(), a_, new Point(885, 298), 6, 90, new esj(37, 51), new Vector2(19f, 32f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Lockpick.ToString(), a_, new Point(130, 48), 1, 500, new esj(74, 64), new Vector2(9f, 12f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Hack.ToString(), a_, new Point(1, 176), 20, 50, new esj(58, 79), new Vector2(10f, 7f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Pickpocket.ToString(), a_, new Point(104, 1), 1, 500, new esj(59, 45), new Vector2(6f, 34f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Power.ToString(), a_, new Point(45, 114), 1, 500, new esj(54, 54), new Vector2(32f, 25f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenPower.ToString(), a_, new Point(99, 114), 1, 500, new esj(54, 54), new Vector2(32f, 25f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Reload.ToString(), a_, new Point(1, 108), 1, 500, new esj(42, 66), new Vector2(15f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Wait.ToString(), a_, new Point(1, 614), 26, 80, new esj(74, 74), new Vector2(37f, 37f), 0.5f, 0));
				d9d.o7(new bnz(TimelapseCursor.DisarmTrap.ToString(), a_, new Point(153, 114), 1, 500, new esj(60, 60), new Vector2(5f, 5f), 1f, 0));
				d9d.o7(new esm(TimelapseCursor.GroundAttack.ToString(), a_, new Point(1, 690), 12, 40, new esj(80, 80), new Vector2(40f, 40f), 1f));
				d9d.o7(new bnz(TimelapseCursor.MultiUse.ToString(), a_, new Point(215, 91), 1, 500, new esj(55, 74), new Vector2(15f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenMultiUse.ToString(), a_, new Point(270, 91), 1, 500, new esj(55, 74), new Vector2(15f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Observe.ToString(), a_, new Point(165, 1), 1, 500, new esj(74, 38), new Vector2(37f, 19f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ObserveMultiple.ToString(), a_, new Point(256, 1), 4, 250, new esj(92, 38), new Vector2(46f, 19f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Disembark.ToString(), a_, new Point(1, 257), 14, 75, new esj(63, 45), new Vector2(32f, 23f), 1f, 300));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenDisembark.ToString(), a_, new Point(1, 304), 14, 75, new esj(63, 45), new Vector2(32f, 23f), 1f, 300));
				d9d.o7(new bnz(TimelapseCursor.Hotwire.ToString(), a_, new Point(327, 91), 1, 500, new esj(60, 74), new Vector2(10f, 11f), 1f, 0));
			}
			else if (service.aq1().b().t() == UiSize.Large)
			{
				d9d.o7(new bnz(TimelapseCursor.Default.ToString(), a_, new Point(1, 1), 1, 500, new esj(35, 48), Vector2.Zero, 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Use.ToString(), a_, new Point(1, 51), 1, 500, new esj(31, 46), new Vector2(12f, 2f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenUse.ToString(), a_, new Point(32, 51), 1, 500, new esj(31, 46), new Vector2(12f, 2f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Impossible.ToString(), a_, new Point(240, 124), 1, 500, new esj(33, 33), new Vector2(17f, 17f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.InvokeSpell.ToString(), a_, new Point(0, 361), 20, 40, new esj(60, 60), new Vector2(30f, 30f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.InvokeHostileSpell.ToString(), a_, new Point(0, 423), 20, 40, new esj(60, 60), new Vector2(30f, 30f), 1f, 0));
				d9d.o7(new esm(TimelapseCursor.InvokeHostileSpellWithChance.ToString(), a_, new Point(0, 423), 20, 40, new esj(60, 60), new Vector2(30f, 30f), 1f));
				d9d.o7(new esm(TimelapseCursor.Attack.ToString(), a_, new Point(1, 531), 12, 40, new esj(60, 60), new Vector2(30f, 30f), 1f));
				d9d.o7(new esm(TimelapseCursor.SpecialAttack.ToString(), a_, new Point(1, 593), 12, 40, new esj(61, 61), new Vector2(31f, 31f), 1f));
				d9d.o7(new bnz(TimelapseCursor.Talk.ToString(), a_, new Point(151, 54), 4, 180, new esj(40, 33), new Vector2(17f, 31f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.AreaTransition.ToString(), a_, new Point(1, 318), 18, 50, new esj(55, 41), new Vector2(38f, 22f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Lock.ToString(), a_, new Point(703, 284), 6, 90, new esj(24, 32), new Vector2(12f, 20f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Lockpick.ToString(), a_, new Point(83, 99), 1, 500, new esj(60, 52), new Vector2(8f, 10f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Hack.ToString(), a_, new Point(1, 176), 20, 50, new esj(47, 64), new Vector2(7f, 5f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Pickpocket.ToString(), a_, new Point(65, 1), 1, 500, new esj(47, 36), new Vector2(5f, 26f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Power.ToString(), a_, new Point(65, 54), 1, 500, new esj(42, 43), new Vector2(26f, 19f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenPower.ToString(), a_, new Point(107, 54), 1, 500, new esj(42, 43), new Vector2(26f, 19f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Reload.ToString(), a_, new Point(275, 124), 1, 500, new esj(29, 45), new Vector2(10f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Wait.ToString(), a_, new Point(1, 485), 26, 80, new esj(44, 44), new Vector2(22f, 22f), 0.5f, 0));
				d9d.o7(new bnz(TimelapseCursor.DisarmTrap.ToString(), a_, new Point(145, 99), 1, 500, new esj(47, 47), new Vector2(4f, 4f), 1f, 0));
				d9d.o7(new esm(TimelapseCursor.GroundAttack.ToString(), a_, new Point(1, 531), 12, 40, new esj(60, 60), new Vector2(30f, 30f), 1f));
				d9d.o7(new bnz(TimelapseCursor.MultiUse.ToString(), a_, new Point(1, 99), 1, 500, new esj(40, 60), new Vector2(12f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenMultiUse.ToString(), a_, new Point(41, 99), 1, 500, new esj(40, 60), new Vector2(12f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Observe.ToString(), a_, new Point(114, 1), 1, 500, new esj(50, 26), new Vector2(26f, 13f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ObserveMultiple.ToString(), a_, new Point(114, 1), 4, 250, new esj(63, 26), new Vector2(26f, 13f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Disembark.ToString(), a_, new Point(1, 242), 14, 75, new esj(50, 36), new Vector2(25f, 18f), 1f, 300));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenDisembark.ToString(), a_, new Point(1, 280), 14, 75, new esj(50, 36), new Vector2(25f, 18f), 1f, 300));
				d9d.o7(new bnz(TimelapseCursor.Hotwire.ToString(), a_, new Point(194, 91), 1, 500, new esj(44, 55), new Vector2(7f, 8f), 1f, 0));
			}
			else
			{
				d9d.o7(new bnz(TimelapseCursor.Default.ToString(), a_, new Point(1, 1), 1, 500, new esj(24, 32), Vector2.Zero, 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Use.ToString(), a_, new Point(1, 35), 1, 500, new esj(20, 30), new Vector2(7f, 1f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenUse.ToString(), a_, new Point(21, 35), 1, 500, new esj(20, 30), new Vector2(7f, 1f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Impossible.ToString(), a_, new Point(108, 57), 1, 500, new esj(22, 22), new Vector2(11f, 11f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.InvokeSpell.ToString(), a_, new Point(0, 236), 20, 40, new esj(43, 43), new Vector2(22f, 22f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.InvokeHostileSpell.ToString(), a_, new Point(0, 279), 20, 40, new esj(43, 43), new Vector2(22f, 22f), 1f, 0));
				d9d.o7(new esm(TimelapseCursor.InvokeHostileSpellWithChance.ToString(), a_, new Point(0, 279), 20, 40, new esj(43, 43), new Vector2(22f, 22f), 1f));
				d9d.o7(new esm(TimelapseCursor.Attack.ToString(), a_, new Point(0, 353), 12, 40, new esj(43, 43), new Vector2(22f, 22f), 1f));
				d9d.o7(new esm(TimelapseCursor.SpecialAttack.ToString(), a_, new Point(1, 396), 12, 40, new esj(43, 43), new Vector2(22f, 22f), 1f));
				d9d.o7(new bnz(TimelapseCursor.Talk.ToString(), a_, new Point(177, 24), 4, 180, new esj(29, 25), new Vector2(12f, 23f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.AreaTransition.ToString(), a_, new Point(0, 104), 18, 50, new esj(36, 27), new Vector2(23f, 13f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Lock.ToString(), a_, new Point(108, 81), 6, 90, new esj(17, 22), new Vector2(8f, 13f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Lockpick.ToString(), a_, new Point(35, 67), 1, 500, new esj(40, 35), new Vector2(4f, 7f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Hack.ToString(), a_, new Point(1, 132), 20, 50, new esj(32, 43), new Vector2(4f, 3f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Pickpocket.ToString(), a_, new Point(46, 1), 1, 500, new esj(31, 24), new Vector2(3f, 17f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Power.ToString(), a_, new Point(97, 27), 1, 500, new esj(28, 28), new Vector2(17f, 11f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenPower.ToString(), a_, new Point(125, 27), 1, 500, new esj(28, 28), new Vector2(17f, 11f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Reload.ToString(), a_, new Point(155, 25), 1, 500, new esj(20, 30), new Vector2(7f, 2f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Wait.ToString(), a_, new Point(0, 322), 26, 80, new esj(31, 31), new Vector2(16f, 16f), 0.5f, 0));
				d9d.o7(new bnz(TimelapseCursor.DisarmTrap.ToString(), a_, new Point(1, 67), 1, 500, new esj(32, 32), new Vector2(3f, 3f), 1f, 0));
				d9d.o7(new esm(TimelapseCursor.GroundAttack.ToString(), a_, new Point(0, 353), 12, 40, new esj(43, 43), new Vector2(22f, 22f), 1f));
				d9d.o7(new bnz(TimelapseCursor.MultiUse.ToString(), a_, new Point(43, 27), 1, 500, new esj(26, 39), new Vector2(7f, 1f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenMultiUse.ToString(), a_, new Point(69, 27), 1, 500, new esj(26, 39), new Vector2(7f, 1f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Observe.ToString(), a_, new Point(79, 1), 1, 500, new esj(35, 17), new Vector2(17f, 8f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.ObserveMultiple.ToString(), a_, new Point(122, 1), 4, 250, new esj(43, 17), new Vector2(17f, 8f), 1f, 0));
				d9d.o7(new bnz(TimelapseCursor.Disembark.ToString(), a_, new Point(1, 177), 14, 75, new esj(35, 26), new Vector2(17f, 13f), 1f, 300));
				d9d.o7(new bnz(TimelapseCursor.ForbiddenDisembark.ToString(), a_, new Point(1, 205), 14, 75, new esj(35, 26), new Vector2(17f, 13f), 1f, 300));
				d9d.o7(new bnz(TimelapseCursor.Hotwire.ToString(), a_, new Point(76, 67), 1, 500, new esj(30, 36), new Vector2(4f, 5f), 1f, 0));
			}
		}
		bcm.aat(TimelapseCursor.Default.ToString());
	}

	// Token: 0x0600BEBB RID: 48827 RVA: 0x0041B9BC File Offset: 0x00419BBC
	public static bool a(azr A_0)
	{
		d1a service = bpo.GetService<d1a>();
		return service.aam() != null && service.aam().ajs() == A_0;
	}

	// Token: 0x0600BEBC RID: 48828 RVA: 0x0041B9EC File Offset: 0x00419BEC
	public static void a(euz A_0, aqo A_1 = aqo.a, Point? A_2 = null)
	{
		if (!bpo.GetServiceOrThrow<cnk>().aq1().b().q)
		{
			return;
		}
		d1a service = bpo.GetService<d1a>();
		if (service == null)
		{
			return;
		}
		euz euz = service.aam() as euz;
		if (euz != null)
		{
			service.aam().ajt(A_0);
			euz.a9();
		}
		else
		{
			euz = new c8r(A_1, A_0);
			bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow.aau() != null)
			{
				if (A_2 != null)
				{
					Point value = A_2.Value;
					if (value.X + euz.Size.c > serviceOrThrow.aau().Size.c)
					{
						value.X = serviceOrThrow.aau().Size.c - euz.Size.c;
					}
					if (value.Y + euz.Size.d > serviceOrThrow.aau().Size.d)
					{
						value.Y = serviceOrThrow.aau().Size.d - euz.Size.d;
					}
					euz.Location = value;
				}
				else
				{
					euz.Location = new Point((serviceOrThrow.aau().Size.c - euz.Size.c) / 2, serviceOrThrow.aau().Size.d - euz.Size.d);
				}
				if (A_0.at().Y + A_0.Size.d > euz.Location.Y)
				{
					euz.Location = new Point(euz.Location.X, 0);
				}
				euz.Gravity = axy.c;
				euz.i(new EventHandler(bl9.a));
				serviceOrThrow.aau().aox(euz);
				euz.a9();
			}
		}
		if (service != null)
		{
			service.aan(euz as aj3);
		}
	}

	// Token: 0x0600BEBD RID: 48829 RVA: 0x0041BBD8 File Offset: 0x00419DD8
	private static void a(object A_0, EventArgs A_1)
	{
		bl9.a();
	}

	// Token: 0x0600BEBE RID: 48830 RVA: 0x0041BBE4 File Offset: 0x00419DE4
	public static void a()
	{
		d1a service = bpo.GetService<d1a>();
		if (service != null)
		{
			service.abc();
		}
	}

	// Token: 0x0600BEBF RID: 48831 RVA: 0x0041BC04 File Offset: 0x00419E04
	public static void a(t3 A_0)
	{
		if (A_0 == null)
		{
			return;
		}
		string text = qv.b("Keyboard/AllAlphabetCharacters");
		if (!string.IsNullOrEmpty(text))
		{
			for (int i = 0; i < text.Length; i++)
			{
				A_0.m().Add(text[i]);
			}
		}
	}
}
