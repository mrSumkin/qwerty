using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002152 RID: 8530
[dp2("1.1.0.1_ChemicalPistolChange", "1.1.0.1")]
public sealed class ald : dnv
{
	// Token: 0x0600C8EB RID: 51435 RVA: 0x0046F57C File Offset: 0x0046D77C
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null)
		{
			WeaponSubtype? weaponSubtype = bke.ae();
			WeaponSubtype weaponSubtype2 = WeaponSubtype.Pistol_Acid_Blob;
			if (weaponSubtype.GetValueOrDefault() >= weaponSubtype2 & weaponSubtype != null)
			{
				weaponSubtype = bke.ae();
				weaponSubtype2 = WeaponSubtype.Pistol_Indendiary_Blob;
				if (weaponSubtype.GetValueOrDefault() <= weaponSubtype2 & weaponSubtype != null)
				{
					List<coh> classPropertyValue = bke.a7().GetClassPropertyValue<List<coh>>("Components");
					if (classPropertyValue != null)
					{
						fv fv = Enumerable.FirstOrDefault<fv>(Enumerable.Where<fv>(Enumerable.OfType<fv>(classPropertyValue), new Func<fv, bool>(ald.a.a.a)));
						if (fv != null)
						{
							if (bke.ae().GetValueOrDefault() == WeaponSubtype.Pistol_Acid_Blob)
							{
								edm edm = Enumerable.FirstOrDefault<edm>(Enumerable.Where<edm>(bke.aa(), new Func<edm, bool>(ald.a.a.a)));
								if (edm != null)
								{
									edm.Chance = Math.Min(0.2 + (double)fv.QualityLevel / 400.0, 0.65);
								}
							}
							else if (bke.ae().GetValueOrDefault() == WeaponSubtype.Pistol_Cryo_Blob)
							{
								edm edm2 = Enumerable.FirstOrDefault<edm>(Enumerable.Where<edm>(bke.aa(), new Func<edm, bool>(ald.a.a.b)));
								if (edm2 != null)
								{
									edm2.Chance = Math.Min(0.2 + (double)fv.QualityLevel / 400.0, 0.65);
								}
							}
							else if (bke.ae().GetValueOrDefault() == WeaponSubtype.Pistol_Indendiary_Blob)
							{
								edm edm3 = Enumerable.FirstOrDefault<edm>(Enumerable.Where<edm>(bke.aa(), new Func<edm, bool>(ald.a.a.c)));
								if (edm3 != null)
								{
									edm3.Chance = Math.Min(0.2 + (double)fv.QualityLevel / 250.0, 0.75);
								}
							}
						}
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0600C8EC RID: 51436 RVA: 0x0046F7C0 File Offset: 0x0046D9C0
	public bool er(coh A_0)
	{
		return true;
	}

	// Token: 0x02002153 RID: 8531
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C8F0 RID: 51440 RVA: 0x0046F7E0 File Offset: 0x0046D9E0
		internal bool a(fv A_0)
		{
			return A_0.TypedDefinition.i() == ms.a5;
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x0046F7F4 File Offset: 0x0046D9F4
		internal bool a(edm A_0)
		{
			return A_0.Name == "acidicEntanglement";
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x0046F808 File Offset: 0x0046DA08
		internal bool b(edm A_0)
		{
			return A_0.Name == "freeze";
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x0046F81C File Offset: 0x0046DA1C
		internal bool c(edm A_0)
		{
			return A_0.Name == "ignite";
		}

		// Token: 0x04004A04 RID: 18948
		public static readonly ald.a a = new ald.a();

		// Token: 0x04004A05 RID: 18949
		public static Func<fv, bool> b;

		// Token: 0x04004A06 RID: 18950
		public static Func<edm, bool> c;

		// Token: 0x04004A07 RID: 18951
		public static Func<edm, bool> d;

		// Token: 0x04004A08 RID: 18952
		public static Func<edm, bool> e;
	}
}
