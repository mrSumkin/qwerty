using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200113B RID: 4411
[euj]
public sealed class a9l
{
	// Token: 0x06005E52 RID: 24146 RVA: 0x00280280 File Offset: 0x0027E480
	[ayh("PlayerMutant_GiveRustingAcidInfusion")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.h.b != null && A_0.h.b.aa() != null)
		{
			dnq dnq = new dnq();
			if (dnq != null)
			{
				A_0.h.b.aa().StatusEffects.a(dnq, false, false, false);
			}
		}
	}

	// Token: 0x06005E53 RID: 24147 RVA: 0x002802E4 File Offset: 0x0027E4E4
	[ayh("PlayerMutant_RustingAcidInfusion_Applied")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null)
		{
			A_1.h.b.aa();
		}
	}

	// Token: 0x06005E54 RID: 24148 RVA: 0x00280310 File Offset: 0x0027E510
	[ayh("PlayerMutant_RustingAcidInfusion_Expires")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null)
		{
			A_1.h.b.aa();
		}
	}

	// Token: 0x06005E55 RID: 24149 RVA: 0x0028033C File Offset: 0x0027E53C
	[ayh("PlayerMutant_GiveFireHandBuff")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.h.b != null && A_0.h.b.aa() != null)
		{
			b4p b4p = new b4p();
			if (b4p != null)
			{
				A_0.h.b.aa().StatusEffects.a(b4p, false, false, false);
			}
		}
	}

	// Token: 0x06005E56 RID: 24150 RVA: 0x002803A0 File Offset: 0x0027E5A0
	[ayh("PlayerMutant_FireHandBuff")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.h.b.aa() != null)
		{
			a9l.c(A_1.h.b.aa());
			a9l.a(A_1.h.b);
		}
	}

	// Token: 0x06005E57 RID: 24151 RVA: 0x00280400 File Offset: 0x0027E600
	[ayh("PlayerMutant_FireHandBuff_Expires")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.h.b.aa() != null)
		{
			a9l.a(A_1.h.b.aa());
			a9l.a(A_1.h.b);
		}
	}

	// Token: 0x06005E58 RID: 24152 RVA: 0x00280460 File Offset: 0x0027E660
	[ayh("PlayerMutant_GiveFrostHandBuff")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.h.b != null && A_0.h.b.aa() != null)
		{
			d3j d3j = new d3j();
			if (d3j != null)
			{
				A_0.h.b.aa().StatusEffects.a(d3j, false, false, false);
			}
		}
	}

	// Token: 0x06005E59 RID: 24153 RVA: 0x002804C4 File Offset: 0x0027E6C4
	[ayh("PlayerMutant_FrostHandBuff")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.h.b.aa() != null)
		{
			a9l.d(A_1.h.b.aa());
			a9l.a(A_1.h.b);
		}
	}

	// Token: 0x06005E5A RID: 24154 RVA: 0x00280524 File Offset: 0x0027E724
	[ayh("PlayerMutant_FrostHandBuff_Expires")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.h.b.aa() != null)
		{
			a9l.b(A_1.h.b.aa());
			a9l.a(A_1.h.b);
		}
	}

	// Token: 0x06005E5B RID: 24155 RVA: 0x00280584 File Offset: 0x0027E784
	public static void a(amc A_0)
	{
		if (A_0 != null)
		{
			bool flag = A_0.aa().Offense.b(WeaponKey.Primary).TypedDefinition.a5() == "pMutantBladeClawFire";
			bool flag2 = A_0.aa().Offense.b(WeaponKey.Secondary).TypedDefinition.a5() == "pMutantHugeClawFrost";
			string a_;
			if (flag)
			{
				if (flag2)
				{
					a_ = "plmutfi";
				}
				else
				{
					a_ = "plmutf";
				}
			}
			else if (flag2)
			{
				a_ = "plmuti";
			}
			else
			{
				a_ = "plmut";
			}
			A_0.a(a_);
		}
	}

	// Token: 0x06005E5C RID: 24156 RVA: 0x00280624 File Offset: 0x0027E824
	public static void d(efk A_0)
	{
		a9l.b(A_0, "_Frost");
	}

	// Token: 0x06005E5D RID: 24157 RVA: 0x00280634 File Offset: 0x0027E834
	public static void c(efk A_0)
	{
		a9l.a(A_0, "_Fire");
	}

	// Token: 0x06005E5E RID: 24158 RVA: 0x00280644 File Offset: 0x0027E844
	public static void b(efk A_0)
	{
		a9l.b(A_0, "");
	}

	// Token: 0x06005E5F RID: 24159 RVA: 0x00280654 File Offset: 0x0027E854
	public static void a(efk A_0)
	{
		a9l.a(A_0, "");
	}

	// Token: 0x06005E60 RID: 24160 RVA: 0x00280664 File Offset: 0x0027E864
	public static void b(efk A_0, string A_1)
	{
		LibraryItemDefinitionProvider<bke> libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<bke>("weapons\\PMutant_Slow" + A_1);
		if (libraryItemDefinitionProvider != null && libraryItemDefinitionProvider.wl() != null)
		{
			cd1 cd = new cd1(libraryItemDefinitionProvider);
			cd.TypedDefinition.d(CharacterState.Attack2.ToString());
			A_0.Gear.j()[WeaponKey.Secondary].a(cd, true);
		}
	}

	// Token: 0x06005E61 RID: 24161 RVA: 0x002806D0 File Offset: 0x0027E8D0
	public static void a(efk A_0, string A_1)
	{
		LibraryItemDefinitionProvider<bke> libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<bke>("weapons\\PMutant_Fast" + A_1);
		if (libraryItemDefinitionProvider != null && libraryItemDefinitionProvider.wl() != null)
		{
			cd1 cd = new cd1(libraryItemDefinitionProvider);
			cd.TypedDefinition.d(CharacterState.Attack1.ToString());
			A_0.Gear.j()[WeaponKey.Primary].a(cd, true);
		}
	}

	// Token: 0x06005E62 RID: 24162 RVA: 0x0028073C File Offset: 0x0027E93C
	public static void a(c5x A_0, amc A_1)
	{
		A_0.Size = new Vector3(1f, 1f, 1.85f);
		a9l.a(A_1);
		A_1.a6().Add(new dxl());
	}
}
