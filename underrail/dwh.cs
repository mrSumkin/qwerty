using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Items;

// Token: 0x020018F4 RID: 6388
public static class dwh
{
	// Token: 0x060087C3 RID: 34755 RVA: 0x00380FD0 File Offset: 0x0037F1D0
	static dwh()
	{
		dwh.q = new Dictionary<ItemStealingCategory, double>();
		dwh.q[ItemStealingCategory.Default] = 1.0;
		dwh.q[ItemStealingCategory.Money] = 1.15;
		dwh.q[ItemStealingCategory.Ammo] = 0.75;
		dwh.q[ItemStealingCategory.AmmoHeavy] = 1.35;
		dwh.q[ItemStealingCategory.Weapon] = 1.4;
		dwh.q[ItemStealingCategory.WeaponHeavy] = 1.8;
		dwh.q[ItemStealingCategory.Armor] = 2.0;
		dwh.q[ItemStealingCategory.ArmorHeavy] = 3.0;
		dwh.q[ItemStealingCategory.ThrownWeapon] = 1.0;
		dwh.q[ItemStealingCategory.Trap] = 1.5;
		dwh.q[ItemStealingCategory.VehiclePart] = 10.0;
		dwh.q[ItemStealingCategory.Luxury] = 1.5;
	}

	// Token: 0x0400355E RID: 13662
	public static readonly int a = 20;

	// Token: 0x0400355F RID: 13663
	public static readonly int b = 4;

	// Token: 0x04003560 RID: 13664
	public static readonly int c = 200;

	// Token: 0x04003561 RID: 13665
	public static readonly int d = 120;

	// Token: 0x04003562 RID: 13666
	public static readonly int e = 60;

	// Token: 0x04003563 RID: 13667
	public static readonly int f = 5;

	// Token: 0x04003564 RID: 13668
	public static readonly int g = 30;

	// Token: 0x04003565 RID: 13669
	public static readonly double h = 0.3;

	// Token: 0x04003566 RID: 13670
	public static readonly double i = 0.1;

	// Token: 0x04003567 RID: 13671
	public static readonly b1j j = new b1j(0.25, 0.8);

	// Token: 0x04003568 RID: 13672
	public static readonly b1j k = new b1j(0.25, 0.8);

	// Token: 0x04003569 RID: 13673
	public static readonly double l = 0.0003;

	// Token: 0x0400356A RID: 13674
	public static readonly double m = 0.05;

	// Token: 0x0400356B RID: 13675
	public static readonly double n = 2E-05;

	// Token: 0x0400356C RID: 13676
	public static readonly double o = 0.07;

	// Token: 0x0400356D RID: 13677
	public static readonly int p = 60;

	// Token: 0x0400356E RID: 13678
	public static readonly Dictionary<ItemStealingCategory, double> q;

	// Token: 0x0400356F RID: 13679
	public static readonly double r = 0.85;

	// Token: 0x04003570 RID: 13680
	public static readonly double s = 0.025;

	// Token: 0x04003571 RID: 13681
	public static readonly double t = 0.25;

	// Token: 0x04003572 RID: 13682
	public static readonly double u = 0.8;

	// Token: 0x04003573 RID: 13683
	public static readonly double v = 0.77;

	// Token: 0x04003574 RID: 13684
	public static readonly double w = 1.12;

	// Token: 0x04003575 RID: 13685
	public static readonly double x = 1.35;

	// Token: 0x04003576 RID: 13686
	public static readonly double y = dwh.w - dwh.v;

	// Token: 0x04003577 RID: 13687
	public static readonly int z = 15;

	// Token: 0x04003578 RID: 13688
	public static readonly int aa = 185;

	// Token: 0x04003579 RID: 13689
	public static readonly int ab = dwh.aa - dwh.z;
}
