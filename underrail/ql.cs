using System;
using System.Collections.Generic;
using System.Diagnostics;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200214D RID: 8525
[bmq("1.1.1.0_Cc_NewFactionArmors", "1.1.1.0", "*", true)]
public sealed class ql : fg
{
	// Token: 0x0600C8E0 RID: 51424 RVA: 0x0046EA54 File Offset: 0x0046CC54
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					amc aspect = c5x.GetAspect<amc>();
					dqv aspect2 = c5x.GetAspect<dqv>();
					if (aspect != null && aspect2 == null)
					{
						Random random = new Random(c5x.qe().GetHashCode() + c5x.Area.qe().GetHashCode());
						a6p aspect3 = c5x.GetAspect<a6p>();
						if (aspect3 != null && !string.IsNullOrEmpty(aspect3.b()))
						{
							bool flag = false;
							if (aspect3.b().StartsWith("Locale\\Creatures\\GenericHumans\\Praetorian", StringComparison.OrdinalIgnoreCase))
							{
								if (aspect3.b().Equals("Locale\\Creatures\\GenericHumans\\PraetorianGunner", StringComparison.OrdinalIgnoreCase))
								{
									flag = true;
									LibraryItemDefinitionProvider<c43> libraryItemDefinitionProvider;
									string text;
									if (aspect3.d() == null || (!ceo.a(new HashSet<string>(aspect3.d()), "model") && random.NextDouble() < 0.5))
									{
										libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<c43>("armor\\PraetorianHeavyArmorTabard");
										text = "praet";
									}
									else
									{
										libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<c43>("armor\\PraetorianHeavyArmorCaped");
										text = "praec";
									}
									if (libraryItemDefinitionProvider != null && libraryItemDefinitionProvider.wl() != null)
									{
										c8d a_ = new c8d(libraryItemDefinitionProvider);
										aspect.aa().Gear.l().a(a_, true);
									}
									LibraryItemDefinitionProvider<bqu> libraryItemDefinitionProvider2 = ez2.CreateDefinitonProvider<bqu>("armor\\PraetorianHeavyHelmet");
									if (libraryItemDefinitionProvider2 != null && libraryItemDefinitionProvider2.wl() != null)
									{
										k7 a_2 = new k7(libraryItemDefinitionProvider2);
										aspect.aa().Gear.g().a(a_2, true);
									}
									if (aspect.aa().Gender == Gender.Female)
									{
										text += "_f";
									}
									aspect.a(text);
								}
								else if (aspect3.b().Equals("Locale\\Creatures\\GenericHumans\\PraetorianBomber", StringComparison.OrdinalIgnoreCase) || aspect3.b().Equals("Locale\\Creatures\\GenericHumans\\PraetorianSniper", StringComparison.OrdinalIgnoreCase))
								{
									flag = true;
									LibraryItemDefinitionProvider<c43> libraryItemDefinitionProvider3 = ez2.CreateDefinitonProvider<c43>("armor\\PraetorianMediumArmor");
									if (libraryItemDefinitionProvider3 != null && libraryItemDefinitionProvider3.wl() != null)
									{
										c8d a_3 = new c8d(libraryItemDefinitionProvider3);
										aspect.aa().Gear.l().a(a_3, true);
									}
									LibraryItemDefinitionProvider<bqu> libraryItemDefinitionProvider4 = ez2.CreateDefinitonProvider<bqu>("armor\\gasMask");
									if (libraryItemDefinitionProvider4 != null && libraryItemDefinitionProvider4.wl() != null)
									{
										k7 a_4 = new k7(libraryItemDefinitionProvider4);
										aspect.aa().Gear.g().a(a_4, true);
									}
									aspect.a((aspect.aa().Gender == Gender.Female) ? "praem_f" : "praem");
								}
							}
							else if (aspect3.b().StartsWith("Locale\\Creatures\\GenericHumans\\JKK", StringComparison.OrdinalIgnoreCase))
							{
								flag = true;
								LibraryItemDefinitionProvider<c43> libraryItemDefinitionProvider5 = ez2.CreateDefinitonProvider<c43>("armor\\JkkTacticalVest");
								if (libraryItemDefinitionProvider5 != null && libraryItemDefinitionProvider5.wl() != null)
								{
									c8d a_5 = new c8d(libraryItemDefinitionProvider5);
									aspect.aa().Gear.l().a(a_5, true);
								}
								if (aspect.aa().Gender == Gender.Male)
								{
									aspect.a("jkk" + random.Next(1, 4).ToString());
								}
								else
								{
									aspect.a("jkk_f1");
								}
							}
							else if (aspect3.b().StartsWith("Locale\\Creatures\\GenericHumans\\Coretech", StringComparison.OrdinalIgnoreCase))
							{
								flag = true;
								LibraryItemDefinitionProvider<c43> libraryItemDefinitionProvider6 = ez2.CreateDefinitonProvider<c43>("armor\\CoretechTacticalVest");
								if (libraryItemDefinitionProvider6 != null && libraryItemDefinitionProvider6.wl() != null)
								{
									c8d c8d = new c8d(libraryItemDefinitionProvider6);
									if (c8d.fu().ba() != null)
									{
										c8d.Battery = (double)c8d.fu().ba().Value;
									}
									aspect.aa().Gear.l().a(c8d, true);
								}
								LibraryItemDefinitionProvider<bqu> libraryItemDefinitionProvider7 = ez2.CreateDefinitonProvider<bqu>("armor\\CoretechMask");
								if (libraryItemDefinitionProvider7 != null && libraryItemDefinitionProvider7.wl() != null)
								{
									k7 a_6 = new k7(libraryItemDefinitionProvider7);
									aspect.aa().Gear.g().a(a_6, true);
								}
								if (aspect.aa().Gender == Gender.Male)
								{
									aspect.a("crtec" + random.Next(1, 3).ToString());
								}
								else
								{
									aspect.a("crtec_f1");
								}
							}
							if (flag)
							{
								bn5 bn = c5x.GetAspect<j7>() as bn5;
								if (bn != null)
								{
									bm6 aspect4 = c5x.GetAspect<bm6>();
									if (aspect4 != null && aspect4.y6().GetPropertyValue(ddq.k) != null)
									{
										bn.a(false);
									}
								}
							}
						}
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
