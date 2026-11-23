using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020018BE RID: 6334
public static class adi
{
	// Token: 0x0600866C RID: 34412 RVA: 0x0037B610 File Offset: 0x00379810
	static adi()
	{
		adi.ae = new Dictionary<h, Color>();
		adi.ae.Add(global::h.e, Color.DeepSkyBlue);
		adi.ae.Add(global::h.d, Color.Green);
		adi.ae.Add(global::h.c, Color.DarkGray);
		adi.ae.Add(global::h.b, Color.Orange);
		adi.ae.Add(global::h.a, Color.Red);
		adi.af = new Dictionary<DamageType, Color>();
		adi.af[DamageType.Acid] = new Color(0, 255, 0);
		adi.af[DamageType.Cold] = Color.LightBlue;
		adi.af[DamageType.Electricity] = Color.Yellow;
		adi.af[DamageType.Heat] = Color.OrangeRed;
		adi.af[DamageType.Mechanical] = Color.White;
		adi.af[DamageType.Energy] = Color.Cyan;
		adi.af[DamageType.Bio] = Color.Olive;
		adi.ag = new Dictionary<cr1, Color>();
		adi.ag[cr1.a] = Color.Gray;
		adi.ag[cr1.b] = Color.White;
		adi.ag[cr1.c] = Color.LightGreen;
		adi.ag[cr1.d] = new Color(34, 104, 230);
		adi.ag[cr1.e] = Color.MediumPurple;
		adi.ag[cr1.f] = adi.c;
		adi.ah = new Dictionary<ImpactSpeed, Color>();
		adi.ah[ImpactSpeed.VeryLow] = new Color(5, 100, 100);
		adi.ah[ImpactSpeed.Low] = new Color(55, 100, 100);
		adi.ah[ImpactSpeed.Medium] = new Color(105, 100, 100);
		adi.ah[ImpactSpeed.High] = new Color(205, 100, 100);
		adi.ah[ImpactSpeed.VeryHigh] = new Color(255, 100, 100);
		adi.ai = new Dictionary<ci8, Color>();
		adi.ai[ci8.b] = new Color(0, 255, 0);
		adi.ai[ci8.a] = Color.Turquoise;
		adi.ai[ci8.c] = Color.Red;
		adi.aj = new Dictionary<cem, Color>();
		adi.aj[cem.a] = Color.Green;
		adi.aj[cem.b] = Color.Yellow;
		adi.aj[cem.c] = Color.Orange;
		adi.aj[cem.d] = Color.Red;
		adi.ak = new Dictionary<PsiSchool, Color>();
		adi.ak[PsiSchool.Metathermics] = new Color(255, 75, 0);
		adi.ak[PsiSchool.Psychokinesis] = new Color(185, 25, 250);
		adi.ak[PsiSchool.ThoughtControl] = Color.White;
		adi.ak[PsiSchool.TemporalManipulation] = new Color(0, 140, 115);
	}

	// Token: 0x04003392 RID: 13202
	public static readonly Color a = new Color(174, 87, 0, 255);

	// Token: 0x04003393 RID: 13203
	public static readonly Color b = new Color(89, 47, 7, 255);

	// Token: 0x04003394 RID: 13204
	public static readonly Color c = new Color(226, 113, 0, 255);

	// Token: 0x04003395 RID: 13205
	public static readonly Color d = Color.Orange;

	// Token: 0x04003396 RID: 13206
	public static readonly Color e = new Color(0, 0, 0, 150);

	// Token: 0x04003397 RID: 13207
	public static readonly Color f = new Color(190, 0, 190);

	// Token: 0x04003398 RID: 13208
	public static readonly Color g = Color.Salmon;

	// Token: 0x04003399 RID: 13209
	public static readonly Color h = Color.DarkOrange;

	// Token: 0x0400339A RID: 13210
	public static readonly Color i = Color.Red;

	// Token: 0x0400339B RID: 13211
	public static readonly Color j = Color.Red;

	// Token: 0x0400339C RID: 13212
	public static readonly Color k = Color.Red;

	// Token: 0x0400339D RID: 13213
	public static readonly Color l = Color.Red;

	// Token: 0x0400339E RID: 13214
	public static readonly Color m = Color.LightCoral;

	// Token: 0x0400339F RID: 13215
	public static readonly Color n = Color.Khaki;

	// Token: 0x040033A0 RID: 13216
	public static readonly Color o = Color.Tomato;

	// Token: 0x040033A1 RID: 13217
	public static readonly Color p = Color.Gold;

	// Token: 0x040033A2 RID: 13218
	public static readonly Color q = Color.Gold;

	// Token: 0x040033A3 RID: 13219
	public static readonly Color r = Color.LightBlue;

	// Token: 0x040033A4 RID: 13220
	public static readonly Color s = new Color(61, 199, 224, 255);

	// Token: 0x040033A5 RID: 13221
	public static readonly Color t = new Color(18, 98, 112, 255);

	// Token: 0x040033A6 RID: 13222
	public static readonly Color u = Color.DarkSlateBlue;

	// Token: 0x040033A7 RID: 13223
	public static readonly Color v = Color.SlateBlue;

	// Token: 0x040033A8 RID: 13224
	public static readonly Color w = Color.SkyBlue;

	// Token: 0x040033A9 RID: 13225
	public static readonly Color x = Color.CornflowerBlue;

	// Token: 0x040033AA RID: 13226
	public static readonly Color y = new Color(200, 50, 100);

	// Token: 0x040033AB RID: 13227
	public static readonly Color z = new Color(190, 0, 190);

	// Token: 0x040033AC RID: 13228
	public static readonly Color aa = new Color(255, 0, 100);

	// Token: 0x040033AD RID: 13229
	public static readonly Color ab = new Color(140, 0, 255);

	// Token: 0x040033AE RID: 13230
	public static readonly Color ac = new Color(100, 0, 255);

	// Token: 0x040033AF RID: 13231
	public static readonly Color ad = new Color(49, 146, 242, 255);

	// Token: 0x040033B0 RID: 13232
	public static readonly Dictionary<h, Color> ae;

	// Token: 0x040033B1 RID: 13233
	public static readonly Dictionary<DamageType, Color> af;

	// Token: 0x040033B2 RID: 13234
	public static readonly Dictionary<cr1, Color> ag;

	// Token: 0x040033B3 RID: 13235
	public static readonly Dictionary<ImpactSpeed, Color> ah;

	// Token: 0x040033B4 RID: 13236
	public static readonly Dictionary<ci8, Color> ai;

	// Token: 0x040033B5 RID: 13237
	public static readonly Dictionary<cem, Color> aj;

	// Token: 0x040033B6 RID: 13238
	public static readonly Dictionary<PsiSchool, Color> ak;

	// Token: 0x040033B7 RID: 13239
	public static readonly Color al = new Color(80, 80, 255);

	// Token: 0x040033B8 RID: 13240
	public static readonly Color am = new Color(16, 86, 16);

	// Token: 0x040033B9 RID: 13241
	public static readonly Color an = new Color(130, 131, 27);

	// Token: 0x040033BA RID: 13242
	public static readonly Color ao = new Color(255, 255, 50);

	// Token: 0x040033BB RID: 13243
	public static readonly Color ap = new Color(32, 170, 32);

	// Token: 0x040033BC RID: 13244
	public static readonly Color aq = Color.Red;

	// Token: 0x040033BD RID: 13245
	public static readonly Color ar = new Color(118, 215, 222);

	// Token: 0x040033BE RID: 13246
	public static readonly Color @as = new Color(190, 255, 255);
}
